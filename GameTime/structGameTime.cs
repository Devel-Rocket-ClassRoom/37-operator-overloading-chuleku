using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Text;
struct GameTime
{
    public int Hours;
    public int Minutes;
    public int Seconds;
    

    public GameTime(int hours, int minutes, int seconds)
    {
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
        while (true)
        {
            if (Seconds > 60)
            {
                Seconds -= 60;
                Minutes++;
            }
            else if (Minutes > 60)
            {
                Minutes -= 60;
                Hours++;
            }
            else if (Seconds < 60 && Minutes < 60)
            {
                break;
            }
        }
    }
    public static GameTime operator +(GameTime a, GameTime b)
    {
        return new GameTime(a.Hours + b.Hours, a.Minutes + b.Minutes, a.Seconds + b.Seconds);
    }
    public static GameTime operator -(GameTime a, GameTime b)
    {
        if(a.Hours-b.Hours<0||a.Minutes-b.Minutes<0||a.Seconds-b.Seconds<0)
        {
            return new GameTime(a.Hours=0,a.Minutes=0,a.Seconds=0);
        }
        return new GameTime(a.Hours, a.Minutes, a.Seconds);
        
    }
    public static GameTime operator *(GameTime T, int scalar)
    {
        return new GameTime(T.Hours * scalar, T.Minutes * scalar, T.Seconds * scalar);
    }
    public static GameTime operator *(int scalar, GameTime T)
    {
        return T * scalar;
    }
    public static bool operator ==(GameTime a, GameTime b)
    {
        return a.Hours==b.Hours&&a.Minutes==b.Minutes&&a.Seconds==b.Seconds;
    }
    public static bool operator !=(GameTime a, GameTime b)
    {
        return !(a == b);
    }
    public static bool operator >(GameTime a, GameTime b)
    {
        if (a.Hours > b.Hours || a.Minutes > b.Minutes || a.Seconds > b.Seconds)
        {
            return a.GetTotalSeconds() > b.GetTotalSeconds();
        }
        else
        {
            throw new InvalidOperationException("잘못된 시간입니다.");
        }
    }
    public static bool operator <(GameTime a, GameTime b)
    {
        if (a.Hours < b.Hours || a.Minutes < b.Minutes||a.Seconds<b.Seconds)
        {
            return a.GetTotalSeconds() < b.GetTotalSeconds();
        }
        else
        {
            throw new InvalidOperationException("잘못된 시간입니다.");
        }
    }
    public int GetTotalSeconds()
    {
        return Seconds += (Minutes * 60) + (Hours * 3600);
    }
    public override bool Equals(object obj)
    {
        if (obj is GameTime time)
        {
            return this == time;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(Hours,Minutes,Seconds);
    }
    public override string ToString()
    {
        return $"{Hours}h {Minutes}m {Seconds}s";
    }
}