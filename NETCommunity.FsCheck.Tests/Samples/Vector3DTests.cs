using FsCheck.Xunit;

namespace NETCommunity.FsCheck.Tests.Samples
{
    [Properties(Arbitrary = new[] { typeof(VectorGenerator) })]
    public class Vector3DTests
    {
        [Property]
        public void Vector_Length_Is_Non_Negative(Vector3D vector)
        {
            CompareAssert.Assert(vector.Length).IsGreaterThanOrEqualTo(0);
        }
        [Property]
        public void Vector_Length_Is_At_Least_As_Great_As_Any_Component(Vector3D vector)
        {
            CompareAssert.Assert(vector.Length).IsGreaterThanOrEqualTo(vector.X);
            CompareAssert.Assert(vector.Length).IsGreaterThanOrEqualTo(vector.Y);
            CompareAssert.Assert(vector.Length).IsGreaterThanOrEqualTo(vector.Z);
        }
        [Property]
        public void Triangle_Inequality_Holds(Vector3D first, Vector3D second)
        {
            CompareAssert.Assert((first + second).Length).IsLessThanOrEqualTo(first.Length + second.Length);
        }
    }
}