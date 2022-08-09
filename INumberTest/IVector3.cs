using System.Numerics;

namespace INumberTest
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">要素の型</typeparam>
    public interface IVector3<T> :
        IAdditiveIdentity<Vector3<T>, Vector3<T>>,
        IMultiplicativeIdentity<Vector3<T>, Vector3<T>>,
        IUnaryPlusOperators<Vector3<T>, Vector3<T>>,
        IUnaryNegationOperators<Vector3<T>, Vector3<T>>,
        IAdditionOperators<Vector3<T>, Vector3<T>, Vector3<T>>,
        ISubtractionOperators<Vector3<T>, Vector3<T>, Vector3<T>>,
        IMultiplyOperators<Vector3<T>, T, Vector3<T>>,
        IDivisionOperators<Vector3<T>, T, Vector3<T>>,
        IModulusOperators<Vector3<T>, T, Vector3<T>>,
        IEquatable<Vector3<T>>,
        IEqualityOperators<Vector3<T>, Vector3<T>>
        where T : INumber<T>
    {
    }
}