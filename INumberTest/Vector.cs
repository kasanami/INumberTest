using System.Numerics;
using System.Text;

namespace INumberTest
{
    /// <summary>
    /// N次元ベクトル
    /// </summary>
    public struct Vector<T> :
        IAdditiveIdentity<Vector<T>, Vector<T>>,
        IMultiplicativeIdentity<Vector<T>, Vector<T>>,
        IUnaryPlusOperators<Vector<T>, Vector<T>>,
        IUnaryNegationOperators<Vector<T>, Vector<T>>,
        IAdditionOperators<Vector<T>, Vector<T>, Vector<T>>,
        ISubtractionOperators<Vector<T>, Vector<T>, Vector<T>>,
        IMultiplyOperators<Vector<T>, T, Vector<T>>,
        IDivisionOperators<Vector<T>, T, Vector<T>>,
        IModulusOperators<Vector<T>, T, Vector<T>>,
        IEquatable<Vector<T>>,
        IEqualityOperators<Vector<T>, Vector<T>, bool>
        where T : INumber<T>
    {
        #region プロパティ
        public List<T> Values = new List<T>();
        /// <summary>
        /// 次元数
        /// </summary>
        public int Rank => Values.Count;
        /// <summary>
        /// 指定した要素を取得する
        /// </summary>
        public T this[int index]
        {
            get
            {
                return Values[index];
            }
            set
            {
                Values[index] = value;
            }
        }
        /// <summary>
        /// 大きさ
        /// </summary>
        public T Magnitude => Math<T>.Sqrt(SquaredMagnitude);
        /// <summary>
        /// 大きさを2乗した値
        /// </summary>
        public T SquaredMagnitude => Math<T>.Sum(Values.Select((item) => item * item));
        /// <summary>
        /// 正規化した値を返す。
        /// </summary>
        public Vector<T> Normalized => this / Magnitude;
        #endregion プロパティ

        #region コンストラクタ
        /// <summary>
        /// 次元数 0 で初期化
        /// </summary>
        public Vector()
        {
        }
        /// <summary>
        /// 3次元ベクトルとして、指定した値で初期化
        /// </summary>
        public Vector(T x, T y, T z)
        {
            Values.Add(x);
            Values.Add(y);
            Values.Add(z);
        }
        /// <summary>
        /// コピーコンストラクタ
        /// </summary>
        public Vector(IEnumerable<T> source)
        {
            Values = new List<T>(source.Count());
            Values.AddRange(source);
        }
        /// <summary>
        /// コピーコンストラクタ
        /// </summary>
        public Vector(Vector<T> source)
        {
            Values = new List<T>(source.Values);
        }
        /// <summary>
        /// コピーコンストラクタ
        /// </summary>
        public Vector(Vector2<T> source)
        {
            Values = new List<T>(Vector3<T>.Rank);
            Values.Add(source.X);
            Values.Add(source.Y);
        }
        /// <summary>
        /// コピーコンストラクタ
        /// </summary>
        public Vector(Vector3<T> source)
        {
            Values = new List<T>(Vector3<T>.Rank);
            Values.Add(source.X);
            Values.Add(source.Y);
            Values.Add(source.Z);
        }
        #endregion コンストラクタ

        #region 継承
        public static Vector<T> AdditiveIdentity =>
            new Vector<T>(T.AdditiveIdentity, T.AdditiveIdentity, T.AdditiveIdentity);
        public static Vector<T> MultiplicativeIdentity =>
            new Vector<T>(T.MultiplicativeIdentity, T.MultiplicativeIdentity, T.MultiplicativeIdentity);

        public static Vector<T> operator +(Vector<T> value) => value;

        public static Vector<T> operator +(Vector<T> left, Vector<T> right)
        {
            if (left.Rank > right.Rank)
            {
                var temp = new Vector<T>(left);
                for (int i = 0; i < right.Rank; i++)
                {
                    temp[i] += right[i];
                }
                return temp;
            }
            else
            {
                var temp = new Vector<T>(right);
                for (int i = 0; i < left.Rank; i++)
                {
                    temp[i] += left[i];
                }
                return temp;
            }
        }

        public static Vector<T> operator -(Vector<T> value)
        {
            var temp = new Vector<T>(value);
            for (int i = 0; i < temp.Values.Count; i++)
            {
                temp.Values[i] = -temp.Values[i];
            }
            return temp;
        }

        public static Vector<T> operator -(Vector<T> left, Vector<T> right)
        {
            var min = Math.Min(left.Rank, right.Rank);
            var max = Math.Max(left.Rank, right.Rank);
            var temp = new Vector<T>();
            for (int i = 0; i < min; i++)
            {
                temp.Values.Add(left[i] - right[i]);
            }
            if (left.Rank == max)
            {
                for (int i = min; i < max; i++)
                {
                    temp.Values.Add(left[i]);
                }
            }
            else
            {
                for (int i = min; i < max; i++)
                {
                    temp.Values.Add(T.Zero - right[i]);
                }
            }
            return temp;
        }

        public static Vector<T> operator *(Vector<T> left, T right)
        {
            var temp = new Vector<T>(left);
            for (int i = 0; i < temp.Rank; i++)
            {
                temp[i] *= right;
            }
            return temp;
        }

        public static Vector<T> operator /(Vector<T> left, T right)
        {
            var temp = new Vector<T>(left);
            for (int i = 0; i < temp.Rank; i++)
            {
                temp[i] /= right;
            }
            return temp;
        }

        public static Vector<T> operator %(Vector<T> left, T right)
        {
            var temp = new Vector<T>(left);
            for (int i = 0; i < temp.Rank; i++)
            {
                temp[i] %= right;
            }
            return temp;
        }

        public bool Equals(Vector<T> other)
        {
            if (Rank != other.Rank)
            {
                return false;
            }
            for (int i = 0; i < Rank; i++)
            {
                if (Values[i] != other[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool operator ==(Vector<T> left, Vector<T> right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Vector<T> left, Vector<T> right)
        {
            return !left.Equals(right);
        }

        public override string ToString()
        {
            var temp = new StringBuilder();
            temp.Append($"{nameof(Vector<T>)}");
            temp.Append("{");
            foreach (var value in Values)
            {
                temp.Append($"{value},");
            }
            temp.Append("}");
            return temp.ToString();
        }
#pragma warning disable CS8765 // パラメーターの型の NULL 値の許容が、オーバーライドされたメンバーと一致しません。おそらく、NULL 値の許容の属性が原因です。
        public override bool Equals(object obj)
        {
            return obj is Vector<T> && Equals((Vector<T>)obj);
        }
#pragma warning restore CS8765 // パラメーターの型の NULL 値の許容が、オーバーライドされたメンバーと一致しません。おそらく、NULL 値の許容の属性が原因です。

        public override int GetHashCode()
        {
            int temp = Rank.GetHashCode();
            foreach (var value in Values)
            {
                temp ^= value.GetHashCode();
            }
            return temp;
        }
        #endregion 継承

        /// <summary>
        /// このインスタンスを正規化する。
        /// </summary>
        public void Normalize()
        {
            this /= Magnitude;
        }
        /// <summary>
        /// 内積を計算します。
        /// </summary>
        public static T Dot(Vector<T> left, Vector<T> right)
        {
            var temp = new Vector<T>(left);
            for (int i = 0; i < right.Rank; i++)
            {
                temp[i] *= right[i];
            }
            return Math<T>.Sum(temp.Values);
        }
        /// <summary>
        /// 2次元としての外積を計算します。
        /// </summary>
        public static T Cross2(Vector<T> left, Vector<T> right)
        {
            return Vector2<T>.Cross((Vector2<T>)left, (Vector2<T>)right);
        }
        /// <summary>
        /// 3次元としての外積を計算します。
        /// </summary>
        public static Vector3<T> Cross3(Vector<T> left, Vector<T> right)
        {
            return Vector3<T>.Cross((Vector3<T>)left, (Vector3<T>)right);
        }

        #region 型変換
        public static implicit operator Vector<T>(Vector2<T> source)
        {
            return new Vector<T>(source);
        }
        public static implicit operator Vector<T>(Vector3<T> source)
        {
            return new Vector<T>(source);
        }
        public static explicit operator Vector2<T>(Vector<T> source)
        {
            var result = new Vector2<T>();
            result.X = source.Rank > 0 ? source[0] : T.Zero;
            result.Y = source.Rank > 1 ? source[1] : T.Zero;
            return result;
        }
        public static explicit operator Vector3<T>(Vector<T> source)
        {
            var result = new Vector3<T>();
            result.X = source.Rank > 0 ? source[0] : T.Zero;
            result.Y = source.Rank > 1 ? source[1] : T.Zero;
            result.Z = source.Rank > 2 ? source[2] : T.Zero;
            return result;
        }
        #endregion 型変換
    }
}