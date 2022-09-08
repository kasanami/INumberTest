using System.Numerics;

namespace INumberTest.Units
{
    /// <summary>
    /// 長さ
    /// </summary>
    /// <typeparam name="T">数値型</typeparam>
    public interface ILength<T> : IQuantity<T> where T : INumber<T>
    {
        SI.Metre<T> ToMetre();
    }
}