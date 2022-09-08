using System.Numerics;

namespace INumberTest.Units
{
    /// <summary>
    /// 速度
    /// </summary>
    /// <typeparam name="T">数値型</typeparam>
    public interface IVelocity<T> : IQuantity<T> where T : INumber<T>
    {
        SI.MetrePerSecond<T> ToMetrePerSecond();
    }
}