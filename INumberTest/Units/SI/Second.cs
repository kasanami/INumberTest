using System.Numerics;

namespace INumberTest.Units.SI
{
    /// <summary>
    /// 秒
    /// <para>記号:s</para>
    /// <para>系  :国際単位系(SI)</para>
    /// <para>種類:基本単位</para>
    /// <para>量  :時間</para>
    /// </summary>
    public class Second<T> : Quantity<T>, ITime<T> where T : INumber<T>
    {
        #region プロパティ
        /// <summary>
        /// 名前
        /// </summary>
        public static string Name => "second";
        /// <summary>
        /// 記号
        /// </summary>
        public static string Symbol => "s";
        /// <summary>
        /// 記号（override用）
        /// </summary>
        public override string _Symbol { get; } = Symbol;
        #endregion プロパティ
        #region コンストラクタ
        /// <summary>
        /// 0 で初期化
        /// </summary>
        public Second()
        {
        }
        /// <summary>
        /// 指定した値で初期化
        /// </summary>
        public Second(T value) : base(value) { }
        #endregion コンストラクタ
        #region 演算子
        /// <summary>
        /// 乗算
        /// </summary>
        public static Second<T> operator *(T value, Second<T> quantity)
        {
            return new Second<T>(quantity.Value * value);
        }
        #endregion 演算子
        #region 型変換
        ///// <summary>
        ///// 他の型から、この型への暗黙的な変換を定義します。
        ///// </summary>
        //public static implicit operator Second<T>(Minute<T> time)
        //{
        //    return new Second<T>(time);
        //}
        ///// <summary>
        ///// 他の型から、この型への暗黙的な変換を定義します。
        ///// </summary>
        //public static implicit operator Second<T>(Hour<T> time)
        //{
        //    return new Second<T>(time);
        //}
        /// <summary>
        /// T型への明示的な変換を定義します。
        /// </summary>
        public static explicit operator T(Second<T> quantity)
        {
            return quantity.Value;
        }
        /// <summary>
        /// T型への暗黙的な変換を定義します。
        /// </summary>
        public static implicit operator Second<T>(T value)
        {
            return new Second<T>(value);
        }
        #endregion 型変換
    }
}