using System.Numerics;

namespace INumberTest.Units
{
    /// <summary>
    /// 電流
    /// </summary>
    /// <typeparam name="T">数値型</typeparam>
    public interface IElectricCurrent<T> : IQuantity<T> where T : INumber<T>
    {
    }
}