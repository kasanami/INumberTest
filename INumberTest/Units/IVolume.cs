using System.Numerics;

namespace INumberTest.Units
{
    /// <summary>
    /// 体積
    /// </summary>
    /// <typeparam name="T">数値型</typeparam>
    public interface IVolume<T> : IQuantity<T> where T : INumber<T>
    {
    }
}