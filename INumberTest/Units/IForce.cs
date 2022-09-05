using System.Numerics;

namespace INumberTest.Units
{
    /// <summary>
    /// 力 (物理学)
    /// </summary>
    /// <typeparam name="T">数値型</typeparam>
    public interface IForce<T> : IQuantity<T> where T : INumber<T>
    {
    }
}