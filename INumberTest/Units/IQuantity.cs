using System.Numerics;

namespace INumberTest.Units
{
    /// <summary>
    /// 何らかの量
    /// </summary>
    /// <typeparam name="T">数値型</typeparam>
    public interface IQuantity<T> where T : INumber<T>
    {
        #region プロパティ
        /// <summary>
        /// 名前
        /// </summary>
        static string Name { get; }
        /// <summary>
        /// 記号
        /// </summary>
        static string Symbol { get; }
        /// <summary>
        /// 量の種類
        /// </summary>
        static QuantityType Type { get; }
        /// <summary>
        /// 値
        /// </summary>
        T Value { get; set; }
        #endregion プロパティ
        static virtual IQuantity<T> From(T value) { return new Quantity<T>(value); }
    }
}