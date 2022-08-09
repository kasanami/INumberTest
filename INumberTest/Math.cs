using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace INumberTest
{
    public class Math<T> where T : INumber<T>
    {
        #region　Is*
        /// <summary>
        /// 奇数ならばtrueを返す。
        /// </summary>
        public static bool IsOdd(T value)
        {
            return value % T.CreateChecked(2) != T.Zero;
        }
        /// <summary>
        /// 偶数ならばtrueを返す。
        /// </summary>
        public static bool IsEven(T value)
        {
            return value % T.CreateChecked(2) == T.Zero;
        }
        /// <summary>
        /// 負数ならばtrueを返す。
        /// </summary>
        public bool IsNegative(T value)
        {
            return value < T.Zero;
        }
        /// <summary>
        /// 正数ならばtrueを返す。
        /// </summary>
        public bool IsPositive(T value)
        {
            return value > T.Zero;
        }
        /// <summary>
        /// ゼロならばtrueを返す。
        /// </summary>
        public bool IsZero(T value)
        {
            return value == T.Zero;
        }
        #endregion　Is*

        /// <summary>
        /// 合計を計算する
        /// </summary>
        /// <param name="values">合計する値</param>
        /// <returns>合計値</returns>
        public static T Sum(IEnumerable<T> values)
        {
            T sum = T.AdditiveIdentity;
            foreach (var value in values)
            {
                sum += value;
            }
            return sum;
        }
        /// <summary>
        /// 指定された数値の平方根を返します。
        /// </summary>
        /// <param name="value">平方根を求める対象の数値。</param>
        /// <returns>戻り値 0 または正 d の正の平方根。</returns>
        public static T Sqrt(T value)
        {
            return Sqrt(value, 100, int.MaxValue);
        }
        /// <summary>
        /// 指定された数値の平方根を返します。
        /// </summary>
        /// <param name="value">平方根を求める対象の数値。</param>
        /// <param name="precision">精度（小数点以下の桁数）</param>
        /// <param name="count">計算回数</param>
        /// <returns>戻り値 0 または正 d の正の平方根。</returns>
        private static T Sqrt(T value, int precision, int count)
        {
            if (value == T.Zero)
            {
                return T.Zero;
            }
            var temp = value;
            var prev = value;
            var prev2 = value;
            var _2 = T.CreateChecked(2);
            for (int i = 0; i < count; i++)
            {
                temp = (temp * temp + value) / (_2 * temp);
                // 前回から値が変わっていないなら終了
                if (prev == temp || prev2 == temp)
                {
                    return temp;
                }
                prev2 = prev;
                prev = temp;
            }
            return temp;
        }
    }
}