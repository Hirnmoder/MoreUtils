using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoreUtils.Collections;

namespace MoreUtils.Test.Collections
{
    [TestClass]
    public class RangeTest
    {
        [TestMethod]
        public void TestRangeEnd()
        {
            const int n = 50;

            int sum = 0;
            foreach (var i in new Range(n + 1))
            {
                sum += i;
            }
            Assert.AreEqual(this.SumOf(n), sum);
        }

        [TestMethod]
        public void TestRangeStart()
        {
            const int s = 5;
            const int n = 50;

            int sum = 0;
            foreach(var i in new Range(s, n + 1))
            {
                sum += i;
            }
            Assert.AreEqual(this.SumOf(n, s), sum);
        }

        [TestMethod]
        public void TestRangeStep()
        {
            const int start = 5;
            const int step = 2;
            const int n = 14;
            const int expectedResult = 45;

            int sum = 0;
            foreach (var i in new Range(start, n + 1, step))
            {
                sum += i;
            }
            Assert.AreEqual(expectedResult, sum);
        }


        [TestMethod]
        public void TestSumOf()
        {
            Assert.AreEqual(10, this.SumOf(4));
            Assert.AreEqual(15, this.SumOf(5));
            Assert.AreEqual(14, this.SumOf(5, 2));
            Assert.AreEqual(5, this.SumOf(5, 5));
        }

        private int SumOf(int endInclusive, int startInclusive = 0)
        {
            return (endInclusive * (endInclusive + 1) / 2) - (startInclusive * (startInclusive - 1) / 2);
        }
    }
}
