using System.Numerics;

namespace INumberTest.Units
{
    /// <summary>
    /// 周波数
    /// </summary>
    /// <typeparam name="T">数値型</typeparam>
    public interface IFrequency<T> : IQuantity<T> where T : INumber<T>
    {
    }
}