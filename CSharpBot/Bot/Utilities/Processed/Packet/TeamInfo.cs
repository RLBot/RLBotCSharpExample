namespace Bot.Utilities.Processed.Packet
{
    public class TeamInfo
    {
        public int TeamIndex;
        public int Score;

        public TeamInfo(rlbot.flat.TeamInfo teamInfo)
        {
            TeamIndex = teamInfo.TeamIndex;
            Score = teamInfo.Score;
        }
    }
}