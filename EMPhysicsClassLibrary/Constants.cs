using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPhysicsClassLibrary
{
    /// <summary>
    /// A static class containing physical constants.
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// The speed of light, 299 792 458 m / s.
        /// </summary>
        public const double C = 2.99792458e+8;
        /// <summary>
        /// Epsilon nought, the permitivity of free space, 8.8541878128(13)*10^−12 F * m^−1.
        /// </summary>
        public const double Epsilon0 = 8.8541878128e-12;
        /// <summary>
        /// Coulomb's constant: 1 / (4 pi Epsilon0), 8.9875517923(14)*10^9 kg * m^3 * s^−2 * C^−2.
        /// </summary>
        public const double K = 8.9875517923e9;
        /// <summary>
        /// Mu nought, the permeability of free space, 1.25663706212(19)*10^−6 H / m.
        /// </summary>
        public const double Mu0 = 1.25663706212e-6;
    }
}
