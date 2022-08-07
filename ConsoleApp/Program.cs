using INumberTest.Units;
using INumberTest.Units.SI;
//using static INumberTest.Units.Symbol<double>;
using static INumberTest.Units.Constants<double>;

namespace CibsoleApp
{
    public static class Program
    {
        static void Main()
        {
            Console.WriteLine("hogehoge");

            Metre<double> oneMetre = 1;

            var m = Metre * 123;

            Kilogram<double> oneKilogram = 1;
            Console.WriteLine($"{nameof(oneKilogram)}={oneKilogram}");

            // 相対性理論により可換
            Joule<double> joule = (Joule<double>)oneKilogram;
            Console.WriteLine($"joule={joule}");

            // 
            Newton<double> newton = joule / oneMetre;
            Console.WriteLine($"newton={newton}");

            Int128 int128 = 123;
        }
    }
}