using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INumberTest.Units.SI
{
    /// <summary>
    /// メートル毎秒
    /// </summary>
    public class MetrePerSecond<T> : Quantity<T> where T : INumber<T>
    {
        #region 定数
        /// <summary>
        /// 光速
        /// </summary>
        public static readonly MetrePerSecond<T> SpeedOfLight = new MetrePerSecond<T>(T.Create(299792458));
        #endregion 定数

        #region プロパティ
        /// <summary>
        /// 名前
        /// </summary>
        public static string Name => "metre per second";
        /// <summary>
        /// 記号
        /// </summary>
        public static string Symbol => "m/s";

        public override string _Symbol => Symbol;
        #endregion プロパティ

        #region コンストラクタ
        /// <summary>
        /// 0 で初期化
        /// </summary>
        public MetrePerSecond() { }
        /// <summary>
        /// 指定した値で初期化
        /// </summary>
        public MetrePerSecond(T value) : base(value) { }
        /// <summary>
        /// 距離と時間から速度を計算する
        /// </summary>
        public MetrePerSecond(Metre<T> length, Second<T> time)
        {
            Value = length.Value / time.Value;
        }
        #endregion コンストラクタ
        #region 演算子
        /// <summary>
        /// 速度と時間から加速度を計算する
        /// </summary>
        public static MetrePerSecondSquared<T> operator /(MetrePerSecond<T> velocity, Second<T> time)
        {
            return new MetrePerSecondSquared<T>(velocity, time);
        }
        /// <summary>
        /// 乗算
        /// </summary>
        public static MetrePerSecond<T> operator *(T value, MetrePerSecond<T> quantity)
        {
            return new MetrePerSecond<T>(value * quantity.Value);
        }
        #endregion 演算子

        #region 型変換
        /// <summary>
        /// T型への明示的な変換を定義します。
        /// </summary>
        public static explicit operator T(MetrePerSecond<T> quantity)
        {
            return quantity.Value;
        }
        /// <summary>
        /// 暗黙的な変換を定義します。
        /// </summary>
        public static implicit operator MetrePerSecond<T>(T value)
        {
            return new MetrePerSecond<T>(value);
        }
        #endregion 型変換
    }
}