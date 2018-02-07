using System.Collections.Generic;
using FsCheck;

namespace NETCommunity.FsCheck.Tests.Samples
{
    public static class VectorGenerator
    {
        public static Arbitrary<Vector3D> Vector3 => Arb.From(Vector3Gen, Vector3Shrink);

        private static Gen<double> NormalDouble()
            => from nf in Arb.Default.NormalFloat().Generator select nf.Get;

        private static readonly Gen<Vector3D> Vector3Gen =
            from x in NormalDouble()
            from y in NormalDouble()
            from z in NormalDouble()
            select new Vector3D(x, y, z);

        private static IEnumerable<Vector3D> Vector3Shrink(Vector3D vector)
        {
            if (vector.X != 0)
            {
                yield return new Vector3D(ShrinkProportional(vector.X), vector.Y, vector.Z);
                yield return new Vector3D(ShrinkLinear(vector.X), vector.Y, vector.Z);
            }
            if (vector.Y != 0)
            {
                yield return new Vector3D(vector.X, ShrinkProportional(vector.Y), vector.Z);
                yield return new Vector3D(vector.X, ShrinkLinear(vector.Y), vector.Z);
            }
            if (vector.Z != 0)
            {
                yield return new Vector3D(vector.X, vector.Y, ShrinkProportional(vector.Z));
                yield return new Vector3D(vector.X, vector.Y, ShrinkLinear(vector.Z));
            }
        }
        private static double ShrinkProportional(double x)
        {
            return x / 3;
        }
        private static double ShrinkLinear(double x)
        {
            if (x < -10)
            {
                return x + 10;
            }
            if (x > 10)
            {
                return x - 10;
            }
            return 0;
        }
    }
}