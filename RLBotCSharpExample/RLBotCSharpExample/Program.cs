using RLBotDotNet;

namespace RLBotCSharpExample
{
    class Program
    {
        static void Main()
        {
            // BotManager is a generic which takes in your bot as its T type.
            BotManager<ExampleBot> botManager = new BotManager<ExampleBot>();
            // Start the server on port 45031.
            botManager.Start(45031);
        }
    }
}
