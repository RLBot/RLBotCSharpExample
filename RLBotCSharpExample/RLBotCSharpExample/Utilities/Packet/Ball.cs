namespace RLBotCSharpExample.Utilities.Packet
{
    public struct Ball
    {
        public Physics Physics;

        public Ball(rlbot.flat.BallInfo ballInfo)
        {
            Physics = new Physics(ballInfo.Physics.Value);
        }
    }
}