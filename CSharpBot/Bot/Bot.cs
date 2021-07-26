using System.Numerics;
using System.Windows.Media;
using Bot.Utilities.Processed.BallPrediction;
using Bot.Utilities.Processed.FieldInfo;
using Bot.Utilities.Processed.Packet;
using RLBotDotNet;

namespace Bot
{
    // We want to our bot to derive from Bot, and then implement its abstract methods.
    class Bot : RLBotDotNet.Bot
    {
        // We want the constructor for our Bot to extend from RLBotDotNet.Bot, but we don't want to add anything to it.
        // You might want to add logging initialisation or other types of setup up here before the bot starts.
        public Bot(string botName,
                   int botTeam,
                   int botIndex) : base(
                       botName,
                       botTeam,
                       botIndex) { }

        // Hide the old methods that return Flatbuffers objects and use our own methods that
        // use processed versions of those objects instead.
        internal FieldInfo GetFieldInfo() => new FieldInfo(base.GetFieldInfo());
        internal BallPrediction GetBallPrediction() => new BallPrediction(base.GetBallPrediction());
    }
}