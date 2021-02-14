using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using System.IO;
namespace BasicServerHTTPlistener
{
    class callExternalService
    {

        public callExternalService()
        {

        }

        public string call(String arg1, String arg2) {
            //
            // Set up the process with the ProcessStartInfo class.
            // https://www.dotnetperls.com/process
            //
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = @"C:\Users\pouey\Documents\cours\SI4\soc\eiin839\TD2\getPageHtml\bin\Debug\getPageHtml.exe"; // Specify exe name.
            start.Arguments = arg1+" "+arg2; // Specify arguments.
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            //
            // Start the process.
            //
            using (Process process = Process.Start(start))
            {
                //
                // Read in all the text from the process with the StreamReader.
                //
                using (StreamReader reader = process.StandardOutput)
                {
                    return reader.ReadToEnd();
                  
                }
            }
        }
    }
    
}
