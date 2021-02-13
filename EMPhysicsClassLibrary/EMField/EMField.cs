using System;
using System.Numerics;

namespace EMPhysicsClassLibrary.EMField
{
    public class EMField
    {
        /// <summary>
        /// <para>
        /// Gets the retarded electric potential (https://en.wikipedia.org/wiki/Retarded_potential) at 
        /// a point d meters from the time-invariant point charge pointChrage. Note that this does not 
        /// check for the case of the point charge being far enough away to not affect the point at a 
        /// given time (this would happen if the retarded time, as computed below, was negative).
        /// </para>
        /// <para>
        /// As stated by the above Wikipedia article, the retarded electric potential is computed as 
        /// the integral over R^3 of K * (rho(r', tR) / |r - r'|) dr', where K = 1 / (4 pi Epsilon0) 
        /// is Coulomb's constant, tR = t - |r - r'| / c is the retarded time, t is the time at the 
        /// point r, whose retarded potential caused by the point charge is to be computed, rho(r', tR)
        /// is the charge density at the location r' and time tR, and |x| is the length of the vector 
        /// x.
        /// </para>
        /// </summary>
        /// <param name="q">
        /// The electric charge of the point charge affecting the gradient of the retarded potential.
        /// </param>
        /// <param name="d">The distance to the point charge.</param>
        /// <returns>The retarded electric potential caused by the point charge at r.</returns>
        private static double GetPhiFromTimeInvariantPointCharge(
            double q, 
            double d)
        {
            // Note that the point charge is assumed to behave like a constant charge times the Dirac
            // delta function (https://en.wikipedia.org/wiki/Dirac_delta_function), generalized in the
            // Wikipedia article to vectors via the definition: integral over R^n of f(x)delta(x) dx =
            // = f(0), where f(x): R^n -> R^m, 0 is the 0-vector, and delta(dx) is the dirac delta 
            // function. This definition allows us to rewrite the retarded electric potential as 
            // phi = K * (q / |r - r_c|), where r_c is the position vector of the point charge and q 
            // is its electric charge.

            // Also note that as we assume a stationary point charge of constant electric charge, we
            // need not compute the retarded time, as it will not be necessary in the computation

            double phi = Constants.K * q / d;
            return phi;
        }
        /// <summary>
        /// <para>
        /// Gets the gradient of the retarded electric potential 
        /// (https://en.wikipedia.org/wiki/Retarded_potential) at a point r caused by the 
        /// time-invariant point charge pointChrage. Note that this does not check for the case of the
        /// point charge being far enough away to not affect the point at a given time (this would 
        /// happen if the retarded time, as computed below, was negative).
        /// </para>
        /// <para>
        /// As stated by the above Wikipedia article, the retarded electric potential is computed as 
        /// the integral over R^3 of K * (rho(r', tR) / |r - r'|) dr', where K = 1 / (4 pi Epsilon0) 
        /// is Coulomb's constant, tR = t - |r - r'| / c is the retarded time, t is the time at the 
        /// point r, whose retarded potential caused by the point charge is to be computed, rho(r', tR)
        /// is the charge density at the location r' and time tR, and |x| is the length of the vector 
        /// x.
        /// </para>
        /// <para>
        /// As the order of differentiation and integration can be switched, one can write the 
        /// integrand in the gradient (with respect to r) of the retarded electric potential as 
        /// - (r - r') * rho(r', tR) / |r - r'|^3.
        /// </para>
        /// </summary>
        /// <param name="q">
        /// The electric charge of the point charge affecting the gradient of the retarded potential.
        /// </param>
        /// <param name="vectorFromRToThePointCharge">
        /// r' - r, the position vector of the point charge minus the position vector of the point r 
        /// at which the gradient of the retarded electric potential is measured -- the vector pointing
        /// from the point r to the point charge.
        /// </param>
        /// <returns>
        /// The gradient of the retarded electric potential caused by the point charge at position r.
        /// </returns>
        private static Vector3 GetTheGradientOfPhiFromTimeInvariantPointCharge(
            double q,
            Vector3 vectorFromRToThePointCharge)
        {
            // Note that the point charge is assumed to behave like a constant charge times the Dirac
            // delta function (https://en.wikipedia.org/wiki/Dirac_delta_function), generalized in the
            // Wikipedia article to vectors via the definition: integral over R^n of f(x)delta(x) dx = 
            // = f(0), where f(x): R^n -> R^m, 0 is the 0-vector, and delta(dx) is the dirac delta 
            // function. This definition allows us to rewrite
            // gradient of phi = K * ((r' - r) * q / |r - r'|^3), where r' is now the position vector
            // of the point charge and q is its electric charge.

            // Also note that as we assume a stationary point charge of constant electric charge, we 
            // need not compute the retarded time, as it will not be necessary in the computation

            double dSquared = vectorFromRToThePointCharge.LengthSquared();
            Vector3 normalizedDirection = Vector3.Normalize(vectorFromRToThePointCharge);

            Vector3 gradientOfPhi = normalizedDirection * (float)(q * Constants.K / dSquared);
            return gradientOfPhi;
        }
    }
}
