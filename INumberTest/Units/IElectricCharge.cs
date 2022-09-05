using System.Numerics;

namespace INumberTest.Units
{
    /// <summary>
    /// 電荷
    /// </summary>
    /// <typeparam name="T">数値型</typeparam>
    public interface IElectricCharge<T> : IQuantity<T> where T : INumber<T>
    {
    }
}