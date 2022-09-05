using System.Numerics;

namespace INumberTest.Units.SI
{
    /// <summary>
    /// メートル
    /// <para>記号:m</para>
    /// <para>系  :国際単位系(SI)</para>
    /// <para>種類:基本単位</para>
    /// <para>量  :長さ</para>
    /// </summary>
    public class Metre<T> : Quantity<T>, ILength<T> where T : INumber<T>
    {
        #region プロパティ
        /// <summary>
        /// 名前
        /// </summary>
        public static string Name => "metre";
        /// <summary>
        /// 記号
        /// </summary>
        public static string Symbol => "m";
        /// <summary>
        /// 記号（override用）
        /// </summary>
        public override string _Symbol { get; } = Symbol;
        #endregion プロパティ

        #region コンストラクタ
        /// <summary>
        /// 0 で初期化
        /// </summary>
        public Metre() { }
        /// <summary>
        /// 指定した値で初期化
        /// </summary>
        public Metre(T value) : base(value) { }
        #endregion コンストラクタ

        #region 演算子
        /// <summary>
        /// 乗算
        /// </summary>
        public static Metre<T> operator *(T value, Metre<T> quantity)
        {
            return new Metre<T>(quantity.Value * value);
        }
        /// <summary>
        /// 乗算
        /// </summary>
        public static Metre<T> operator *(int value, Metre<T> quantity)
        {
            return T.CreateChecked(value) * quantity;
        }
        /// <summary>
        /// 乗算
        /// </summary>
        public static Metre<T> operator *(Metre<T> quantity, int value)
        {
            return quantity.Value * T.CreateChecked(value);
        }
        #endregion 演算子

        #region 型変換
        /// <summary>
        /// T型への明示的な変換を定義します。
        /// </summary>
        public static explicit operator T(Metre<T> quantity)
        {
            return quantity.Value;
        }
        /// <summary>
        /// T型への暗黙的な変換を定義します。
        /// </summary>
        public static implicit operator Metre<T>(T value)
        {
            return new Metre<T>(value);
        }
        #endregion 型変換
    }
}