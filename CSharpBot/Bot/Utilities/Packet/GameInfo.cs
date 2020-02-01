namespace Bot.Utilities.Packet
{
    public class GameInfo
    {
        public float SecondsElapsed;
        public float GameTimeRemaining;
        public bool IsKickoffPause;

        public GameInfo(rlbot.flat.GameInfo gameInfo)
        {
            SecondsElapsed = gameInfo.SecondsElapsed;
            GameTimeRemaining = gameInfo.GameTimeRemaining;
            IsKickoffPause = gameInfo.IsKickoffPause;
        }
    }
}