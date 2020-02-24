namespace Bot.Utilities.Processed.Packet
{
    /// <summary>
    /// Processed version of the <see cref="rlbot.flat.GameTickPacket"/> that uses sane data structures.
    /// </summary>
    // This class is here for your convenience. It is NOT part of the framework and you can change it
    // as much as you want, or delete it entirely.
    // The benefits of using this instead of rlbot.flat.GameTickPacket are:
    //    - You avoid the displeasing .Value syntax of nullables due to Flatbuffers.
    //    - You end up with nice System.Numeric.Vector3 objects that you can call methods on.
    //    - If the framework changes its data format, you can just update the code here and leave your
    //      bot logic alone.
    // Note that this class and the classes inside are NOT complete. For example, Dropshot data has NOT
    // been added.
    // If you require any data from rlbot.flat.GameTickPacket that is missing in any of these classes,
    // you can add them yourself. You can always use Intellisense on rlbot.flat.GameTickPacket to see
    // what data is supported by RLBot and add them to these classes.
    public class Packet
    {
        public Player[] Players;
        public BoostPadState[] BoostPadStates;
        public Ball Ball;
        public GameInfo GameInfo;
        public TeamInfo[] Teams;

        public Packet(rlbot.flat.GameTickPacket packet)
        {
            Players = new Player[packet.PlayersLength];
            for (int i = 0; i < packet.PlayersLength; i++)
                Players[i] = new Player(packet.Players(i).Value);

            BoostPadStates = new BoostPadState[packet.BoostPadStatesLength];
            for (int i = 0; i < packet.BoostPadStatesLength; i++)
                BoostPadStates[i] = new BoostPadState(packet.BoostPadStates(i).Value);

            Ball = new Ball(packet.Ball.Value);
            GameInfo = new GameInfo(packet.GameInfo.Value);

            Teams = new TeamInfo[packet.TeamsLength];
            for (int i = 0; i < packet.TeamsLength; i++)
                Teams[i] = new TeamInfo(packet.Teams(i).Value);
        }
    }
}