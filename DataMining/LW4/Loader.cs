using Sgml;
using System;
using System.IO;
using System.Net;
using System.Xml;

namespace LW4
{
    public static class Loader
    {
        public static XmlNode Load(Uri uri)
        {
            using (var response = GetResponse(uri.AbsoluteUri))
            {
                using (var stream = response.GetResponseStream())
                {
                    try
                    {
                        return GetXmlNode(stream);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Could not parse XmlPage.\nException: {ex}.\nStackTrace: {ex.StackTrace}");
                        return null;
                    }
                }
            }
        }

        public static XmlNode GetXmlNode(Stream stream)
        {
            using (SgmlReader sgml = new SgmlReader())
            {
                sgml.InputStream = new StreamReader(stream);

                var doc = new XmlDocument();

                doc.Load(sgml);

                return doc.DocumentElement;
            }
        }

        private static HttpWebResponse GetResponse(string uri)
        {
            try
            {
                HttpWebRequest request = GetWebRequest(uri);

                return (HttpWebResponse)request.GetResponse();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Could not get page Response {uri}.\nException: {ex}.\nStackTrace: {ex.StackTrace}");
            }

            return null;
        }

        private static HttpWebRequest GetWebRequest(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(uri);

            request.Method = "GET";
            request.Timeout = 300000;
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/96.0.4664.45 Safari/537.36";
            request.Accept = "text/html,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*";

            return request;
        }
    }
}
