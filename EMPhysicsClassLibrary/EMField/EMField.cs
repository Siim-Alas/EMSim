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
        /// given time (this would happen if the retarded time was negative).
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
            double phi = Constants.K * q / d;
            return phi;
        }
        /// <summary>
        /// <para>
        /// Gets the gradient of the retarded electric potential 
        /// (https://en.wikipedia.org/wiki/Retarded_potential) at a point r caused by the 
        /// time-invariant point charge pointChrage. Note that this does not check for the case of the
        /// point charge being far enough away to not affect the point at a given time (this would 
        /// happen if the retarded time was negative).
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
            double dSquared = vectorFromRToThePointCharge.LengthSquared();
            Vector3 normalizedDirection = Vector3.Normalize(vectorFromRToThePointCharge);

            Vector3 gradientOfPhi = normalizedDirection * (float)(q * Constants.K / dSquared);
            return gradientOfPhi;
        }
    }
}
