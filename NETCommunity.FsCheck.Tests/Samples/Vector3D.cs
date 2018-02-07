using System;

namespace NETCommunity.FsCheck.Tests.Samples
{
    public struct Vector3D
    {
        public Vector3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public double X { get; }
        public double Y { get; }
        public double Z { get; }
        public double Length => 
            //X + Y + Z;
             Math.Sqrt(X * X + Y * Y + Z * Z);
        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
        public static Vector3D operator +(Vector3D first, Vector3D second)
        {
            return new Vector3D(first.X + second.X, first.Y + second.Y, first.Z + second.Z);
        }
    }
}