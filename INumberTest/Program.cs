
using INumberTest;

#pragma warning disable CS8321 // ローカル関数は宣言されていますが、一度も使用されていません

static void Test<T>() where T : IFloatingPoint<T>
{
    Console.WriteLine("Test");
    Console.WriteLine($"{typeof(T).Name}.Tau={T.Tau}");
}

Test<Half>();
Test<float>();
Test<double>();

MathTest();
//PowTest();
//MachinsFormulaTest();
//PointTest();
VectorTest();


static void MathTest()
{
    // Sqrt
    for (int i = 0; i < 1000; i++)
    {
        var sI = Math<int>.Sqrt(i);
        var sD = Math<double>.Sqrt(i);
        Console.WriteLine($"Sqrt({i})={sI} {sD}");
    }
    {
        var _1 = Math<int>.Sqrt(1);
        var _2 = Math<int>.Sqrt(4);
        var _3 = Math<int>.Sqrt(9);
        var _X = Math<int>.Sqrt(20);
        var _5 = Math<int>.Sqrt(25);
        var _10 = Math<int>.Sqrt(100);
    }
}


static T Sum<T>(IEnumerable<T> values) where T : INumber<T>
{
    T sum = T.Zero;
    foreach (var value in values)
    {
        sum += value;
    }
    return sum;
}

static void SumTest()
{
    var values = new double[] { 1, 2, 3, 4, 5 };
    var sum = Sum(values);
    Console.WriteLine(sum);
}

static T Pow<T>(T value, int exponent) where T : INumber<T>
{
    if (exponent == 0)
    {
        return T.One;
    }
    if (value == T.Zero)
    {
        return T.Zero;
    }
    if (exponent < 0)
    {
        var temp = Pow(value, -exponent);
        return T.One / temp;
    }
    else
    {
        var temp = T.One;
        for (int i = 0; i < exponent; i++)
        {
            temp *= value;
        }
        return temp;
    }
}

static void PowTest()
{
    var values = new double[] { 1, 2, 3, 4, 5 };
    foreach (var x in values)
    {
        for (int e = -10; e <= 10; e++)
        {
            var r = Pow(x,e);
            Console.WriteLine($"{x}^{e}={r}");
        }
    }
}



/// <summary>
/// マチンの公式
/// </summary>
/// <param name="count">計算回数。1未満を設定すると0を返す。</param>
/// <returns>PI/4(円周率の4分の1)</returns>
static T MachinsFormula<T>(int count) where T : INumber<T>
{
    var _4 = T.Create(4);
    var _5 = T.Create(5);
    var _239 = T.Create(239);

    T sum = T.Zero;
    for (int k = 1; k <= count; k++)
    {
        int odd = (2 * k - 1);// 奇数(int型)
        var _odd = T.Create(odd);// 奇数(T型)
        sum +=
            _4 *
            (Pow(-T.One, k + 1) / _odd) *
            Pow(T.One / _5, odd) +
            (Pow(-T.One, k) / _odd) *
            Pow(T.One / _239, odd);
    }
    return sum;
}

static void MachinsFormulaTest()
{
    Console.WriteLine($"MachinsFormulaTest()");
    Console.WriteLine($"float");
    {
        var pi = MachinsFormula<float>(17) * 4;
        Console.WriteLine($"{pi}");
    }
    Console.WriteLine($"double");
    {
        var pi = MachinsFormula<double>(17) * 4;
        Console.WriteLine($"{pi}");
    }
    Console.WriteLine($"decimal");
    {
        var pi = MachinsFormula<decimal>(20) * 4;
        Console.WriteLine($"{pi}");
    }
}


static void VectorTest()
{
    //IBinaryNumber
    //_VectorTest<int>();
    _VectorTest<Half>();
    _VectorTest<float>();
    _VectorTest<double>();
    //_VectorTest<decimal>();
}

static void _VectorTest<T>() where T:IFloatingPoint<T>
{
    Console.WriteLine($"_VectorTest <{typeof(T).Name}>");

    var vector = new Vector3<T>(T.One, T.One, T.One);
    var magnitude = vector.Magnitude;
    Console.WriteLine($"magnitude={magnitude}");
    var normalized = vector.Normalized;
    Console.WriteLine($"normalized={normalized}");
}

#pragma warning restore CS8321 // ローカル関数は宣言されていますが、一度も使用されていません
