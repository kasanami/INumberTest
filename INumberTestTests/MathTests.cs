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
        public void SqrtTest()
        {
            var a = Math<float>.Sqrt(2);
            Assert.AreEqual(1.414213562f, a);
            var b = Math<double>.Sqrt(2);
            Assert.AreEqual(1.414213562373095, b);
            var c = Math<decimal>.Sqrt(2);
            Assert.AreEqual(1.4142135623730950488016887242m, c);
        }
    }
#pragma warning restore CA2252 // この API では、プレビュー機能をオプトインする必要があります
}