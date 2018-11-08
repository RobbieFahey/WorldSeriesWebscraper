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
        static void GetPokemon(string[] args){
            var client = new HttpClient();

            var html = client
            .GetStringAsync("https://pokemondb.net/pokedex/national")
            .Result;

            var doc = new HtmlDocument();
            doc.LoadHtml(html);

            var divs = doc
            .DocumentNode
            .SelectNodes("html/body/main/div");

            var generations = divs
            .Skip(2)
            .Take(7);
        }
    }

    //define a class to hold the data we are collecting
}
//https://en.wikipedia.org/wiki/List_of_World_Series_champions#Winners
//div/span[2]/br/a

//div/span[2]/small[2]/a

//div/span[1]/a/span(@data-src)

class PokemonData
{
   public string Name { get; }  
   public string[] Types { get; }
   public string ImageLink { get; }
   public PokemonData(string name, string[] types, string imageLink)
   {
       Name = name;
       Types = types;
       ImageLink = imageLink;
   }
}

foreach (var gen in generations)
{
    var pokemonDivs = gen.SelectNodes("div");

    foreach (var pokemonDiv in pokemonDivs)
    {
        var name = pokemonDiv
        .SelectSingleNode("spab[2]/br/a")
        .InnerText;

        var types = pokemonDiv
        .SelectNodes("span[2]/small[2]/a")
        .Select(n n.InnerText)
        .ToArray();

        var imageLink = pokemonDiv
        .SelectSingleNode("span[1]/a/span")
        .
    
    }
}