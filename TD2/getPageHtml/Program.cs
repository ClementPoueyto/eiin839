using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getPageHtml
{
    class Program
    {
        static void Main(string[] args)
        {
            string contentPage = "<h1> Question 5 </h1> <h2> executable : getPageHtml.exe </h2>";

            if (args.Length == 1)
            {
                Console.WriteLine(args[0]);
                contentPage += "<h3> argument 1 = " + args[0] + "</h3>";
            }
            else if (args.Length == 2)
            {
                
                    Console.WriteLine(args[0]);
                    contentPage += "<h3> argument 1 = " + args[0] + " argument 2 = "   + args[1] + " </h3>";
                
            }
            else
                contentPage += "<h3> pas d'arguments </h3>";
            Console.WriteLine(contentPage);
        }
    }
}
