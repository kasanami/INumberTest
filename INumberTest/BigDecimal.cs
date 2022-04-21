using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INumberTest
{
    internal struct BigDecimal : INumber<BigDecimal>
    {
        public static BigDecimal One => throw new NotImplementedException();

        public static BigDecimal Zero => throw new NotImplementedException();

        public static BigDecimal AdditiveIdentity => throw new NotImplementedException();

        public static BigDecimal MultiplicativeIdentity => throw new NotImplementedException();

        public static BigDecimal Abs(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        public static BigDecimal Clamp(BigDecimal value, BigDecimal min, BigDecimal max)
        {
            throw new NotImplementedException();
        }

        public static BigDecimal Create<TOther>(TOther value) where TOther : INumber<TOther>
        {
            throw new NotImplementedException();
        }

        public static BigDecimal CreateSaturating<TOther>(TOther value) where TOther : INumber<TOther>
        {
            throw new NotImplementedException();
        }

        public static BigDecimal CreateTruncating<TOther>(TOther value) where TOther : INumber<TOther>
        {
            throw new NotImplementedException();
        }

        public static (BigDecimal Quotient, BigDecimal Remainder) DivRem(BigDecimal left, BigDecimal right)
        {
            throw new NotImplementedException();
        }

        public static BigDecimal Max(BigDecimal x, BigDecimal y)
        {
            throw new NotImplementedException();
        }

        public static BigDecimal Min(BigDecimal x, BigDecimal y)
        {
            throw new NotImplementedException();
        }

        public static BigDecimal Parse(string s, NumberStyles style, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static BigDecimal Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static BigDecimal Parse(ReadOnlySpan<char> s, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static BigDecimal Parse(string s, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static BigDecimal Sign(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        public static bool TryCreate<TOther>(TOther value, out BigDecimal result) where TOther : INumber<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryParse([NotNullWhen(true)] string? s, NumberStyles style, IFormatProvider? provider, out BigDecimal result)
        {
            throw new NotImplementedException();
        }

        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider, out BigDecimal result)
        {
            throw new NotImplementedException();
        }

        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, out BigDecimal result)
        {
            throw new NotImplementedException();
        }

        public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, out BigDecimal result)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(BigDecimal? other)
        {
            throw new NotImplementedException();
        }

        public bool Equals(BigDecimal? other)
        {
            throw new NotImplementedException();
        }

        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            throw new NotImplementedException();
        }

        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static BigDecimal operator +(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        public static BigDecimal operator +(BigDecimal left, BigDecimal right)
        {
            throw new NotImplementedException();
        }

        public static BigDecimal operator -(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        public static BigDecimal operator -(BigDecimal left, BigDecimal right)
        {
            throw new NotImplementedException();
        }

        public static BigDecimal operator ++(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        public static BigDecimal operator --(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        public static BigDecimal operator *(BigDecimal left, BigDecimal right)
        {
            throw new NotImplementedException();
        }

        public static BigDecimal operator /(BigDecimal left, BigDecimal right)
        {
            throw new NotImplementedException();
        }

        public static BigDecimal operator %(BigDecimal left, BigDecimal right)
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(BigDecimal left, BigDecimal right)
        {
            throw new NotImplementedException();
        }

        public static bool operator !=(BigDecimal left, BigDecimal right)
        {
            throw new NotImplementedException();
        }

        public static bool operator <(BigDecimal left, BigDecimal right)
        {
            throw new NotImplementedException();
        }

        public static bool operator >(BigDecimal left, BigDecimal right)
        {
            throw new NotImplementedException();
        }

        public static bool operator <=(BigDecimal left, BigDecimal right)
        {
            throw new NotImplementedException();
        }

        public static bool operator >=(BigDecimal left, BigDecimal right)
        {
            throw new NotImplementedException();
        }

#pragma warning disable CS8765 // パラメーターの型の NULL 値の許容が、オーバーライドされたメンバーと一致しません。おそらく、NULL 値の許容の属性が原因です。
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj is BigDecimal)
            {
                return Equals((BigDecimal)obj);
            }
            return false;
        }
#pragma warning restore CS8765 // パラメーターの型の NULL 値の許容が、オーバーライドされたメンバーと一致しません。おそらく、NULL 値の許容の属性が原因です。

        public int CompareTo(BigDecimal other)
        {
            throw new NotImplementedException();
        }

        public bool Equals(BigDecimal other)
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}