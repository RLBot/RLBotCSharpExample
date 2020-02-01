namespace Bot.Utilities
{
    public static class DataConversion
    {
        public static System.Numerics.Vector3 ToVector3(this rlbot.flat.Vector3 vector)
        {
            return new System.Numerics.Vector3(vector.X, vector.Y, vector.Z);
        }

        public static System.Numerics.Vector2 ToVector2(this rlbot.flat.Vector3 vector)
        {
            return new System.Numerics.Vector2(vector.X, vector.Y);
        }
    }
}