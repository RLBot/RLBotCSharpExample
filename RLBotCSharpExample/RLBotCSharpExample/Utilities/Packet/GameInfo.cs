namespace RLBotCSharpExample.Utilities.Packet
{
    public struct GameInfo
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