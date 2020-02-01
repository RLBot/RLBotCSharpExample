namespace Bot.Utilities.Packet
{
    public class Player
    {
        public Physics Physics;
        public bool IsSupersonic;
        public bool HasWheelContact;
        public bool Jumped;
        public bool DoubleJumped;
        public string Name;
        public int Team;
        public int Boost;

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