using System;
using System.Numerics;

namespace Bot.Utilities.Processed.Packet
{
    public class Orientation
    {
        public float Pitch;
        public float Roll;
        public float Yaw;

        public Vector3 Forward;
        public Vector3 Right;
        public Vector3 Up;

        public Orientation(rlbot.flat.Rotator? rotator)
        {
            // The Rotator from the ball prediction is always null.
            // This ends up breaking this class unless we account for it.
            if (rotator.HasValue)
            {
                Pitch = rotator.Value.Pitch;
                Roll = rotator.Value.Roll;
                Yaw = rotator.Value.Yaw;
            }
            else
            {
                Pitch = 0;
                Roll = 0;
                Yaw = 0;
            }

            float cp = (float) Math.Cos(Pitch);
            float cy = (float) Math.Cos(Yaw);
            float cr = (float) Math.Cos(Roll);
            float sp = (float) Math.Sin(Pitch);
            float sy = (float) Math.Sin(Yaw);
            float sr = (float) Math.Sin(Roll);

            Forward = new Vector3(cp * cy, cp * sy, sp);
            Right = new Vector3(cy * sp * sr - cr * sy, sy * sp * sr + cr * cy, -cp * sr);
            Up = new Vector3(-cr * cy * sp - sr * sy, -cr * sy * sp + sr * cy, cp * cr);
        }

        /// <summary>
        /// Gets the <see cref="target"/> relative to an object at the given <see cref="start"/>
        /// location with the given <see cref="orientation"/>.<br/>
        /// For example, you can use this method to get the start of the ball relative to your car.
        /// </summary>
        /// <param name="start">
        /// The global location of the object you want to base the new target off of.
        /// This location will be the center of the world.
        /// </param>
        /// <param name="target">
        /// The global location of the target you want to get the relative location of.
        /// </param>
        /// <param name="orientation">The orientation of the current object.</param>
        /// <returns>
        /// Returns <see cref="target"/> as a relative location from <see cref="start"/> point of
        /// view using the given <see cref="orientation"/>.<br/>
        /// Rocket League's coordinate system might be different to what you're used to.
        /// The returned vector's components describe the following (relative to the start location
        /// and orientation):
        /// <list type="bullet">
        ///     <item>X: How far in front the target is</item>
        ///     <item>Y: How far right the target is</item>
        ///     <item>Z: How far above the target is</item>
        /// </list>
        /// </returns>
        public static Vector3 RelativeLocation(Vector3 start, Vector3 target, Orientation orientation)
        {
            Vector3 startToTarget = target - start;
            float x = Vector3.Dot(startToTarget, orientation.Forward);
            float y = Vector3.Dot(startToTarget, orientation.Right);
            float z = Vector3.Dot(startToTarget, orientation.Up);

            return new Vector3(x, y, z);
        }
    }
}