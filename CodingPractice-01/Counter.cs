using System;
using System.Collections.Generic;
using System.Text;

public struct Counter
{
    public int Value;
    public Counter(int value)
    {
        this.Value = value;
    }
    public static Counter operator -(Counter C)
    {
        return new Counter(-C.Value);
    }
    public static Counter operator ++(Counter C)
    {
        return new Counter(++C.Value);
    }

    public override string ToString()
    {
        return Value.ToString();
    }
}