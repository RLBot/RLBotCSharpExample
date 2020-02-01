namespace RLBotCSharpExample.Utilities.Packet
{
    public class BoostPadState
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