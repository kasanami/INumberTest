using System.Numerics;

namespace INumberTest.Units.SI
{
    /// <summary>
    /// ラジアン
    /// <para>記号:rad</para>
    /// <para>系  :国際単位系 (SI)</para>
    /// <para>量  :平面角</para>
    /// <para>由来:円の半径に等しい長さの弧の中心に対する角度</para>
    /// </summary>
    public class Radian<T> : Quantity<T>, IPlaneAngle<T> where T : INumber<T>
    {
        #region プロパティ
        /// <summary>
        /// 名前
        /// </summary>
        public static string Name => "radian";
        /// <summary>
        /// 記号
        /// </summary>
        public static string Symbol => "rad";
        /// <summary>
        /// 記号（override用）
        /// </summary>
        public override string _Symbol { get; } = Symbol;
        #endregion プロパティ
        #region コンストラクタ
        /// <summary>
        /// 0 で初期化
        /// </summary>
        public Radian() { }
        /// <summary>
        /// 指定した値で初期化
        /// </summary>
        public Radian(T value) : base(value) { }
        #endregion コンストラクタ
    }
}