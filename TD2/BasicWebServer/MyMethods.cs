using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicServerHTTPlistener
{
    class MyMethods
    {
        public MyMethods()
        {

        }

        public string getPageHtml(string parm1_value, string param2_value)
        {
            string responseString = "<HTML><BODY> Hello world!";
            responseString += "<h2> Question 4 </h2>";
            responseString += "<h2>" +parm1_value + "</h2>";
            responseString += "<h2>" + param2_value + "</h2>";
            responseString += "</ BODY ></ HTML > ";
            return responseString;
        }
    }
}
