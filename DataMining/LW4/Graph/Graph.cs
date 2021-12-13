using System;
using System.Collections.Generic;
using System.Linq;

namespace LW4.GraphUtillities
{
    public class Graph
    {
        public List<Page> Pages { get; }

        public Graph()
        {
            Pages = new List<Page>();
        }

        public Page FindPage(string uri)
        {
            var page = Pages.Find(m => m.Uri.ToLower() == uri.ToLower());

            return page;
        }

        public bool HasPage(string uri)
        {
            var page = Pages.Any(m => m.Uri.ToLower() == uri.ToLower());

            return page;
        }

        public void DisplayGraph()
        {
            foreach(var page in Pages)
            {
                Console.WriteLine($"Page ({page.Uri}) contains such links:");

                page.DisplayOutcomingPages();
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
