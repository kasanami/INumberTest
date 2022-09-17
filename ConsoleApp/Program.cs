using INumberTest;
using INumberTest.Units;
using INumberTest.Units.NonSI;
using INumberTest.Units.SI;
using System.Numerics;
//using static INumberTest.Units.Symbol<double>;

namespace CibsoleApp
{
#pragma warning disable CA2252 // この API では、プレビュー機能をオプトインする必要があります
    public static class Program
    {
        static void Main()
        {
            Console.WriteLine("Units test");

            var m = Metre<double>.One * 123;

            {
                Console.WriteLine("T=double");
                Metre<double> oneMetre = 1;
                // 1キログラム
                Kilogram<double> oneKilogram = 1;
                Console.WriteLine($"{nameof(oneKilogram)}={oneKilogram}");

                // 相対性理論により質量はエネルギーに変換可能
                Joule<double> joule = (Joule<double>)oneKilogram;
                Console.WriteLine($"joule={joule}");

                // エネルギー割る距離は力
                Newton<double> newton = joule / oneMetre;
                Console.WriteLine($"newton={newton}");
            }

            {
                Console.WriteLine("T=decimal");
                Metre<decimal> oneMetre = 1;
                // 1キログラム
                Kilogram<decimal> oneKilogram = 1;
                Console.WriteLine($"{nameof(oneKilogram)}={oneKilogram}");

                // 相対性理論により質量はエネルギーに変換可能
                Joule<decimal> joule = (Joule<decimal>)oneKilogram;
                Console.WriteLine($"joule={joule}");

                // エネルギー割る距離は力
                Newton<decimal> newton = joule / oneMetre;
                Console.WriteLine($"newton={newton}");
            }

            Int128 int128 = 123;

            {
                var arcDegree = new ArcDegree<double>(45);
                var velocity = new MetrePerSecond<double>(123);
                var length = ParabolicMotionLength<double>(velocity, arcDegree);
                Console.WriteLine($"ParabolicMotionLength Test");
                Console.WriteLine($"arcDegree={arcDegree}");
                Console.WriteLine($"velocity={velocity}");
                Console.WriteLine($"length={length}");
            }

            {
                var arcDegree = new ArcDegree<float>(45);
                var velocity = new MetrePerSecond<float>(123);
                var length = ParabolicMotionLength<float>(velocity, arcDegree);
                Console.WriteLine($"ParabolicMotionLength Test");
                Console.WriteLine($"arcDegree={arcDegree}");
                Console.WriteLine($"velocity={velocity}");
                Console.WriteLine($"length={length}");
            }

            {
                var arcDegree = new ArcDegree<Half>((Half)45);
                var velocity = new MetrePerSecond<Half>((Half)123);
                var length = ParabolicMotionLength<Half>(velocity, arcDegree);
                Console.WriteLine($"ParabolicMotionLength Test");
                Console.WriteLine($"arcDegree={arcDegree}");
                Console.WriteLine($"velocity={velocity}");
                Console.WriteLine($"length={length}");
            }
        }
        /// <summary>
        /// 放物運動の距離を計算する。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="velocity">初速度</param>
        /// <param name="planeAngle">射出角度</param>
        /// <returns>距離</returns>
        static ILength<T> ParabolicMotionLength<T>(IVelocity<T> velocity, IPlaneAngle<T> planeAngle) where T : INumber<T>, ITrigonometricFunctions<T>
        {
            return ParabolicMotionLength(velocity.ToMetrePerSecond(), planeAngle.ToRadian());
        }
        /// <summary>
        /// 放物運動の距離を計算する。
        /// </summary>
        /// <typeparam name="T">数値型</typeparam>
        /// <param name="velocity">初速度</param>
        /// <param name="radian">射出角度</param>
        /// <returns>距離</returns>
        static Metre<T> ParabolicMotionLength<T>(MetrePerSecond<T> velocity, Radian<T> radian)
            where T : INumber<T>, ITrigonometricFunctions<T>
        {
            var _2 = T.CreateChecked(2);
            var velocity2 = velocity.Value * velocity.Value;
            T temp = velocity2 * T.Sin(radian.Value * _2);
            return new Metre<T>(temp / MetrePerSecondSquared<T>.G.Value);
        }
    }
#pragma warning restore CA2252 // この API では、プレビュー機能をオプトインする必要があります
}