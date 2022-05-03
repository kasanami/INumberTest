using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INumberTest
{
    /// <summary>
    /// ベクトル
    /// </summary>
    public struct Vector3<T> :
        IAdditiveIdentity<Vector3<T>, Vector3<T>>,
        IMultiplicativeIdentity<Vector3<T>, Vector3<T>>,
        IUnaryPlusOperators<Vector3<T>, Vector3<T>>,
        IUnaryNegationOperators<Vector3<T>, Vector3<T>>,
        IAdditionOperators<Vector3<T>, Vector3<T>, Vector3<T>>,
        ISubtractionOperators<Vector3<T>, Vector3<T>, Vector3<T>>,
        IMultiplyOperators<Vector3<T>, T, Vector3<T>>,
        IDivisionOperators<Vector3<T>, T, Vector3<T>>,
        IModulusOperators<Vector3<T>, T, Vector3<T>>,
        IEquatable<Vector3<T>>,
        IEqualityOperators<Vector3<T>, Vector3<T>>
        where T : IFloatingPoint<T>
        //where T : INumber<T>
    {
        #region プロパティ
        public T X { get; set; }
        public T Y { get; set; }
        public T Z { get; set; }
        /// <summary>
        /// 大きさ
        /// </summary>
        public T Magnitude => T.Sqrt(SquaredMagnitude);
        /// <summary>
        /// 大きさを2乗した値
        /// </summary>
        public T SquaredMagnitude => X * X + Y * Y + Z * Z;
        /// <summary>
        /// 正規化した値を返す。
        /// </summary>
        public Vector3<T> Normalized => this / Magnitude;
        #endregion プロパティ

        #region コンストラクタ
        /// <summary>
        /// 各要素を 0 で初期化
        /// </summary>
        public Vector3()
        {
            X = T.Zero;
            Y = T.Zero;
            Z = T.Zero;
        }
        /// <summary>
        /// 各要素を指定した値で初期化
        /// </summary>
        public Vector3(T x, T y, T z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        #endregion コンストラクタ

        #region 継承
        public static Vector3<T> AdditiveIdentity =>
            new Vector3<T>(T.AdditiveIdentity, T.AdditiveIdentity, T.AdditiveIdentity);
        public static Vector3<T> MultiplicativeIdentity =>
            new Vector3<T>(T.MultiplicativeIdentity, T.MultiplicativeIdentity, T.MultiplicativeIdentity);

        public static Vector3<T> operator +(Vector3<T> value) => value;

        public static Vector3<T> operator +(Vector3<T> left, Vector3<T> right) =>
            left with
            {
                X = left.X + right.X,
                Y = left.Y + right.Y,
                Z = left.Z + right.Z
            };

        public static Vector3<T> operator -(Vector3<T> value) =>
            value with
            {
                X = -value.X,
                Y = -value.Y,
                Z = -value.Z
            };

        public static Vector3<T> operator -(Vector3<T> left, Vector3<T> right) =>
            left with
            {
                X = left.X - right.X,
                Y = left.Y - right.Y,
                Z = left.Z - right.Z
            };

        public static Vector3<T> operator *(Vector3<T> left, T right) =>
            left with
            {
                X = left.X * right,
                Y = left.Y * right,
                Z = left.Z * right
            };

        public static Vector3<T> operator /(Vector3<T> left, T right) =>
            left with
            {
                X = left.X / right,
                Y = left.Y / right,
                Z = left.Z / right
            };

        public static Vector3<T> operator %(Vector3<T> left, T right) =>
            left with
            {
                X = left.X % right,
                Y = left.Y % right,
                Z = left.Z % right
            };

        public bool Equals(Vector3<T> other)
        {
            if (other.X != X)
            {
                return false;
            }
            if (other.Y != Y)
            {
                return false;
            }
            if (other.Z != Z)
            {
                return false;
            }
            return true;
        }

        public static bool operator ==(Vector3<T> left, Vector3<T> right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Vector3<T> left, Vector3<T> right)
        {
            return !left.Equals(right);
        }

        public override string ToString()
        {
            return $"{nameof(Vector3<T>)}{{ X={X},Y={Y},Z={Z} }}";
        }
#pragma warning disable CS8765 // パラメーターの型の NULL 値の許容が、オーバーライドされたメンバーと一致しません。おそらく、NULL 値の許容の属性が原因です。
        public override bool Equals(object obj)
        {
            return obj is Vector3<T> && Equals((Vector3<T>)obj);
        }
#pragma warning restore CS8765 // パラメーターの型の NULL 値の許容が、オーバーライドされたメンバーと一致しません。おそらく、NULL 値の許容の属性が原因です。

        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
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
            Z /= magnitude;
        }
        /// <summary>
        /// 内積を計算します。
        /// </summary>
        public static T Dot(Vector3<T> left, Vector3<T> right)
        {
            return left.X * right.X + left.Y * right.Y + left.Z * right.Z;
        }
        /// <summary>
        /// 外積を計算します。
        /// </summary>
        public static Vector3<T> Cross(Vector3<T> left, Vector3<T> right)
        {
            var x = left.Y * right.Z - left.Z * right.Y;
            var y = left.Z * right.X - left.X * right.Z;
            var z = left.X * right.Y - left.Y * right.X;
            return new Vector3<T>(x, y, z);
        }
    }
}