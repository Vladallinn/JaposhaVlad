using newjaposha.models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace newjaposha.JsonHelpers
{
    public class JsonReader
    {
        public static List<Order> ReadJsonOrders(string JsonFileName)
        {
            string jsonString = File.ReadAllText(JsonFileName);

            return JsonConvert.DeserializeObject<List<Order>>(jsonString);
        }
    }
}
