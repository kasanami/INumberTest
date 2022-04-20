// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

double[] values = new double[5] { 1, 2, 3, 4, 5 };
var sum = Sum(values);
Console.WriteLine(sum);

static T Sum<T>(IEnumerable<T> values) where T : INumber<T>
{
    T sum = T.Zero;
    foreach (var value in values)
    {
        sum += value;
    }
    return sum;
}
