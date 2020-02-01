namespace RLBotCSharpExample.Utilities.Packet
{
    public struct BoostPadState
    {
        public float Timer;
        public bool IsActive;

        public BoostPadState(rlbot.flat.BoostPadState boostPadState)
        {
            Timer = boostPadState.Timer;
            IsActive = boostPadState.IsActive;
        }
    }
}