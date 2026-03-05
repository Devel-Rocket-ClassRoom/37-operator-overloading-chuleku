using System;
using System.Collections.Generic;
using System.Text;

struct Celsius
{
    public double Degrees;

    public Celsius(double degrees)
    {
        this.Degrees = degrees; 
    }

    public static implicit operator double (Celsius celsius)
    {
        return celsius.Degrees; 
    }
    public static implicit operator Celsius (double degrees)
    {
        return new Celsius(degrees);
    }
}