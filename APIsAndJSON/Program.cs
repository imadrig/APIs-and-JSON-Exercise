using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Runtime.CompilerServices;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                QuoteGenerator.KanyeQuote();

                for (int j = 1; j <= 1; j++)
                {
                    QuoteGenerator.RonQuote();
                }
            }


        }
    }
}
