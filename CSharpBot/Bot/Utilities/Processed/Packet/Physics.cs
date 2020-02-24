using System.Numerics;

namespace Bot.Utilities.Processed.Packet
{
    public class Physics
    {
        public Vector3 AngularVelocity;
        public Vector3 Location;
        public Orientation Rotation;
        public Vector3 Velocity;

        public Physics(rlbot.flat.Physics physics)
        {
            Location = physics.Location.Value.ToVector3();
            Velocity = physics.Velocity.Value.ToVector3();
            AngularVelocity = physics.AngularVelocity.Value.ToVector3();
            Rotation = new Orientation(physics.Rotation);
        }
    }
}