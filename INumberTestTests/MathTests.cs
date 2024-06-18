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
    public class MathTests
    {
        [TestMethod()]
        public void SumTest()
        {
            var a = Math<float>.Sum(new float[] { 1, 2, 3 });
            Assert.AreEqual(6f, a);
            var b = Math<double>.Sum(new double[] { 1, 2, 3 });
            Assert.AreEqual(6d, b);
            var c = Math<decimal>.Sum(new decimal[] { 1, 2, 3 });
            Assert.AreEqual(6m, c);
        }
        [TestMethod()]
        public void SqrtTest()
        {
            var a = Math<float>.Sqrt(2);
            Assert.AreEqual(1.414213562f, a);
            var b = Math<double>.Sqrt(2);
            Assert.AreEqual(1.414213562373095, b);
            var c = Math<decimal>.Sqrt(2);
            Assert.AreEqual(1.4142135623730950488016887242m, c);
        }

        [TestMethod()]
        public void PowTest()
        {
            var a = Math<float>.Pow(10,2);
            Assert.AreEqual(100.0f, a);
            var b = Math<double>.Pow(10, 2);
            Assert.AreEqual(100.0, b);
            var c = Math<decimal>.Pow(10, 2);
            Assert.AreEqual(100.0m, c);

            var d = Math<float>.Pow(10, 0);
            Assert.AreEqual(1.0f, d);
            var e = Math<double>.Pow(10, 0);
            Assert.AreEqual(1.0, e);
            var f = Math<decimal>.Pow(10, 0);
            Assert.AreEqual(1.0m, f);

            var g = Math<float>.Pow(10, -2);
            Assert.AreEqual(0.01f, g);
            var h = Math<double>.Pow(10, -2);
            Assert.AreEqual(0.01, h);
            var i = Math<decimal>.Pow(10, -2);
            Assert.AreEqual(0.01m, i);
        }
    }
#pragma warning restore CA2252 // この API では、プレビュー機能をオプトインする必要があります
}