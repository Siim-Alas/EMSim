using System;
using System.Numerics;

namespace EMPhysicsClassLibrary
{
    /// <summary>
    /// Represents a point in the electromagnetic field.
    /// </summary>
    public class EMFieldPoint
    {
        /// <summary>
        /// Gets or sets the position of the field point.
        /// </summary>
        public Vector<double> Position { get; set; }
        /// <summary>
        /// Gets or sets the electric field vector at the field point.
        /// </summary>
        public Vector<double> E { get; set; }
        /// <summary>
        /// Gets or sets the magnetic field vector at the field point.
        /// </summary>
        public Vector<double> B { get; set; }
    }
}
