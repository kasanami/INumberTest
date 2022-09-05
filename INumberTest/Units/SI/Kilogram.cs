using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace INumberTest.Units.SI
{
    /// <summary>
    /// キログラム
    /// <para>記号:kg</para>
    /// <para>系  :国際単位系(SI)</para>
    /// <para>種類:基本単位</para>
    /// <para>量  :質量</para>
    /// </summary>
    public class Kilogram<T> : Quantity<T>, IMass<T> where T : INumber<T>
    {
        #region プロパティ
        /// <summary>
        /// 名前
        /// </summary>
        public static string Name => "kilogram";
        /// <summary>
        /// 記号
        /// </summary>
        public static string Symbol => "kg";
        /// <summary>
        /// 記号（override用）
        /// </summary>
        public override string _Symbol { get; } = Symbol;
        #endregion プロパティ

        #region コンストラクタ
        /// <summary>
        /// 0 で初期化
        /// </summary>
        public Kilogram()
        {
        }
        /// <summary>
        /// 指定した値で初期化
        /// </summary>
        public Kilogram(T value) : base(value) { }
        /// <summary>
        /// エネルギーと光速から質量を計算する
        /// </summary>
        public Kilogram(Joule<T> energy)
        {
            Value = energy.Value / (MetrePerSecond<T>.SpeedOfLight.Value * MetrePerSecond<T>.SpeedOfLight.Value);
        }
        #endregion コンストラクタ
        #region 演算子
        /// <summary>
        /// 質量と加速度から力を計算する
        /// </summary>
        public static Newton<T> operator *(Kilogram<T> mass, MetrePerSecondSquared<T> acceleration)
        {
            return new Newton<T>(mass, acceleration);
        }
        /// <summary>
        /// 乗算
        /// </summary>
        public static Kilogram<T> operator *(T value, Kilogram<T> quantity)
        {
            return new Kilogram<T>(quantity.Value * value);
        }
        #endregion 演算子
        #region 型変換
        /// <summary>
        /// 他の型から、この型への明示的な変換を定義します。
        /// </summary>
        public static explicit operator Kilogram<T>(Joule<T> mass)
        {
            return new Kilogram<T>(mass);
        }
        /// <summary>
        /// T型への明示的な変換を定義します。
        /// </summary>
        public static explicit operator T(Kilogram<T> quantity)
        {
            return quantity.Value;
        }
        /// <summary>
        /// 暗黙的な変換を定義します。
        /// </summary>
        public static implicit operator Kilogram<T>(T value)
        {
            return new Kilogram<T>(value);
        }
        #endregion 型変換
    }
}