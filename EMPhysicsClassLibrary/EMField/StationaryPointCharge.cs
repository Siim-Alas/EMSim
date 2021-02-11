using System.Numerics;

namespace EMPhysicsClassLibrary.EMField
{
    /// <summary>
    /// Represents a stationary point charge of constant charge in 3D cartesian coordinates.
    /// </summary>
    public class StationaryPointCharge
    {
        /// <summary>
        /// Creates a new StatinaryPointCharge.
        /// </summary>
        /// <param name="charge">The charge in Culombs.</param>
        /// <param name="position">The 3D position vector in cartesian coordinates (in meters).</param>
        public StationaryPointCharge(double charge, Vector3 position)
        {
            Charge = charge;
            Position = position;
        }
        /// <summary>
        /// The charge in Culombs.
        /// </summary>
        public double Charge { get; }
        /// <summary>
        /// The 3D position vector in cartesian coordinates (in meters).
        /// </summary>
        public Vector3 Position { get; }
    }
}
