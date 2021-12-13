using LW4.GraphUtillities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace LW4
{
    public static class Crawler
    {
        private static string _host;

        public static Graph Graph { get; set; }

        public static void StartScan(Uri rootUri)
        {
            Graph = new Graph();

            _host = rootUri.Host;

            var rootPage = new Page(rootUri.AbsoluteUri);

            ScanPage(rootPage);

            foreach (var page in Graph.Pages.OrderByDescending(m => m.GetPageRank(new List<Page>())))
            {
                Console.WriteLine($"PR: {page.GetPageRank(null)}\tIN: {page.IncomingPages.Count}\tOUT: {page.ConnectedPages.Count}\t{page.Uri}");
            }
        }

        private static void ScanPage(Page basePage)
        {
            Graph.Pages.Add(basePage);

            var pageXmlNode = Loader.Load(new Uri(basePage.Uri));

            var outgoingUries = GetXmlNodeUries(pageXmlNode);

            foreach (var outgoingUri in outgoingUries)
            {
                if (outgoingUri.AbsoluteUri == basePage.Uri)
                {
                    continue;
                }

                var outgoingPage = Graph.FindPage(outgoingUri.AbsoluteUri)
                    ?? new Page(outgoingUri.AbsoluteUri);

                if (!basePage.ConnectedPages.Contains(outgoingPage))
                //if (!basePage.ConnectedPages.Contains(outgoingPage) && !basePage.IncomingPages.Contains(outgoingPage))
                {
                    outgoingPage.AddIncomingPage(basePage);

                    basePage.AddConnectedPage(outgoingPage);
                }

                if (Graph.HasPage(outgoingUri.AbsoluteUri))
                {
                    continue;
                }

                ScanPage(outgoingPage);
            }
        }

        private static List<Uri> GetXmlNodeUries(XmlNode node)
        {
            var result = new List<Uri>();

            var uriNodes = node.SelectNodes(".//body//@href").Cast<XmlNode>();

            foreach (var uriNode in uriNodes)
            {
                var uriString = uriNode?.InnerText?.Trim('/') ?? String.Empty;

                if (uriString.IndexOf('?') != -1)
                {
                    uriString = uriString.Substring(0, uriString.IndexOf('?'));
                }

                if (String.IsNullOrEmpty(uriString) || uriString == _host)
                {
                    continue;
                }

                if (!uriString.StartsWith("http"))
                {
                    uriString = $"https://{uriString}";
                }

                if (!uriString.Contains(".php")
                    && !uriString.Contains(".js")
                    && !uriString.Contains(".css"))
                {
                    uriString = $"{uriString}/";
                }

                Uri uri = null;

                try
                {
                    uri = new Uri(uriString);
                }
                catch { continue; }

                if (uri.Host == _host)
                {
                    result.Add(uri);
                }
            }

            return result;
        }
    }
}
