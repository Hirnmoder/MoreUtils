using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoreUtils.Calculation;

namespace MoreUtils.Test.Calculation
{
    [TestClass]
    public class InterpolateTest
    {
        [TestMethod]
        public void TestLinear()
        {
            Assert.AreEqual(5.5, Interpolate.Linear(4, 7, 0.5));
            Assert.AreEqual(1.0, Interpolate.Linear(2, 3, -1));
            Assert.AreEqual(5.5, Interpolate.Linear(3, 4, 2.5));
        }

        [TestMethod]
        public void TestLinearClamp()
        {
            Assert.AreEqual(5.5, Interpolate.LinearClamp(4, 7, 0.5));
            Assert.AreEqual(2.0, Interpolate.LinearClamp(2, 3, -1));
            Assert.AreEqual(4.0, Interpolate.LinearClamp(3, 4, 2.5));
        }

        [TestMethod]
        public void TestSmooth()
        {
            Assert.AreEqual(5.5, Interpolate.Smooth(4, 7, 0.5));
            Assert.AreEqual(2.0, Interpolate.Smooth(2, 3, 0));
            Assert.AreEqual(4.0, Interpolate.Smooth(3, 4, 1));
            Assert.AreEqual(7.938926261462365, Interpolate.Smooth(0, 10, 0.7));
        }

        [TestMethod]
        public void TestSmoothClamp()
        {
            Assert.AreEqual(5.5, Interpolate.SmoothClamp(4, 7, 0.5));
            Assert.AreEqual(2.0, Interpolate.SmoothClamp(2, 3, 0));
            Assert.AreEqual(4.0, Interpolate.SmoothClamp(3, 4, 1));
            Assert.AreEqual(7.938926261462365, Interpolate.SmoothClamp(0, 10, 0.7));
        }
    }
}
