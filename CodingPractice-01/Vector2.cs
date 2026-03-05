using System;
using System.Collections.Generic;
using System.Text;

struct Vector2
{
    public float X;
    public float Y;
    public Vector2(float x, float y)
    {
        this.X = x;
        this.Y = y;
    }

    public static Vector2 operator +(Vector2 v1, Vector2 v2)
    {
        return new Vector2(v1.X + v2.X, v1.Y + v2.Y);
    }
    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}