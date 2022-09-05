using System.Numerics;

namespace INumberTest.Units
{
    /// <summary>
    /// 立体角
    /// </summary>
    /// <typeparam name="T">数値型</typeparam>
    public interface ISolidAngle<T> : IQuantity<T> where T : INumber<T>
    {
    }
}