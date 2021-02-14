using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web;

namespace BasicServerHTTPlistener
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            //if HttpListener is not supported by the Framework
            if (!HttpListener.IsSupported)
            {
                Console.WriteLine("A more recent Windows version is required to use the HttpListener class.");
                return;
            }
 
 
            // Create a listener.
            HttpListener listener = new HttpListener();

            // Add the prefixes.
            if (args.Length != 0)
            {
                foreach (string s in args)
                {
                    listener.Prefixes.Add(s);
                    // don't forget to authorize access to the TCP/IP addresses localhost:xxxx and localhost:yyyy 
                    // with netsh http add urlacl url=http://localhost:xxxx/ user="Tout le monde"
                    // and netsh http add urlacl url=http://localhost:yyyy/ user="Tout le monde"
                    // user="Tout le monde" is language dependent, use user=Everyone in english 

                }
            }
            else
            {
                Console.WriteLine("Syntax error: the call must contain at least one web server url as argument");
            }
            listener.Start();

            // get args 
            foreach (string s in args)
            {
                Console.WriteLine("Listening for connections on " + s);
            }

            // Trap Ctrl-C on console to exit 
            Console.CancelKeyPress += delegate {
                // call methods to close socket and exit
                listener.Stop();
                listener.Close();
                Environment.Exit(0);
            };


            while (true)
            {
                // Note: The GetContext method blocks while waiting for a request.
                HttpListenerContext context = listener.GetContext();
                HttpListenerRequest request = context.Request;

                string documentContents;
                using (Stream receiveStream = request.InputStream)
                {
                    using (StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8))
                    {
                        documentContents = readStream.ReadToEnd();
                    }
                }
                
                // get url 
                Console.WriteLine($"Received request for {request.Url}");

                //get url protocol
                Console.WriteLine(request.Url.Scheme);
                //get user in url
                Console.WriteLine(request.Url.UserInfo);
                //get host in url
                Console.WriteLine(request.Url.Host);
                //get port in url
                Console.WriteLine(request.Url.Port);
                //get path in url 
                Console.WriteLine(request.Url.LocalPath);

<<<<<<< HEAD
                string page="";
=======
>>>>>>> origin/TD2
                // parse path in url 
                foreach (string str in request.Url.Segments)
                {
                    Console.WriteLine(str);
<<<<<<< HEAD
                    page = str;
=======
>>>>>>> origin/TD2
                }

                //get params un url. After ? and between &

                Console.WriteLine(request.Url.Query);

<<<<<<< HEAD
                string param1 = "name";
                string param2 = "age";
                string param3 = "city";
                //parse params in url
                Console.WriteLine("param1 = " + HttpUtility.ParseQueryString(request.Url.Query).Get(param1));
                Console.WriteLine("param2 = " + HttpUtility.ParseQueryString(request.Url.Query).Get(param2));
                Console.WriteLine("param3 = " + HttpUtility.ParseQueryString(request.Url.Query).Get(param3));
=======
                //parse params in url
                Console.WriteLine("param1 = " + HttpUtility.ParseQueryString(request.Url.Query).Get("param1"));
                Console.WriteLine("param2 = " + HttpUtility.ParseQueryString(request.Url.Query).Get("param2"));
                Console.WriteLine("param3 = " + HttpUtility.ParseQueryString(request.Url.Query).Get("param3"));
>>>>>>> origin/TD2
                Console.WriteLine("param4 = " + HttpUtility.ParseQueryString(request.Url.Query).Get("param4"));

                //
                Console.WriteLine(documentContents);

                // Obtain a response object.
                HttpListenerResponse response = context.Response;
<<<<<<< HEAD
                string responseString = "<HTML><BODY> Hello world!";

                //questions 2 4 6
                if (request.Url.Segments.Length>3&&request.Url.Segments[1]=="td2/"&&request.Url.Segments[2] == "question/")
                {
                    if (request.Url.Segments[3] == "2") // question 2
                    {
                        // Construct a response.
                        responseString += "<h2> Question 2 </h2>";
                        responseString += "<h2>" + HttpUtility.ParseQueryString(request.Url.Query).Get(param1) + "</h2>";
                        responseString += "<h2>" + HttpUtility.ParseQueryString(request.Url.Query).Get(param2) + "</h2>";
                        responseString += "<h2>" + HttpUtility.ParseQueryString(request.Url.Query).Get(param3) + "</h2>";
                        
                    }
                    else if (request.Url.Segments[3] == "4") //question 4
                    {

                        MyMethods myMethod = new MyMethods();
                        responseString += myMethod.getPageHtml(HttpUtility.ParseQueryString(request.Url.Query).Get(param1), HttpUtility.ParseQueryString(request.Url.Query).Get(param2));

                    }
                    else //question 6
                    {
                        callExternalService callExternalService = new callExternalService();
                        responseString +=callExternalService.call(HttpUtility.ParseQueryString(request.Url.Query).Get(param1), HttpUtility.ParseQueryString(request.Url.Query).Get(param2));
                    }
                }
                else
                {
                    responseString += "<h2> " +  "404 not found" + "</h2>";
                    responseString += "<h2> " + request.Url + "</h2>";
                    responseString += "chemin a tester : http://localhost:8080/td2/question/2?name=jean&age=2&city=toulon";

                }
                responseString += "</ BODY ></ HTML > ";
=======

                // Construct a response.
                string responseString = "<HTML><BODY> Hello world!</BODY></HTML>";
>>>>>>> origin/TD2
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
                // Get a response stream and write the response to it.
                response.ContentLength64 = buffer.Length;
                System.IO.Stream output = response.OutputStream;
                output.Write(buffer, 0, buffer.Length);
                // You must close the output stream.
                output.Close();
            }
            // Httplistener neither stop ... But Ctrl-C do that ...
            // listener.Stop();
        }
    }
}