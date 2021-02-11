using System.IO;
using Newtonsoft.Json;

namespace disboard
{
    public class json_items
    {
        public static string channel_id { get; set; }
        public static string discord_token { get; set; }
    }

    public class json_funcs
    {
        public static string load_json(string option)
        {
            dynamic load = JsonConvert.DeserializeObject(File.ReadAllText("config.json"));
            json_items.channel_id = load.channel_id;
            json_items.discord_token = load.discord_token;
            if (option == "channel_id")
                return json_items.channel_id;
            if (option == "discord_token")
                return json_items.discord_token;
            else return string.Empty;
        }
    }
}
