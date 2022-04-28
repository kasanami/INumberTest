﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INumberTest
{
    public class Math<T> where T : INumber<T>
    {
        /// <summary>
        /// 指定された数値の平方根を返します。
        /// </summary>
        /// <param name="value">平方根を求める対象の数値。</param>
        /// <returns>戻り値 0 または正 d の正の平方根。</returns>
        public static T Sqrt(T value)
        {
            return Sqrt(value, 100, 100);
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
            var _2 = T.Create(2);
            for (int i = 0; i < count; i++)
            {
                temp = (temp * temp + value) / (_2 * temp);
                // 前回から値が変わっていないなら終了
                if (prev == temp)
                {
                    return temp;
                }
                prev = temp;
            }
            return temp;
        }
    }
}