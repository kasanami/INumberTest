using System.Numerics;

namespace INumberTest.Units
{
    /// <summary>
    /// 何らかの量を表す
    /// </summary>
    /// <typeparam name="T">値型</typeparam>
    public class Quantity<T> : IEquatable<Quantity<T>>, IQuantity<T> where T : INumber<T>
    {
        #region 
        public static T One { get; } = T.One;
        public static T Zero { get; } = T.Zero;
        #endregion

        #region プロパティ
        /// <summary>
        /// 値
        /// </summary>
        public T Value { get; set; } = T.Zero;
        /// <summary>
        /// 内部参照用
        /// </summary>
        public virtual string _Symbol { get; } = "";
        #endregion プロパティ
        #region コンストラクタ
        /// <summary>
        /// 0 で初期化
        /// </summary>
        public Quantity() { }
        /// <summary>
        /// 指定した値で初期化
        /// </summary>
        public Quantity(T value)
        {
            Value = value;
        }
        #endregion コンストラクタ
        #region object override
        /// <summary>
        /// 指定したオブジェクトが、現在のオブジェクトと等しいかどうかを判断します。
        /// </summary>
        /// <param name="obj">現在のオブジェクトと比較するオブジェクト。</param>
        /// <returns>指定したオブジェクトが現在のオブジェクトと等しい場合は true。それ以外の場合は false。</returns>
        public override bool Equals(object obj)
        {
            if (obj is Quantity<T>)
            {
                return Equals((Quantity<T>)obj);
            }
            return false;
        }
        /// <summary>
        /// 既定のハッシュ関数として機能します。
        /// </summary>
        /// <returns>現在のオブジェクトのハッシュ コード。</returns>
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
        /// <summary>
        /// 現在のオブジェクトを表す文字列を返します。
        /// </summary>
        /// <returns>現在のオブジェクトを表す文字列。</returns>
        public override string ToString()
        {
            return Value.ToString() + _Symbol;
        }
        #endregion object override
        #region IEquatable override
        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較するオブジェクト。</param>
        /// <returns>現在のオブジェクトが other パラメーターと等しい場合は true、それ以外の場合は false です。</returns>
        public bool Equals(Quantity<T> other)
        {
            return Value.Equals(other.Value);
        }
        #endregion IEquatable override
        #region 型変換
        /// <summary>
        /// T型への明示的な変換を定義します。
        /// </summary>
        public static explicit operator T(Quantity<T> quantity)
        {
            return quantity.Value;
        }
        /// <summary>
        /// 暗黙的な変換を定義します。
        /// </summary>
        public static implicit operator Quantity<T>(T value)
        {
            return new Quantity<T>(value);
        }
        #endregion 型変換
    }
}