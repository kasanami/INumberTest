using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace INumberTest.Units.SI
{
    /// <summary>
    /// ジュール
    /// <para>記号:J</para>
    /// <para>系  :国際単位系 (SI)</para>
    /// <para>量  :エネルギー・仕事・熱量・電力量</para>
    /// <para>由来:1ニュートンの力がその力の方向に物体を1メートル動かすときの仕事</para>
    /// </summary>
    public class Joule<T> : Quantity<T> where T : INumber<T>
    {
        #region プロパティ
        /// <summary>
        /// 名前
        /// </summary>
        public static string Name => "joule";
        /// <summary>
        /// 記号
        /// </summary>
        public static string Symbol => "J";
        /// <summary>
        /// 記号（override用）
        /// </summary>
        public override string _Symbol { get; } = Symbol;
        #endregion プロパティ

        #region コンストラクタ
        /// <summary>
        /// 0 で初期化
        /// </summary>
        public Joule() { }
        /// <summary>
        /// 指定した値で初期化
        /// </summary>
        public Joule(T value) : base(value) { }
        /// <summary>
        /// 力と距離からエネルギーを計算する
        /// </summary>
        public Joule(Newton<T> force, Metre<T> length)
        {
            Value = force.Value * length.Value;
        }
        /// <summary>
        /// 質量と光速からエネルギーを計算する
        /// </summary>
        public Joule(Kilogram<T> mass)
        {
            Value = mass.Value * MetrePerSecond<T>.SpeedOfLight.Value * MetrePerSecond<T>.SpeedOfLight.Value;
        }
        #endregion コンストラクタ
        #region 演算子
        ///// <summary>
        ///// エネルギーと時間から仕事率を計算する
        ///// </summary>
        //public static Watt<T> operator /(Joule<T> energy, Second<T> time)
        //{
        //    return new Watt<T>(energy, time);
        //}
        /// <summary>
        /// 乗算
        /// </summary>
        public static Joule<T> operator *(T value, Joule<T> quantity)
        {
            return new Joule<T>(quantity.Value * value);
        }

        /// <summary>
        /// エネルギーと距離から力を計算する
        /// </summary>
        public static Newton<T> operator /(Joule<T> energy, Metre<T> length)
        {
            return new Newton<T>(energy.Value / length.Value);
        }
        /// <summary>
        /// エネルギーと力から距離を計算する
        /// </summary>
        public static Metre<T> operator /(Joule<T> energy, Newton<T> force)
        {
            return new Metre<T>(energy.Value / force.Value);
        }
        #endregion 演算子
        #region 型変換
        /// <summary>
        /// 他の型から、この型への明示的な変換を定義します。
        /// </summary>
        public static explicit operator Joule<T>(Kilogram<T> mass)
        {
            return new Joule<T>(mass);
        }
        /// <summary>
        /// T型への明示的な変換を定義します。
        /// </summary>
        public static explicit operator T(Joule<T> quantity)
        {
            return quantity.Value;
        }
        /// <summary>
        /// 暗黙的な変換を定義します。
        /// </summary>
        public static implicit operator Joule<T>(T value)
        {
            return new Joule<T>(value);
        }
        #endregion 型変換
    }
}