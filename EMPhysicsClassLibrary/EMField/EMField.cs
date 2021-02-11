using System;
using System.Numerics;

namespace EMPhysicsClassLibrary.EMField
{
    public class EMField
    {
        /// <summary>
        /// <para>
        /// Gets the retarded electric potential (https://en.wikipedia.org/wiki/Retarded_potential) at 
        /// a point r caused by the stationary point charge pointChrage.
        /// </para>
        /// <para>
        /// As stated by the above Wikipedia article, the retarded electric potential is computed as 
        /// the integral over R^3 of (rho(r', tR) / |r - r'|) dr' divided by 4 pi epsilon0, where 
        /// tR = t - |r - r'| / c is the retarded time, t is the time at the point r, whose retarded 
        /// potential caused by the point charge is to be computed, rho(r', tR) is the charge density 
        /// at the location r' and time tR, and |x| is the length of the vector x.
        /// </para>
        /// </summary>
        /// <param name="pointCharge">The point charge affecting the retarded potential.</param>
        /// <param name="r">The position at which the retarded potential is measured.</param>
        /// <param name="t">The time at which the retarded potential is measured.</param>
        /// <returns>The retarded electric potential caused by the point charge at r.</returns>
        private static double GetRetardedPhi(
            StationaryPointCharge pointCharge, 
            Vector3 r, 
            double t)
        {
            // Gets |r - r'|, the distance between the point r and the point charge
            double d = (r - pointCharge.Position).Length();
            if ((t * Constants.C) < d)
            {
                // The point charge is far enough away so that it has no effect on the point r
                return 0;
            }

            // Note that the point charge is assumed to behave like a constant charge times the Dirac
            // delta function (https://en.wikipedia.org/wiki/Dirac_delta_function), generalized in the
            // Wikipedia article to vectors via the definition: integral over R^n of f(x)delta(dx) = 
            // = f(0), where f(x): R^n -> R^m, 0 is the 0-vector, and delta(dx) is the dirac delta 
            // function. This definition allows us to rewrite the retarded electric potential as 
            // phi = (1 / (4 pi epsilon0)) * (rho(r', tR) / |r - r'|).

            // Also note that as we assume a stationary point charge of constant charge, we need not
            // compute the retarded time, as it will not be necessary in the computation

            double phi = pointCharge.Charge / (4 * Math.PI * Constants.Epsilon0 * d);
            return phi;
        }
        /// <summary>
        /// <para>
        /// Gets the gradient of the retarded electric potential 
        /// (https://en.wikipedia.org/wiki/Retarded_potential) at a point r caused by the stationary 
        /// point charge pointChrage.
        /// </para>
        /// <para>
        /// As stated by the above Wikipedia article, the retarded electric potential is computed as 
        /// the integral over R^3 of (rho(r', tR) / |r - r'|) dr' divided by 4 pi epsilon0, where 
        /// tR = t - |r - r'| / c is the retarded time, t is the time at the point r, whose retarded 
        /// potential caused by the point charge is to be computed, rho(r', tR) is the charge density 
        /// at the location r' and time tR, and |x| is the length of the vector x.
        /// </para>
        /// <para>
        /// As the order of differentiation and integration can be switched, one can write the 
        /// integrand in the gradient of the retarded electric potential as 
        /// (gradient of rho(r', tR) * |r - r'| - (r - r') * rho(r', tR)) / |r - r'|^2.
        /// </para>
        /// </summary>
        /// <param name="pointCharge">The point charge affecting the retarded potential.</param>
        /// <param name="r">The position at which the retarded potential is measured.</param>
        /// <param name="t">The time at which the retarded potential is measured.</param>
        /// <returns>
        /// The gradient of the retarded electric potential caused by the point charge at r.
        /// </returns>
        private static Vector3 GetTheGradientOfRetardedPhi(
            StationaryPointCharge pointCharge,
            Vector3 r,
            double t)
        {
            throw new NotImplementedException();
        }
    }
}
