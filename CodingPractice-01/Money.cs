using System;
using System.Collections.Generic;
using System.Text;

struct Money
{
    public decimal Amount;
    public string Currency;

    public Money(decimal amount, string currency)
    {
        this.Amount = amount;
        this.Currency = currency;
    }
    public static bool operator ==(Money a, Money b)
    {
        return a.Currency == b.Currency && a.Amount == b.Amount;
    }
    public static bool operator !=(Money a, Money b)
    {
        return !(a == b);
    }
    public static bool operator <(Money a, Money b)
    {
        if (a.Currency != b.Currency)
        {
            throw new InvalidOperationException("통화가 다릅니다.");
        }
        return a.Amount < b.Amount;
    }
    public static bool operator >(Money a, Money b)
    {
        if (a.Currency != b.Currency)
        {
            throw new InvalidOperationException("통화가 다릅니다.");
        }
        return a.Amount > b.Amount;
    }
    public override bool Equals(object obj)
    {
        if (obj is Money other)
        {
            return this == other;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(Amount, Currency);
    }
}