using System;
using System.Numerics;

namespace EMPhysicsClassLibrary
{
    /// <summary>
    /// Represents a point charge in the electric field.
    /// </summary>
    public class PointCharge
    {
        /// <summary>
        /// Gets or sets the position of the point charge.
        /// </summary>
        public Vector<double> Position { get; set; }
        /// <summary>
        /// Gets or sets the charge of the point charge.
        /// </summary>
        public double Q { get; set; }

        /// <summary>
        /// Gets the effect that the given point charge has on the given point's electric field.
        /// </summary>
        /// <param name="point">The position vector of the point that the point charge is affecting.</param>
        /// <returns>The electric field vector representing the point charge's effect on the given point.</returns>
        public Vector<double> GetEffectOnEAtPoint(Vector<double> point)
        {
            Vector<double> r = point - Position;
            Vector<double> effectOnEAtPoint = Constants.K * Q / Math.Pow(Vector.Dot(r, r), 1.5) * r;

            return effectOnEAtPoint;
        }
    }
}
