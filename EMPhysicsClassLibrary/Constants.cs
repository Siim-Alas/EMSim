using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPhysicsClassLibrary
{
    /// <summary>
    /// A static class for storing physical constants.
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// Gets the Culomb constant, 8.9875517923(14)*10^9 kg * m^3 * s^−2 * C^−2
        /// </summary>
        public static double K { get; } = 8.9875517923e9;
        /// <summary>
        /// Mu nought, the permeability of free space, 1.25663706212(19)*10^−6 H / m
        /// </summary>
        public static double Mu0 { get; } = 1.25663706212e-6;
        /// <summary>
        /// Epsilon nought, the permitivity of free space, 8.8541878128(13)*10^−12 F * m^−1
        /// </summary>
        public static double Epsilon0 { get; } = 8.8541878128e-12;
    }
}
