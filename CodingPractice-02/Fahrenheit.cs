using System;
using System.Collections.Generic;
using System.Text;

public struct Fahrenheit
{
    public double Degrees;

    public Fahrenheit(double degrees)
    {
        Degrees = degrees;
    }

    public override string ToString()
    {
        return $"{Degrees}°F";
    }
}