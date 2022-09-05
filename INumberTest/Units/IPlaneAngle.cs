using System.Numerics;

namespace INumberTest.Units
{
    /// <summary>
    /// 平面角
    /// </summary>
    /// <typeparam name="T">数値型</typeparam>
    public interface IPlaneAngle<T> : IQuantity<T> where T : INumber<T>
    {
    }
}