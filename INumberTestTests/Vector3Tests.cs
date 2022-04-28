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
    public class Vector3Tests
    {
        [TestMethod()]
        public void MagnitudeTest()
        {
            var vector = new Vector3<double>(1, 1, 1);
            Assert.AreEqual(1.7320508075688774, vector.Magnitude);
        }

        [TestMethod()]
        public void SquaredMagnitudeTest()
        {
            var vector = new Vector3<double>(1, 1, 1);
            Assert.AreEqual(3, vector.SquaredMagnitude);

            vector = new Vector3<double>(2, 2, 2);
            Assert.AreEqual(12, vector.SquaredMagnitude);
        }

        [TestMethod()]
        public void NormalizedTest()
        {
            var vector = new Vector3<double>(1,1,1);
            vector.Normalize();
            Assert.AreEqual(0.57735026918962573, vector.X);
            Assert.AreEqual(0.57735026918962573, vector.Y);
            Assert.AreEqual(0.57735026918962573, vector.Z);
        }
    }
#pragma warning restore CA2252 // この API では、プレビュー機能をオプトインする必要があります
}