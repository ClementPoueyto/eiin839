//Clement P 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Text;
using System.Collections.Specialized;

namespace BasicServerHTTPlistener
{
    class Header
    {
        System.Net.WebHeaderCollection headers;

        public Header(NameValueCollection headers){
            this.headers = (System.Net.WebHeaderCollection)headers;
        }

        public String Accept(){
            if (headers[System.Net.HttpRequestHeader.Accept] != null)
            {
                return "Accept : " + headers[System.Net.HttpRequestHeader.Accept];
            }
            return "Accept : ";
        }

        public String AcceptCharset()
        {
            if (headers[System.Net.HttpRequestHeader.AcceptCharset] != null)
            {
                return "Accept-Charset : " + headers[System.Net.HttpRequestHeader.AcceptCharset];
            }

            return "Accept-Charset : ";
        }

        public String AcceptEncoding()
        {
            if (headers[System.Net.HttpRequestHeader.AcceptEncoding] != null)
            {
                return "Accept-Encoding : " + headers[System.Net.HttpRequestHeader.AcceptEncoding];
            }
            return "Accept-Encoding : ";
        }

        public String AcceptLanguage()
        {
            if (headers[System.Net.HttpRequestHeader.AcceptLanguage] != null)
            {
                return "Accept-Language : " + headers[System.Net.HttpRequestHeader.AcceptLanguage];
            }
            return "Accept-Language : ";
        }

        public String Allow()
        {   
            if (headers[System.Net.HttpRequestHeader.Allow] != null)
            {
                return "Allow : " + headers[System.Net.HttpRequestHeader.Allow];
            }
            return "Allow : ";
        }

        public String Authorization()
        {
            if (headers[System.Net.HttpRequestHeader.Authorization] != null)
            {
                return "Authorization : " + headers[System.Net.HttpRequestHeader.Authorization];
            }
            return "Authorization : ";
        }

        public String CacheControl()
        {
            if (headers[System.Net.HttpRequestHeader.CacheControl] != null)
            {
                return "Cache-Control : " + headers[System.Net.HttpRequestHeader.CacheControl];
            }
            return "Cache-Control : ";
        }

        public String Connection()
        {
            if (headers[System.Net.HttpRequestHeader.Connection] != null)
            {
                return "Connection : " + headers[System.Net.HttpRequestHeader.Connection];
            }
            return "Connection : ";
        }


        public String ContentLanguage()
        {
            if (headers[System.Net.HttpRequestHeader.ContentLanguage] != null)
            {
                return "Content-Language : " + headers[System.Net.HttpRequestHeader.ContentLanguage];
            }
            return "Content-Language : ";
        }
        public String ContentEncoding()
        {
            if (headers[System.Net.HttpRequestHeader.ContentEncoding] != null)
            {
                return "Content-Encoding : " + headers[System.Net.HttpRequestHeader.ContentEncoding];
            }
            return "Content-Encoding : ";
        }
        public String From()
        {
            if (headers[System.Net.HttpRequestHeader.From] != null)
            {
                return "From : " + headers[System.Net.HttpRequestHeader.From];
            }
            return "From : ";
        }

        public String Cookie()
        {
            if (headers[System.Net.HttpRequestHeader.Cookie] != null)
            {
                return "Cookie : " + headers[System.Net.HttpRequestHeader.Cookie];
            }
            return "Cookie : ";
        }

       

        public String UserAgent()
        {
            if (headers[System.Net.HttpRequestHeader.UserAgent] != null)
            {
                return "User-Agent : " + headers[System.Net.HttpRequestHeader.UserAgent];
            }
            return "User-Agent : ";
        }

        public override String ToString()
        {
            return headers.ToString();
        }
    }

}


