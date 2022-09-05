using System.Numerics;

namespace INumberTest.Units
{
    /// <summary>
    /// 加速度
    /// </summary>
    /// <typeparam name="T">数値型</typeparam>
    public interface IAcceleration<T> : IQuantity<T> where T : INumber<T>
    {
    }
}