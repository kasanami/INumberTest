using System.Numerics;

namespace INumberTest.Units
{
    /// <summary>
    /// 仕事率
    /// </summary>
    /// <typeparam name="T">数値型</typeparam>
    public interface IPower<T> : IQuantity<T> where T : INumber<T>
    {
    }
}