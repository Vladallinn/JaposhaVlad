using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using newjaposha.models;
using Newtonsoft.Json;

namespace newjaposha.JsonHelpers
{
    public class JsonWriter
    {
        public static void WriteToJson(List<Order> orders, string JsonFileName)
        {
            string output = JsonConvert.SerializeObject(orders, Formatting.Indented);

            File.WriteAllText(JsonFileName, output);
        }
    }
}
