using System;

namespace TwitchBot
{
    class Program
    {
        static void Main(string[] args)
        {
            IrcClient client = new IrcClient("irc.twitch.tv", 6667, "mybot", "mypassword", "mychannel");

            var pinger = new Pinger(client);
            pinger.Start();

            while (true)
            {
                Console.WriteLine("Reading message");
                var message = client.ReadMessage();
                Console.WriteLine($"Message: {message}");
            }
        }
    }
}
