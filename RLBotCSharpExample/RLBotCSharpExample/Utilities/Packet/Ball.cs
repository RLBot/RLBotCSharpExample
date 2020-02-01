namespace RLBotCSharpExample.Utilities.Packet
{
    public class Ball
    {
        public Physics Physics;

        public Ball(rlbot.flat.BallInfo ballInfo)
        {
            Physics = new Physics(ballInfo.Physics.Value);
        }
    }
}