using System.Diagnostics.CodeAnalysis;

public struct CurrencyAmount
{
    private decimal amount;
    private string currency;

    public CurrencyAmount(decimal amount, string currency)
    {
        this.amount = amount;
        this.currency = currency;
    }

    // TODO: implement equality operators
    public static bool operator ==(CurrencyAmount lhs, CurrencyAmount rhs)
    {
        if (lhs.currency != rhs.currency) throw new ArgumentException();
        return lhs.amount == rhs.amount;
    }
    public static bool operator !=(CurrencyAmount lhs, CurrencyAmount rhs)
    {
        if (lhs.currency != rhs.currency) throw new ArgumentException();
        return lhs.amount != rhs.amount;
    }

    // TODO: implement comparison operators
    public static bool operator >(CurrencyAmount lhs, CurrencyAmount rhs)
    {
        if (lhs.currency != rhs.currency) throw new ArgumentException();
        return lhs.amount > rhs.amount;
    }
    public static bool operator <(CurrencyAmount lhs, CurrencyAmount rhs)
    {
        if (lhs.currency != rhs.currency) throw new ArgumentException();
        return lhs.amount < rhs.amount;
    }

    // TODO: implement arithmetic operators
    public static decimal operator +(CurrencyAmount lhs, CurrencyAmount rhs)
    {
        if (lhs.currency != rhs.currency) throw new ArgumentException();
        return lhs.amount + rhs.amount;
    }
    public static decimal operator -(CurrencyAmount lhs, CurrencyAmount rhs)
    {
        if (lhs.currency != rhs.currency) throw new ArgumentException();
        return lhs.amount - rhs.amount;
    }
    public static decimal operator *(CurrencyAmount lhs, CurrencyAmount rhs)
    {
        if (lhs.currency != rhs.currency) throw new ArgumentException();
        return lhs.amount * rhs.amount;
    }
    public static decimal operator /(CurrencyAmount lhs, CurrencyAmount rhs)
    {
        if (lhs.currency != rhs.currency) throw new ArgumentException();
        return lhs.amount / rhs.amount;
    }

    // TODO: implement type conversion operators
    public static explicit operator double(CurrencyAmount toConvert) => (double)toConvert.amount;
    public static implicit operator decimal(CurrencyAmount toConvert) => toConvert.amount;
}
