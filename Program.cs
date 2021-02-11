using System;

namespace disboard
{
    class Program
    {
        static void Main()
        {
            Console.Title = "unencouraged disboard bumper";
            Console.WriteLine("loading...");
            System.Threading.Thread.Sleep(1000);
            requests.send_request(json_funcs.load_json("channel_id"));
            Console.WriteLine("[" + DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm tt") + "] Message sent to channel " + json_funcs.load_json("channel_id"));
            System.Timers.Timer t;
            t = new System.Timers.Timer();
            t.Elapsed += (sender, e) => timer_elapsed(sender, e);
            t.Interval = 7215000;
            t.Start();
            Console.ReadLine();
        }
        
        public static void timer_elapsed(object sender, EventArgs e)
        {
            requests.send_request(json_funcs.load_json("channel_id"));
            Console.WriteLine("[" + DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm tt") + "] Message sent to channel " + json_funcs.load_json("channel_id"));
        }
    }
}
