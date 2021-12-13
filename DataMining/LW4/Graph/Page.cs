using System;
using System.Collections.Generic;
using System.Linq;

namespace LW4.GraphUtillities
{
    public class Page
    {
        private const double DAMPING_FACTOR = 0.5;

        private double? _pageRank;

        public string Uri { get; set; }

        public List<Page> ConnectedPages { get; set; }

        public List<Page> IncomingPages { get; set; }

        public Page(string uri)
        {
            _pageRank = null;

            Uri = uri;
            ConnectedPages = new List<Page>();
            IncomingPages = new List<Page>();
        }

        public void AddConnectedPage(Page page)
        {
            ConnectedPages.Add(page);
        }

        public void AddIncomingPage(Page page)
        {
            IncomingPages.Add(page);
        }

        public double GetPageRank(List<Page> calledPages)
        {
            if (_pageRank.HasValue)
            {
                return _pageRank.Value;
            }

            if (calledPages.Contains(this))
            {
                return 0;
            }

            calledPages.Add(this);

            var incomingPageRanks = 0D;

            var orderedIncomingPages = IncomingPages.OrderBy(m => m.IncomingPages.Count);

            foreach (var incomingPage in orderedIncomingPages)
            {
                var incomingPageRank = incomingPage.GetPageRank(calledPages);

                var incomingPageLinksCount = incomingPage.ConnectedPages.Count;

                if (incomingPageLinksCount == 0)
                {
                    throw new ArgumentException("Count of ConnectedPages for IncomingPage equals 0!");
                }

                incomingPageRanks += (incomingPageRank / incomingPageLinksCount);
            }

            _pageRank = (1 - DAMPING_FACTOR) + DAMPING_FACTOR * incomingPageRanks;

            return _pageRank.Value;
        }

        public void DisplayOutcomingPages()
        {
            foreach (var page in ConnectedPages)
            {
                Console.WriteLine($"\t{page.Uri}\t");
            }
        }
    }
}
