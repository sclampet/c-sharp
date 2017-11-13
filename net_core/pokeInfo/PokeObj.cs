using System.Collections.Generic;
using Newtonsoft.Json.Linq;
namespace pokeInfo
{
    public class PokeObject
    {
        public string name;
        public string weight;
        public string height;
        public string image;
        public List<string> typeList = new List<string>();
        public PokeObject(Dictionary<string, object> jsonData)
        {
            JObject sprites = jsonData["sprites"] as JObject;
            JArray types = jsonData["types"] as JArray;

            name = jsonData["name"].ToString();
            weight = jsonData["weight"].ToString();
            height = jsonData["height"].ToString();
            image = sprites.GetValue("front_default").Value<string>();

            for (int idx = 0; idx < types.Count; idx++)
            {
                string theType = types[idx]["type"]["name"].ToString();
                typeList.Add(theType);
            }

        }

    }
}