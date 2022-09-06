using System.Numerics;

namespace INumberTest
{
    /// <summary>
    /// 2次元ベクトル
    /// </summary>
    public struct Vector2<T> :
        IAdditiveIdentity<Vector2<T>, Vector2<T>>,
        IMultiplicativeIdentity<Vector2<T>, Vector2<T>>,
        IUnaryPlusOperators<Vector2<T>, Vector2<T>>,
        IUnaryNegationOperators<Vector2<T>, Vector2<T>>,
        IAdditionOperators<Vector2<T>, Vector2<T>, Vector2<T>>,
        ISubtractionOperators<Vector2<T>, Vector2<T>, Vector2<T>>,
        IMultiplyOperators<Vector2<T>, T, Vector2<T>>,
        IDivisionOperators<Vector2<T>, T, Vector2<T>>,
        IModulusOperators<Vector2<T>, T, Vector2<T>>,
        IEquatable<Vector2<T>>,
        IEqualityOperators<Vector2<T>, Vector2<T>, bool>
        where T : INumber<T>
    {
        /// <summary>
        /// 次元数
        /// </summary>
        public const int Rank = 2;

        #region プロパティ
        public T X { get; set; }
        public T Y { get; set; }
        /// <summary>
        /// 大きさ
        /// </summary>
        public T Magnitude => Math<T>.Sqrt(SquaredMagnitude);
        /// <summary>
        /// 大きさを2乗した値
        /// </summary>
        public T SquaredMagnitude => X * X + Y * Y;
        /// <summary>
        /// 正規化した値を返す。
        /// </summary>
        public Vector2<T> Normalized => this / Magnitude;
        #endregion プロパティ

        #region コンストラクタ
        /// <summary>
        /// 各要素を 0 で初期化
        /// </summary>
        public Vector2()
        {
            X = T.Zero;
            Y = T.Zero;
        }
        /// <summary>
        /// 各要素を指定した値で初期化
        /// </summary>
        public Vector2(T x, T y)
        {
            X = x;
            Y = y;
        }
        #endregion コンストラクタ

        #region 継承
        public static Vector2<T> AdditiveIdentity =>
            new Vector2<T>(T.AdditiveIdentity, T.AdditiveIdentity);
        public static Vector2<T> MultiplicativeIdentity =>
            new Vector2<T>(T.MultiplicativeIdentity, T.MultiplicativeIdentity);

        public static Vector2<T> operator +(Vector2<T> value) => value;

        public static Vector2<T> operator +(Vector2<T> left, Vector2<T> right) =>
            left with
            {
                X = left.X + right.X,
                Y = left.Y + right.Y
            };

        public static Vector2<T> operator -(Vector2<T> value) =>
            value with
            {
                X = -value.X,
                Y = -value.Y
            };

        public static Vector2<T> operator -(Vector2<T> left, Vector2<T> right) =>
            left with
            {
                X = left.X - right.X,
                Y = left.Y - right.Y
            };

        public static Vector2<T> operator *(Vector2<T> left, T right) =>
            left with
            {
                X = left.X * right,
                Y = left.Y * right
            };

        public static Vector2<T> operator /(Vector2<T> left, T right) =>
            left with
            {
                X = left.X / right,
                Y = left.Y / right
            };

        public static Vector2<T> operator %(Vector2<T> left, T right) =>
            left with
            {
                X = left.X % right,
                Y = left.Y % right
            };

        public bool Equals(Vector2<T> other)
        {
            if (other.X != X)
            {
                return false;
            }
            if (other.Y != Y)
            {
                return false;
            }
            return true;
        }

        public static bool operator ==(Vector2<T> left, Vector2<T> right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Vector2<T> left, Vector2<T> right)
        {
            return !left.Equals(right);
        }

        public override string ToString()
        {
            return $"{nameof(Vector2<T>)}{{X={X},Y={Y}}}";
        }
#pragma warning disable CS8765 // パラメーターの型の NULL 値の許容が、オーバーライドされたメンバーと一致しません。おそらく、NULL 値の許容の属性が原因です。
        public override bool Equals(object obj)
        {
            return obj is Vector2<T> && Equals((Vector2<T>)obj);
        }
#pragma warning restore CS8765 // パラメーターの型の NULL 値の許容が、オーバーライドされたメンバーと一致しません。おそらく、NULL 値の許容の属性が原因です。

        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }
        #endregion 継承

        /// <summary>
        /// このインスタンスを正規化する。
        /// </summary>
        public void Normalize()
        {
            var magnitude = Magnitude;
            X /= magnitude;
            Y /= magnitude;
        }
        /// <summary>
        /// 内積を計算します。
        /// </summary>
        public static T Dot(Vector2<T> left, Vector2<T> right)
        {
            return left.X * right.X + left.Y * right.Y;
        }
        /// <summary>
        /// 外積を計算します。
        /// </summary>
        public static T Cross(Vector2<T> left, Vector2<T> right)
        {
            return left.X * right.Y - left.Y * right.X;
        }
    }
}