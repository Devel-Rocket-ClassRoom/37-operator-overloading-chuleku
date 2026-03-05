using System;
using System.Collections.Generic;
using System.Text;

struct Vector3
{
    public float X;
    public float Y;
    public float Z;
    public Vector3(float x, float y, float z)
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }
    public static Vector3 operator +(Vector3 v1, Vector3 v2)
    {
        return new Vector3(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
    }
    public static Vector3 operator -(Vector3 v1, Vector3 v2)
    {
        return new Vector3(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
    }
    public static Vector3 operator *(Vector3 v1, float scalar)
    {
        return new Vector3(v1.X * scalar, v1.Y * scalar, v1.Z * scalar);
    }
    public static Vector3 operator *(float scalar, Vector3 v)
    {
        return v * scalar;
    }

    public static Vector3 operator -(Vector3 v)
    {
        return new Vector3(-v.X, -v.Y, -v.Z);
    }
    public static bool operator ==(Vector3 v1, Vector3 v2)
    {
        return v1.X == v2.X&&v1.Y == v2.Y && v1.Z == v2.Z;
    }
    public static bool operator !=(Vector3 v1, Vector3 v2)
    {
        return !(v1 == v2);
    }
    public override bool Equals(object obj)
    {
        if (obj is Vector3 other)
        {
            return this == other;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y, Z);
    }
    public override string ToString()
    {
        return $"({X},{Y},{Z})";
    }
}