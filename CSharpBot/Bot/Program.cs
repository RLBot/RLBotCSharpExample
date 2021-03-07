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
                // If you're trying to run in a debugger, look up the port number used in PythonAgent.py in get_port()

                // If you're using Visual Studio:
                // Right-click the project, choose Properties, go to the Debug section -- there is a box for
                // "Command line arguments", enter the port there.

                // If you're using Rider:
                // Click the configuration dropdown to the left of the Run and Debug buttons (top right of the window),
                // choose Edit Configurations -- there is a box for "Program arguments", enter the port there.

                // Example: 45031
                Console.WriteLine("Could not get port from arguments to CSharp bot!");
                throw e;
            }

            RLBotDotNet.BotManager<Bot> botManager = new RLBotDotNet.BotManager<Bot>(0);
            // Start the server on the port given in the first argument
            botManager.Start(port);
        }
    }
}