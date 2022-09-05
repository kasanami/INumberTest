using System.Numerics;

namespace INumberTest.Units
{
    /// <summary>
    /// 面積
    /// </summary>
    /// <typeparam name="T">数値型</typeparam>
    public interface IArea<T> : IQuantity<T> where T : INumber<T>
    {
    }
}