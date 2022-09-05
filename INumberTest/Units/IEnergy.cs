using System.Numerics;

namespace INumberTest.Units
{
    /// <summary>
    /// エネルギー
    /// </summary>
    /// <typeparam name="T">数値型</typeparam>
    public interface IEnergy<T> : IQuantity<T> where T : INumber<T>
    {
    }
}