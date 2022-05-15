using Microsoft.VisualStudio.TestTools.UnitTesting;
using INumberTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INumberTest.Tests
{
#pragma warning disable CA2252 // この API では、プレビュー機能をオプトインする必要があります
    [TestClass()]
    public class Vector2Tests
    {
        const double Delta = 0.000000000000001;
        [TestMethod()]
        public void MagnitudeTest()
        {
            var vector = new Vector2<double>(1, 1);
            Assert.AreEqual(1.4142135623730950, vector.Magnitude, Delta);
        }

        [TestMethod()]
        public void SquaredMagnitudeTest()
        {
            var vector = new Vector2<double>(1, 1);
            Assert.AreEqual(2, vector.SquaredMagnitude);

            vector = new Vector2<double>(2, 2);
            Assert.AreEqual(8, vector.SquaredMagnitude);
        }

        [TestMethod()]
        public void NormalizedTest()
        {
            var vector = new Vector2<double>(1, 1);
            vector.Normalize();
            Assert.AreEqual(0.70710678118654752, vector.X, Delta);
            Assert.AreEqual(0.70710678118654752, vector.Y, Delta);
        }

        [TestMethod()]
        public void EqualsTest()
        {
            var vector1 = new Vector2<double>(1, 1);
            var vector2 = new Vector2<double>(1, 1);
            var vector3 = new Vector2<double>(1, 2);
            Assert.IsTrue(vector1.Equals(vector2));
            Assert.IsFalse(vector1.Equals(vector3));
        }

        [TestMethod()]
        public void GetHashCodeTest()
        {
            var vector1 = new Vector2<double>(1, 1);
            var vector2 = new Vector2<double>(1, 1);
            var vector3 = new Vector2<double>(1, 2);
            Assert.IsTrue(vector1.GetHashCode() == vector2.GetHashCode());
            Assert.IsTrue(vector1.GetHashCode() != vector3.GetHashCode());
        }

        [TestMethod()]
        public void DotTest()
        {
            {
                var vector1 = new Vector2<double>(1, 1);
                var vector2 = new Vector2<double>(1, 1);
                Assert.AreEqual(2.0, Vector2<double>.Dot(vector1, vector2));
            }

            {
                var vector1 = new Vector2<double>(1, 1);
                var vector2 = new Vector2<double>(-1, -1);
                Assert.AreEqual(-2.0, Vector2<double>.Dot(vector1, vector2));
            }
        }

        [TestMethod()]
        public void CrossTest()
        {
            {
                var vector1 = new Vector2<double>(1, 0);
                var vector2 = new Vector2<double>(0, 1);
                var vector3 = new Vector2<double>(0, -1);

                Assert.AreEqual(1, Vector2<double>.Cross(vector1, vector2));
                Assert.AreEqual(-1, Vector2<double>.Cross(vector1, vector3));
            }
        }
    }
#pragma warning restore CA2252 // この API では、プレビュー機能をオプトインする必要があります
}