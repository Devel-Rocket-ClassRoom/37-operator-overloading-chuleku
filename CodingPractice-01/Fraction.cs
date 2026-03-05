using System;
using System.Collections.Generic;
using System.Text;
struct Fraction
{
    public int numerator;
    public int denomirator;

    public Fraction(int numerator, int denomirator)
    {
        this.numerator = numerator;
        this.denomirator = denomirator;
    }
    public static Fraction operator +(Fraction a, Fraction b)
    {
        int num = a.numerator * b.denomirator + b.numerator * a.denomirator;
        int den = a.denomirator * b.denomirator;
        return new Fraction(num, den);
    }
    public static Fraction operator *(Fraction a, Fraction b)
    {
        return new Fraction
            (
            a.numerator * b.numerator,
            a.denomirator * b.denomirator
            );
    }
    public override string ToString()
    {
        return $"{numerator}/{denomirator}";
    }

}