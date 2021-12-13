using System;

namespace LW4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Uri uri;

            while (true)
            {
                Console.Write("Enter site URI: ");

                try
                {
                    uri = new Uri(Console.ReadLine().Trim());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("String is not URI.\n");
                }
            }

            Crawler.StartScan(uri);
        }
    }
}
