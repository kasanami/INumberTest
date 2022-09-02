using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INumberTest.Units
{
    /// <summary>
    /// 量の種類
    /// </summary>
    public enum QuantityType
    {
        /// <summary>
        /// 不明
        /// </summary>
        Unknown = -1,
        /// <summary>
        /// その他
        /// </summary>
        Other,
        /// <summary>
        /// 加速度
        /// </summary
        Acceleration,
        /// <summary>
        /// 物質量
        /// </summary>
        AmountOfSubstance,
        /// <summary>
        /// 面積
        /// </summary
        Area,
        /// <summary>
        /// 質量
        /// </summary>
        Mass,
    }
}