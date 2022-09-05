using System.Numerics;

namespace INumberTest.Units
{
    /// <summary>
    /// 圧力
    /// </summary>
    /// <typeparam name="T">数値型</typeparam>
    public interface IPressure<T> : IQuantity<T> where T : INumber<T>
    {
    }
}