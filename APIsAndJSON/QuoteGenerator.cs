using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class QuoteGenerator
    {
        public static void KanyeQuote()
        {
            var client = new HttpClient();

            var kanyeURL = "https://api.kanye.rest/";

            var kanyeSpeaks = client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeSpeaks).GetValue("quote").ToString();

            Console.WriteLine($"----------------------------");
            Console.WriteLine($"Kanye: \"{kanyeQuote}\"");
            Console.WriteLine($"----------------------------");
            Console.WriteLine();

        }


        public static void RonQuote()
        {
            var client = new HttpClient();

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronSpeaks = client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronSpeaks).ToString().Replace('[', ' ').Replace(']',' ').Trim();

            Console.WriteLine($"----------------------------");
            Console.WriteLine($"Ron: {ronQuote}");
            Console.WriteLine($"----------------------------");
            Console.WriteLine();

        }
    }
}
