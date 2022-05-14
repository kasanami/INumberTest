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
    public class VectorTests
    {
        const double Delta = 0.000000000000001;
        [TestMethod()]
        public void MagnitudeTest()
        {
            var vector = new Vector<double>(1, 1, 1);
            Assert.AreEqual(1.7320508075688774, vector.Magnitude, Delta);
        }

        [TestMethod()]
        public void SquaredMagnitudeTest()
        {
            var vector = new Vector<double>(1, 1, 1);
            Assert.AreEqual(3, vector.SquaredMagnitude);

            vector = new Vector<double>(2, 2, 2);
            Assert.AreEqual(12, vector.SquaredMagnitude);
        }

        [TestMethod()]
        public void NormalizedTest()
        {
            var vector = new Vector<double>(1, 1, 1);
            vector.Normalize();
            Assert.AreEqual(0.57735026918962573, vector[0], Delta);
            Assert.AreEqual(0.57735026918962573, vector[1], Delta);
            Assert.AreEqual(0.57735026918962573, vector[2], Delta);
        }

        [TestMethod()]
        public void EqualsTest()
        {
            var vector1 = new Vector<double>(1, 1, 1);
            var vector2 = new Vector<double>(1, 1, 1);
            var vector3 = new Vector<double>(1, 1, 2);
            Assert.IsTrue(vector1.Equals(vector2));
            Assert.IsFalse(vector1.Equals(vector3));
        }

        [TestMethod()]
        public void GetHashCodeTest()
        {
            var vector1 = new Vector<double>(1, 1, 1);
            var vector2 = new Vector<double>(1, 1, 1);
            var vector3 = new Vector<double>(1, 1, 2);
            Assert.IsTrue(vector1.GetHashCode() == vector2.GetHashCode());
            Assert.IsTrue(vector1.GetHashCode() != vector3.GetHashCode());
        }

        [TestMethod()]
        public void DotTest()
        {
            {
                var vector1 = new Vector<double>(1, 1, 1);
                var vector2 = new Vector<double>(1, 1, 1);
                Assert.AreEqual(3.0, Vector<double>.Dot(vector1, vector2));
            }

            {
                var vector1 = new Vector<double>(1, 1, 1);
                var vector2 = new Vector<double>(-1, -1, -1);
                Assert.AreEqual(-3.0, Vector<double>.Dot(vector1, vector2));
            }
        }

        [TestMethod()]
        public void CrossTest()
        {
            {
                var vector1 = new Vector<double>(1, 0, 0);
                var vector2 = new Vector<double>(0, 1, 0);
                var vector3 = new Vector<double>(0, 0, 1);
                Assert.AreEqual(vector1, Vector<double>.Cross3(vector2, vector3));
                Assert.AreEqual(vector2, Vector<double>.Cross3(vector3, vector1));
                Assert.AreEqual(vector3, Vector<double>.Cross3(vector1, vector2));
            }
        }
    }
#pragma warning restore CA2252 // この API では、プレビュー機能をオプトインする必要があります
}