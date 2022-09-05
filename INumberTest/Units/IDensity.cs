using System.Numerics;

namespace INumberTest.Units
{
    /// <summary>
    /// 密度
    /// </summary>
    /// <typeparam name="T">数値型</typeparam>
    public interface IDensity<T> : IQuantity<T> where T : INumber<T>
    {
    }
}