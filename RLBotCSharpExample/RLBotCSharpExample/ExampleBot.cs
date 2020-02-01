using System.Numerics;
using System.Windows.Media;
using RLBotDotNet;
using RLBotCSharpExample.Utilities.Packet;

namespace RLBotCSharpExample
{
    // We want to our bot to derive from Bot, and then implement its abstract methods.
    class ExampleBot : Bot
    {
        // We want the constructor for ExampleBot to extend from Bot, but we don't want to add anything to it.
        // You might want to add logging initialisation or other types of setup up here before the bot starts.
        public ExampleBot(string botName, int botTeam, int botIndex) : base(botName, botTeam, botIndex) { }

        public override Controller GetOutput(rlbot.flat.GameTickPacket gameTickPacket)
        {
            // We process the gameTickPacket and convert it to our own internal data structure.
            Packet packet = new Packet(gameTickPacket);

            // Get the data required to drive to the ball.
            Vector3 ballLocation = packet.Ball.Physics.Location;
            Vector3 carLocation = packet.Players[index].Physics.Location;
            Orientation carRotation = packet.Players[index].Physics.Rotation;

            // Find where the ball is relative to us.
            Vector3 ballRelativeLocation = Orientation.RelativeLocation(carLocation, ballLocation, carRotation);

            // Decide which way to steer in order to get to the ball.
            // If the ball is to our left, we steer left. Otherwise we steer right.
            float steer;
            if (ballRelativeLocation.Y > 0)
                steer = 1;
            else
                steer = -1;
            
            // Examples of rendering in the game
            Renderer.DrawString3D("Ball", Colors.Black, ballLocation, 3, 3);
            Renderer.DrawString3D(steer > 0 ? "Right" : "Left", Colors.Aqua, carLocation, 3, 3);
            Renderer.DrawLine3D(Colors.Red, carLocation, ballLocation);
            
            // This controller will contain all the inputs that we want the bot to perform.
            return new Controller
            {
                // Set the throttle to 1 so the bot can move.
                Throttle = 1,
                Steer = steer
            };
        }
    }
}