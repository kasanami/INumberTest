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
    public struct Vector3<T>:
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
        where T : INumber<T>
    {
        #region プロパティ
        public T X { get; private set; }
        public T Y { get; private set; }
        public T Z { get; private set; }
        /// <summary>
        /// 大きさ
        /// </summary>
        public T Magnitude => Math<T>.Sqrt(SquaredMagnitude);
        /// <summary>
        /// 大きさの2乗した値
        /// </summary>
        public T SquaredMagnitude => X * X + Y * Y + Z * Z;
        /// <summary>
        /// 正規化した値を返す。
        /// </summary>
        public Vector3<T> Normalized => this / Magnitude;
        #endregion プロパティ

        #region コンストラクタ
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

        #endregion 継承

        /// <summary>
        /// このインスタンスを正規化する。
        /// </summary>
        /// <returns>このインスタンス</returns>
        public Vector3<T> Normalize()
        {
            var magnitude = Magnitude;
            X /= magnitude;
            Y /= magnitude;
            Z /= magnitude;
            return this;
        }
    }
}