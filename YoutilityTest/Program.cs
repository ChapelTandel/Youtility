using System;
using YoutilityTest.Utility;

namespace YoutilityTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var restCountryApi = new RestCountryApi();
            var apiResponseContent = restCountryApi.GetCapital().Result.Content;

            var country = JsonHelper.DeserializeJsonToCountryObject(apiResponseContent);

            if (country != null)
            {
                Console.WriteLine(country.capital);
                foreach (var countryCurrency in country.currencies)
                    Console.WriteLine(countryCurrency.name == "British pound" ? "True" : "False");
            }
            else Console.WriteLine("Country details not found");

            Console.ReadKey();
        }
    }
}