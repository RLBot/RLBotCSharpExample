using System;

namespace Bot
{
    class Program
    {
        static void Main(string[] args)
        {
            int port;
            try
            {
                // Read the port from the first argument
                port = int.Parse(args[0]);
            }
            catch (Exception e)
            {
                // If you're trying to run in a debugger, look up the port number used in PythonAgent.py
                // Right-click the project, choose Properties, go to the Debugging section -- there is a box for "Command Arguments", enter the port there.
                // Example: 45031
                Console.WriteLine("Could not get port from arguments to CSharp bot!");
                throw e;
            }

            RLBotDotNet.BotManager<Bot> botManager = new RLBotDotNet.BotManager<Bot>(0);
            // Start the server on the port given in the port.cfg file.
            botManager.Start(port);
        }
    }
}
