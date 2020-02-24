using System.Numerics;

namespace Bot.Utilities.Processed.FieldInfo
{
    public struct GoalInfo
    {
        public Vector3 Direction;
        public Vector3 Location;
        public int TeamNum;

        public GoalInfo(rlbot.flat.GoalInfo goalInfo)
        {
            Direction = goalInfo.Direction.Value.ToVector3();
            Location = goalInfo.Location.Value.ToVector3();
            TeamNum = goalInfo.TeamNum;
        }
    }
}