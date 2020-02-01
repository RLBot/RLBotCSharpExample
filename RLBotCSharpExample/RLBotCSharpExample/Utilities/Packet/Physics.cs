using System.Numerics;

namespace RLBotCSharpExample.Utilities.Packet
{
    public struct Physics
    {
        public Vector3 Location;
        public Vector3 Velocity;
        public Orientation Rotation;
        public Vector3 AngularVelocity;

        public Physics(rlbot.flat.Physics physics)
        {
            Location = physics.Location.Value.ToVector3();
            Velocity = physics.Velocity.Value.ToVector3();
            AngularVelocity = physics.AngularVelocity.Value.ToVector3();
            Rotation = new Orientation(physics.Rotation.Value);
        }
    }
}