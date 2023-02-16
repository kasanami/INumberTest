using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace INumberTest.Units.SI.Symbol
{
    /// <summary>
    /// 数値型に国際単位系の記号を付ける拡張。
    /// </summary>
    public static class SymbolExtensions
    {
        public static Joule<T> J<T>(this T value) where T : INumber<T>
        {
            return new Joule<T>(value);
        }
        public static Kilogram<T> kg<T>(this T value) where T : INumber<T>
        {
            return new Kilogram<T>(value);
        }
        public static Metre<T> m<T>(this T value) where T : INumber<T>
        {
            return new Metre<T>(value);
        }
        public static Newton<T> N<T>(this T value) where T : INumber<T>
        {
            return new Newton<T>(value);
        }
        public static Radian<T> rad<T>(this T value) where T : INumber<T>
        {
            return new Radian<T>(value);
        }
        public static Second<T> s<T>(this T value) where T : INumber<T>
        {
            return new Second<T>(value);
        }
    }
}
