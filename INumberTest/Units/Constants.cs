//using INumberTest.Units.GS;
//using INumberTest.Units.NonSI;
using INumberTest.Units.SI;

namespace INumberTest.Units
{
    /// <summary>
    /// 各単位の定数を定義
    /// <para>使用例 : var mass = 123 * Gram;</para>
    /// </summary>
    public static class Constants<T> where T : INumber<T>
    {
        #region GS
        //public static readonly KilogramForce<T> KilogramForce = new (1);
        //public static readonly StandardGravity<T> StandardGravity = new StandardGravity<T>(1);
        #endregion GS
        #region NonSI
        //public static readonly Calorie<T> Calorie = new Calorie<T>(1);
        //public static readonly Knot<T> Knot = new Knot<T>(1);
        //public static readonly NauticalMile<T> NauticalMile = new NauticalMile<T>(1);
        #endregion NonSI
        #region SI
        //public static readonly Ampere<T> Ampere = new Ampere<T>(1);
        //public static readonly Candela<T> Candela = new Candela<T>(1);
        //public static readonly Coulomb<T> Coulomb = new Coulomb<T>(1);
        //public static readonly CubicMetre<T> CubicMetre = new CubicMetre<T>(1);
        //public static readonly DegreeCelsius<T> DegreeCelsius = new DegreeCelsius<T>(1);
        //public static readonly Gram<T> Gram = new Gram<T>(1);
        //public static readonly Hour<T> Hour = new Hour<T>(1);
        public static readonly Joule<T> Joule = T.One;
        //public static readonly Kelvin<T> Kelvin = T.One;
        public static readonly Kilogram<T> Kilogram = T.One;
        //public static readonly KiloMetrePerHour<T> KiloMetrePerHour = T.One;
        //public static readonly Litre<T> Litre = T.One;
        //public static readonly Lumen<T> Lumen = T.One;
        //public static readonly Lux<T> Lux = T.One;
        public static readonly Metre<T> Metre = T.One;
        public static readonly MetrePerSecond<T> MetrePerSecond = T.One;
        public static readonly MetrePerSecondSquared<T> MetrePerSecondSquared = T.One;
        //public static readonly Minute<T> Minute = T.One;
        //public static readonly Mole<T> Mole = T.One;
        public static readonly Newton<T> Newton = T.One;
        //public static readonly Pascal<T> Pascal = T.One;
        //public static readonly Radian<T> Radian = T.One;
        public static readonly Second<T> Second = T.One;
        //public static readonly SquareMetre<T> SquareMetre = T.One;
        //public static readonly Steradian<T> Steradian = T.One;
        //public static readonly Volt<T> Volt = T.One;
        //public static readonly Watt<T> Watt = T.One;
        #endregion SI
    }
}
