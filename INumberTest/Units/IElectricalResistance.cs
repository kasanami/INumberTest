using System.Numerics;

namespace INumberTest.Units
{
    /// <summary>
    /// 電気抵抗
    /// </summary>
    /// <typeparam name="T">数値型</typeparam>
    public interface IElectricalResistance<T> : IQuantity<T> where T : INumber<T>
    {
    }
}