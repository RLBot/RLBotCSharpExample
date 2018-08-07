namespace RLBotCSharpExample
{
    public static class DataConversion
    {
        public static System.Numerics.Vector3 ToVector3(this rlbot.flat.Vector3 vec)
        {
            return new System.Numerics.Vector3(vec.X, vec.Y, vec.Z);
        }

        public static System.Numerics.Vector2 ToVector2(this rlbot.flat.Vector3 vec)
        {
            return new System.Numerics.Vector2(vec.X, vec.Y);
        }
    }
}
