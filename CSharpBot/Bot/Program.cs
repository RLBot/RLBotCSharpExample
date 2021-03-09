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
                // IDE instructions to add the port argument:
                // If you're trying to run in an IDE and have auto-run disabled (e.g. to use the debugger), look up the port
                // number used in PythonAgent.py in get_port()

                // If you're using Visual Studio:
                // Right-click the project, choose Properties, go to the Debug section -- there is a box for
                // "Command line arguments", enter the port there.

                // If you're using Rider:
                // Click the configuration dropdown to the left of the Run and Debug buttons (top right of the window),
                // choose Edit Configurations -- there is a box for "Program arguments", enter the port there.

                // Example of a port: 45031


                var currentColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(
                    "Could not get port from arguments to C# bot!\n" +
                    "If you're reading this message, it means that the C# bot did not receive a valid port in the command line " +
                    "arguments.\n" +
                    "If you have configured auto-run, the port should be given to the bot automatically. Otherwise, you'll " +
                    "need to run the bot with the port every time (e.g. Bot.exe 45031). Note that this port should match the " +
                    "one in PythonAgent/PythonAgent.py.\n" +
                    "If you're trying to run the bot without auto-run in an IDE, see this source file " +
                    "(CSharpBot/Bot/Program.cs) for IDE instructions."
                );
                Console.ForegroundColor = currentColor;
                throw;
            }

            RLBotDotNet.BotManager<Bot> botManager = new RLBotDotNet.BotManager<Bot>(0);
            // Start the server on the port given in the first argument
            botManager.Start(port);
        }
    }
}