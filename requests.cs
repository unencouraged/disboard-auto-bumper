using RestSharp;

namespace disboard
{
    public class requests
    {
        public static void send_request(string channelid)
        {
            var client = new RestClient("https://discord.com");
            var request = new RestRequest("api/v6/channels/" + channelid + "/messages", Method.POST);
            request.AddJsonBody(new
            {
                content = "!d bump"
            });
            request.AddHeader("content-type", "application/json");
            request.AddHeader("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/86.0.4240.75 Safari/537.36");
            request.AddHeader("authorization", json_funcs.load_json("discord_token"));
            request.AddHeader("host", "discordapp.com");
            request.AddHeader("referer", "discordapp.com");
            /*var response = */client.Post(request);
            return;
        }
    }
}
