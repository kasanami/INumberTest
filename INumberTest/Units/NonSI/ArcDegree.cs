using INumberTest.Units.SI;
using System.Numerics;

namespace INumberTest.Units.NonSI
{
    /// <summary>
    /// 度
    /// <para>記号:rad</para>
    /// <para>系  :非SI単位、SI併用単位</para>
    /// <para>量  :平面角</para>
    /// <para>由来:円周を360等分した弧の中心に対する角度</para>
    /// </summary>
    public class ArcDegree<T> : Quantity<T>, IPlaneAngle<T> where T : INumber<T>, IFloatingPointConstants<T>
    {
        #region 定数
        private static readonly T T180 = T.CreateChecked(180);
        private static readonly T T360 = T.CreateChecked(360);
        public static readonly ArcDegree<T> ArcDegree180 = new ArcDegree<T>(T180);
        public static readonly ArcDegree<T> ArcDegree360 = new ArcDegree<T>(T360);
        #endregion 定数

        #region プロパティ
        /// <summary>
        /// 名前
        /// </summary>
        public static string Name => "degree";
        /// <summary>
        /// 記号
        /// </summary>
        public static string Symbol => "°";
        /// <summary>
        /// 記号（override用）
        /// </summary>
        public override string _Symbol { get; } = Symbol;
        #endregion プロパティ
        #region コンストラクタ
        /// <summary>
        /// 0 で初期化
        /// </summary>
        public ArcDegree() { }
        /// <summary>
        /// 指定した値で初期化
        /// </summary>
        public ArcDegree(T value) : base(value) { }
        #endregion コンストラクタ


        #region 型変換
        /// <summary>
        /// T型への明示的な変換を定義します。
        /// </summary>
        public static explicit operator T(ArcDegree<T> quantity)
        {
            return quantity.Value;
        }
        /// <summary>
        /// T型への暗黙的な変換を定義します。
        /// </summary>
        public static implicit operator ArcDegree<T>(T value)
        {
            return new ArcDegree<T>(value);
        }

        /// <summary>
        /// Radianへの暗黙的な変換を定義します。
        /// </summary>
        public static implicit operator Radian<T>(ArcDegree<T> quantity)
        {
            return quantity.ToRadian();
        }

        public Radian<T> ToRadian()
        {
            var radian = T.Pi * Value / T180;
            return new(radian);
        }
        #endregion 型変換
    }
}