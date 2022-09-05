using System.Numerics;

namespace INumberTest.Units
{
    /// <summary>
    /// 時間
    /// </summary>
    /// <typeparam name="T">数値型</typeparam>
    public interface IMass<T> : IQuantity<T> where T : INumber<T>
    {
    }
}