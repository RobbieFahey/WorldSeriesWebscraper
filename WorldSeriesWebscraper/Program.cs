using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WorldSeriesWebscraper
{
    class Program
    {
        static void Main(string[] args)
        {

            var client = new HttpClient();
            var result=client.GetStringAsync("https://en.wikipedia.org/wiki/List_of_World_Series_champions#Winners").Result;
            
        }
    }
}
//https://en.wikipedia.org/wiki/List_of_World_Series_champions#Winners