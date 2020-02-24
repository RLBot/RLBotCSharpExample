namespace Bot.Utilities.Processed.Packet
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