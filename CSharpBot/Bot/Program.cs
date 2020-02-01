using System.IO;

namespace Bot
{
    class Program
    {
        static void Main()
        {
            // Read the port from port.cfg.
            const string file = "port.cfg";
            string text = File.ReadAllLines(file)[0];
            int port = int.Parse(text);

            RLBotDotNet.BotManager<Bot> botManager = new RLBotDotNet.BotManager<Bot>(0);
            // Start the server on the port given in the port.cfg file.
            botManager.Start(port);
        }
    }
}
