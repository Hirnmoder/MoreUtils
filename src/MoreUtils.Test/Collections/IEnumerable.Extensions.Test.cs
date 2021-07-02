using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MoreUtils.Collections;
using System;

namespace MoreUtils.Test.Collections
{
    [TestClass]
    public class IEnumerableExtensionsTest
    {
        [TestMethod]
        public void TestForEachWithoutIndex()
        {
            IEnumerable<string> source = new string[]
            {
                "first",
                "second",
                "third",
            };

            int first = 0, second = 0, third = 0;
            source.ForEach(s =>
            {
                switch (s)
                {
                    case "first":
                        first++;
                        break;
                    case "second":
                        second++;
                        break;
                    case "third":
                        third++;
                        break;
                    default:
                        Assert.Fail();
                        break;
                }
            });
            Assert.AreEqual(1, first);
            Assert.AreEqual(1, second);
            Assert.AreEqual(1, third);
        }

        [TestMethod]
        public void TestForEachWithIndex()
        {
            IEnumerable<string> source = new string[]
            {
                "first",
                "second",
                "third",
            };

            int first = 0, second = 0, third = 0;
            source.ForEach((s, i) =>
            {
                switch (s)
                {
                    case "first":
                        first++;
                        Assert.AreEqual(0, i);
                        break;
                    case "second":
                        second++;
                        Assert.AreEqual(1, i);
                        break;
                    case "third":
                        third++;
                        Assert.AreEqual(2, i);
                        break;
                    default:
                        Assert.Fail();
                        break;
                }
            });
            Assert.AreEqual(1, first);
            Assert.AreEqual(1, second);
            Assert.AreEqual(1, third);
        }

        [TestMethod]
        public void Test2TupleForEach()
        {
            IEnumerable<int> source1 = new int[]
            {
                0,
                1,
                2,
            };

            IEnumerable<string> source2 = new string[]
            {
                "zero",
                "one",
                "two",
            };

            bool _0 = false, _1 = false, _2 = false;
            (source1, source2).ForEach((i, s) =>
            {
                switch (i)
                {
                    case 0:
                        Assert.AreEqual(false, _0);
                        _0 = true;
                        Assert.AreEqual("zero", s);
                        break;
                    case 1:
                        Assert.AreEqual(false, _1);
                        _1 = true;
                        Assert.AreEqual("one", s);
                        break;
                    case 2:
                        Assert.AreEqual(false, _2);
                        _2 = true;
                        Assert.AreEqual("two", s);
                        break;
                    default:
                        Assert.Fail();
                        break;
                }
            });


            Assert.AreEqual(true, _0);
            Assert.AreEqual(true, _1);
            Assert.AreEqual(true, _2);
        }

        [TestMethod]
        public void Test8TupleForEach()
        {
            int idx = 0;
            (
                new int[] { 1, 2, 3 },
                new string[] { "one", "two", "three" },
                new float[] { 0.0f, 1.0f, 2.0f },
                new object[] { new byte[4], UriFormat.Unescaped, typeof(TestMethodAttribute) },
                new List<double>() { 1.125, 2.5, 8.192 },
                new HashSet<char>() { 'h', 'e', 'y' },
                new Stack<byte>() { (byte)5, (byte)250, (byte)255 },
                new SortedSet<int>() { 100, 300, 200 }
            )
            .ForEach((a, b, c, d, e, f, g, h) =>
            {
                switch (idx)
                {
                    case 0:
                        Assert.AreEqual(1, a);
                        Assert.AreEqual("one", b);
                        Assert.AreEqual(0.0f, c);
                        Assert.AreEqual(typeof(byte[]), d.GetType());
                        Assert.AreEqual(1.125, e);
                        Assert.AreEqual('h', f);
                        Assert.AreEqual(255, g);
                        Assert.AreEqual(100, h);
                        break;

                    case 1:
                        Assert.AreEqual(2, a);
                        Assert.AreEqual("two", b);
                        Assert.AreEqual(1.0f, c);
                        Assert.AreEqual(UriFormat.Unescaped, d);
                        Assert.AreEqual(2.5, e);
                        Assert.AreEqual('e', f);
                        Assert.AreEqual(250, g);
                        Assert.AreEqual(200, h);
                        break;

                    case 2:
                        Assert.AreEqual(3, a);
                        Assert.AreEqual("three", b);
                        Assert.AreEqual(2.0f, c);
                        Assert.AreEqual(typeof(TestMethodAttribute), d);
                        Assert.AreEqual(8.192, e);
                        Assert.AreEqual('y', f);
                        Assert.AreEqual(5, g);
                        Assert.AreEqual(300, h);
                        break;

                    default:
                        Assert.Fail();
                        break;
                }
                idx++;
            });
        }



    }

    public static class IEnumerableExtensionsTestHelper
    {
        public static void Add<T>(this Stack<T> stack, T element)
        {
            stack.Push(element);
        }
    }
}
