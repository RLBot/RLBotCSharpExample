namespace Bot.Utilities.Processed.FieldInfo
{
    /// <summary>
    /// Processed version of the <see cref="rlbot.flat.FieldInfo"/> that uses sane data structures.
    /// </summary>
    // Just like the Packet class, this class is here for your convenience.
    // It is NOT part of the framework and you can change it as much as you want, or delete it entirely.
    public struct FieldInfo
    {
        public GoalInfo[] Goals;
        public BoostPad[] BoostPads;

        public FieldInfo(rlbot.flat.FieldInfo fieldInfo)
        {
            Goals = new GoalInfo[fieldInfo.GoalsLength];
            BoostPads = new BoostPad[fieldInfo.BoostPadsLength];

            for (int i = 0; i < fieldInfo.GoalsLength; i++)
                Goals[i] = new GoalInfo(fieldInfo.Goals(i).Value);

            for (int i = 0; i < fieldInfo.BoostPadsLength; i++)
                BoostPads[i] = new BoostPad(fieldInfo.BoostPads(i).Value);
        }
    }
}