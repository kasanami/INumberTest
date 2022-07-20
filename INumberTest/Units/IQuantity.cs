using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INumberTest.Units
{
    public interface IQuantity<T>
    {
        #region プロパティ
        /// <summary>
        /// 名前
        /// </summary>
        static string Name { get; }
        /// <summary>
        /// 記号
        /// </summary>
        static string Symbol { get; }
        /// <summary>
        /// 量の種類
        /// </summary>
        static QuantityType Type { get; }
        /// <summary>
        /// 値
        /// </summary>
        T Value { get; set; }
        #endregion プロパティ
    }
}