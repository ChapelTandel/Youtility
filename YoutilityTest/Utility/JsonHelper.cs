using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using YoutilityTest.Models;

namespace YoutilityTest.Utility
{
    internal class JsonHelper
    {
        public static Country DeserializeJsonToCountryObject(string apiResponseContent)
        {
            if (apiResponseContent == null) throw new Exception("Json string not valid");
            var country = JsonConvert.DeserializeObject<List<Country>>(apiResponseContent).FirstOrDefault();
            return country;
        }
    }
}