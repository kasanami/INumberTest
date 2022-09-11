using System.Numerics;

namespace INumberTest.Units.SI
{
    /// <summary>
    /// メートル毎秒毎秒
    /// <para>記号:m/s^2</para>
    /// <para>種類:組立単位</para>
    /// <para>量  :加速度</para>
    /// <para>定義:1秒間に 1 m/s の加速度</para>
    /// </summary>
    public class MetrePerSecondSquared<T> : Quantity<T>, IAcceleration<T> where T : INumber<T>
    {
        #region 定数
        /// <summary>
        /// 地球の重力加速度
        /// </summary>
        public static readonly MetrePerSecondSquared<T> GravitationalAcceleration = new(T.CreateChecked(9.80665m));
        /// <summary>
        /// 地球の重力加速度
        /// </summary>
        public static readonly MetrePerSecondSquared<T> G = GravitationalAcceleration;
        #endregion 定数

        #region プロパティ
        /// <summary>
        /// 名前
        /// </summary>
        public static string Name => "metre per second squared";
        /// <summary>
        /// 記号
        /// </summary>
        public static string Symbol => "m/s^2";
        /// <summary>
        /// 記号（override用）
        /// </summary>
        public override string _Symbol { get; } = Symbol;
        #endregion プロパティ
        #region コンストラクタ
        /// <summary>
        /// 0 で初期化
        /// </summary>
        public MetrePerSecondSquared() { }
        /// <summary>
        /// 指定した値で初期化
        /// </summary>
        public MetrePerSecondSquared(T value) : base(value) { }
        /// <summary>
        /// 速度と時間から加速度を計算する
        /// </summary>
        public MetrePerSecondSquared(MetrePerSecond<T> velocity, Second<T> time)
        {
            Value = velocity.Value / time.Value;
        }
        #endregion コンストラクタ
        #region 演算子
        /// <summary>
        /// 加速度と時間から速度を計算する
        /// </summary>
        public static MetrePerSecond<T> operator *(MetrePerSecondSquared<T> acceleration, Second<T> time)
        {
            return new MetrePerSecond<T>(acceleration.Value * time.Value);
        }
        /// <summary>
        /// 乗算
        /// </summary>
        public static MetrePerSecondSquared<T> operator *(T value, MetrePerSecondSquared<T> quantity)
        {
            return new MetrePerSecondSquared<T>(quantity.Value * value);
        }
        #endregion 演算子

        #region 型変換
        /// <summary>
        /// T型への明示的な変換を定義します。
        /// </summary>
        public static explicit operator T(MetrePerSecondSquared<T> quantity)
        {
            return quantity.Value;
        }
        /// <summary>
        /// 暗黙的な変換を定義します。
        /// </summary>
        public static implicit operator MetrePerSecondSquared<T>(T value)
        {
            return new MetrePerSecondSquared<T>(value);
        }

        public MetrePerSecondSquared<T> ToMetrePerSecondSquared()
        {
            return this;
        }
        #endregion 型変換
    }
}