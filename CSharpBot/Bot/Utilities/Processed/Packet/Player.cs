namespace Bot.Utilities.Processed.Packet
{
    public class Player
    {
        public int Boost;
        public bool DoubleJumped;
        public bool HasWheelContact;
        public bool IsSupersonic;
        public bool Jumped;
        public string Name;
        public Physics Physics;
        public int Team;

        public Player(rlbot.flat.PlayerInfo playerInfo)
        {
            Physics = new Physics(playerInfo.Physics.Value);
            IsSupersonic = playerInfo.IsSupersonic;
            HasWheelContact = playerInfo.HasWheelContact;
            Jumped = playerInfo.Jumped;
            DoubleJumped = playerInfo.DoubleJumped;
            Name = playerInfo.Name;
            Team = playerInfo.Team;
            Boost = playerInfo.Boost;
        }
    }
}