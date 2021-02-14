using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Text;

namespace BasicServerHTTPlistener
{
    class Header2
    {
        private string mime;
        private string charset;
        private string encoding;
        private string langage;
        private string methods;
        private string authorizations;
        private string cookie;
        private string from;
        private string host;

        public Header2(HttpListenerRequest request)
        {
            mime = request.Headers.Get(HttpRequestHeader.Accept.ToString());
            charset = request.Headers.Get(HttpRequestHeader.AcceptCharset.ToString());
            encoding = request.Headers.Get(HttpRequestHeader.AcceptEncoding.ToString());
            langage = request.Headers.Get(HttpRequestHeader.AcceptLanguage.ToString());
            methods = request.Headers.Get(HttpRequestHeader.Allow.ToString());
            authorizations = request.Headers.Get(HttpRequestHeader.Authorization.ToString());
            cookie = request.Headers.Get(HttpRequestHeader.Cookie.ToString());
            from = request.Headers.Get(HttpRequestHeader.From.ToString());
            host = request.Headers.Get(HttpRequestHeader.Host.ToString());
        }

        public override String ToString()
        {
            return 
                "mime : " + mime
                +"\ncharset : "+charset+
                "\nencoding :"+encoding+
                "\nlangage : "+langage+
                "\nmethods : "+methods+
                "\nauthorizations : "+authorizations+
                "\ncookie : "+cookie+
                "\nfrom : "+from+
                "\nhost : "+host;
        }


    }

}


