using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Intrinsics.X86;
using System.Text;

struct Gamecurrency
{
    public int Gold;
    public int Silver;
    public Gamecurrency(int gold, int silver)
    {
        Gold = gold;
        Silver = silver;
        while(Silver>100)
        {
            Silver -= 100;
            Gold++;
        }
    }
    public static Gamecurrency operator +(Gamecurrency a, Gamecurrency b)
    {
        return new Gamecurrency(a.Gold + b.Gold, a.Silver + b.Silver);
    }
    public static Gamecurrency operator -(Gamecurrency a, Gamecurrency b)
    {
        new Gamecurrency(a.Gold - b.Gold, a.Silver - b.Silver);
        if (a.Gold-b.Gold <0 || a.Silver-b.Silver <0)
        {
            return new Gamecurrency(a.Gold = 0, a.Silver = 0);
        }
        return new Gamecurrency(a.Gold,a.Silver);
    }
    public static bool operator ==(Gamecurrency a, Gamecurrency b)
    {
        return a.Gold == b.Gold && a.Silver == b.Silver;
    }
    public static bool operator !=(Gamecurrency a, Gamecurrency b)
    {
        return !(a == b);
    }
    public static bool operator >(Gamecurrency a, Gamecurrency b)
    {
        if (a.Gold > b.Gold || a.Silver > b.Silver)
        {
            return a.GetTotalSilver() > b.GetTotalSilver();
        }
        else
        {
            throw new InvalidOperationException("통화가 다릅니다.");
        }
    }
    public static bool operator <(Gamecurrency a, Gamecurrency b)
    {
        if (a.Gold < b.Gold || a.Silver < b.Silver)
        {
            return a.GetTotalSilver() < b.GetTotalSilver();
        }
        else
        {
            throw new InvalidOperationException("통화가 다릅니다.");
        }
    }
    public override string ToString()
    {
        return $"{Gold}G {Silver}S";
    }
    public int GetTotalSilver()
    {
       return  Silver += (Gold * 100);
    }
    public override bool Equals(object obj)
    {
        if (obj is Gamecurrency money)
        {
            return this == money;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(Gold,Silver);
    }
}