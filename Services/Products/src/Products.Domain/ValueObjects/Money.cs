using System;
using System.Globalization;
using GeekShopping.Services.Products.Domain.ValueObjects.Base;
using Microsoft.VisualBasic.CompilerServices;

namespace GeekShopping.Services.Products.Domain.ValueObjects
{
    public class Money : ValueObject
    {
        public Money(decimal value)
        {
            Value = value;
        }

        public decimal Value { get; }

        public static Money operator +(Money a, Money b) => new (a.Value + b.Value);
        public static Money operator +(Money a) => new(+a.Value);
        public static Money operator -(Money a, Money b) => new (a.Value - b.Value);
        public static Money operator -(Money a) => new (-a.Value);

        public static Money operator /(Money a, Money b)
        {
            if (b.Value is 0)
                throw new DivideByZeroException("O divisor não pode ser zero");

            return new Money(a.Value / b.Value);
        }

        public static Money operator *(Money a, int b) => new Money(a.Value * b);
        public static Money operator *(Money a, decimal b) => new Money(a.Value * b);

        public override string ToString()
        {
            return Value.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
