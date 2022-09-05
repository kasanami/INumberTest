using System.Numerics;

namespace INumberTest.Units.SI
{
    /// <summary>
    /// ニュートン
    /// <para>記号:N</para>
    /// <para>系  :国際単位系 (SI)</para>
    /// <para>種類:組立単位</para>
    /// <para>量  :力</para>
    /// <para>定義:1kgの質量を持つ物体に1m/s^2の加速度を生じさせる力</para>
    /// </summary>
    public class Newton<T> : Quantity<T>, IForce<T> where T : INumber<T>
    {
        #region プロパティ
        /// <summary>
        /// 名前
        /// </summary>
        public static string Name => "newton";
        /// <summary>
        /// 記号
        /// </summary>
        public static string Symbol => "N";
        /// <summary>
        /// 記号（override用）
        /// </summary>
        public override string _Symbol { get; } = Symbol;
        #endregion プロパティ

        #region コンストラクタ
        /// <summary>
        /// 0 で初期化
        /// </summary>
        public Newton() { }
        /// <summary>
        /// 指定した値で初期化
        /// </summary>
        public Newton(T value) : base(value) { }
        /// <summary>
        /// 質量と加速度から力を計算する
        /// </summary>
        public Newton(Kilogram<T> mass, MetrePerSecondSquared<T> acceleration)
        {
            Value = mass.Value * acceleration.Value;
        }
        #endregion コンストラクタ

        #region 演算子
        /// <summary>
        /// 力と距離からエネルギーを計算する
        /// </summary>
        public static Joule<T> operator *(Newton<T> force, Metre<T> length)
        {
            return new Joule<T>(force, length);
        }
        /// <summary>
        /// 乗算
        /// </summary>
        public static Newton<T> operator *(T value, Newton<T> quantity)
        {
            return new Newton<T>(quantity.Value * value);
        }
        #endregion 演算子

        #region 型変換
        /// <summary>
        /// T型への明示的な変換を定義します。
        /// </summary>
        public static explicit operator T(Newton<T> quantity)
        {
            return quantity.Value;
        }
        /// <summary>
        /// T型への暗黙的な変換を定義します。
        /// </summary>
        public static implicit operator Newton<T>(T value)
        {
            return new Newton<T>(value);
        }
        #endregion 型変換
    }
}