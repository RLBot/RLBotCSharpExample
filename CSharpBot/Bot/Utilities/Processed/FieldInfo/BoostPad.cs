using System.Numerics;

namespace Bot.Utilities.Processed.FieldInfo
{
    public struct BoostPad
    {
        public Vector3 Location;
        public bool IsFullBoost;

        public BoostPad(rlbot.flat.BoostPad boostPad)
        {
            Location = boostPad.Location.Value.ToVector3();
            IsFullBoost = boostPad.IsFullBoost;
        }
    }
}