/**
 * This code was generated by a tool.
 * Any changes made to this file may cause incorrect behavior and will be lost if the code is regenerated.
 */

using System;
using System.Collections.Generic;

namespace MoreUtils.Collections
{
    public static partial class IEnumerableExtensions
    {

        /// <summary>
        /// Performs the specified <paramref name="action"/> on each 2-tuple of elements from <paramref name="source"/>.
        /// </summary>
        /// <param name="tuple">Multiple <see cref="IEnumerable{T}"/>s to loop through together.</param>
        /// <param name="action">A <see cref="Action{T1,T2}"/> delegate to perform on each 2 elements of <paramref name="tuple"/>.</param>
        public static void ForEach<T1, T2>(this (IEnumerable<T1> source1, IEnumerable<T2> source2) tuple, Action<T1, T2> action)
        {
            var e1 = tuple.source1.GetEnumerator();
            var e2 = tuple.source2.GetEnumerator();
            while(e1.MoveNext() && e2.MoveNext())
            {
                action(e1.Current, e2.Current);
            }
        }

        /// <summary>
        /// Performs the specified <paramref name="action"/> on each 3-tuple of elements from <paramref name="source"/>.
        /// </summary>
        /// <param name="tuple">Multiple <see cref="IEnumerable{T}"/>s to loop through together.</param>
        /// <param name="action">A <see cref="Action{T1,T2,T3}"/> delegate to perform on each 3 elements of <paramref name="tuple"/>.</param>
        public static void ForEach<T1, T2, T3>(this (IEnumerable<T1> source1, IEnumerable<T2> source2, IEnumerable<T3> source3) tuple, Action<T1, T2, T3> action)
        {
            var e1 = tuple.source1.GetEnumerator();
            var e2 = tuple.source2.GetEnumerator();
            var e3 = tuple.source3.GetEnumerator();
            while(e1.MoveNext() && e2.MoveNext() && e3.MoveNext())
            {
                action(e1.Current, e2.Current, e3.Current);
            }
        }

        /// <summary>
        /// Performs the specified <paramref name="action"/> on each 4-tuple of elements from <paramref name="source"/>.
        /// </summary>
        /// <param name="tuple">Multiple <see cref="IEnumerable{T}"/>s to loop through together.</param>
        /// <param name="action">A <see cref="Action{T1,T2,T3,T4}"/> delegate to perform on each 4 elements of <paramref name="tuple"/>.</param>
        public static void ForEach<T1, T2, T3, T4>(this (IEnumerable<T1> source1, IEnumerable<T2> source2, IEnumerable<T3> source3, IEnumerable<T4> source4) tuple, Action<T1, T2, T3, T4> action)
        {
            var e1 = tuple.source1.GetEnumerator();
            var e2 = tuple.source2.GetEnumerator();
            var e3 = tuple.source3.GetEnumerator();
            var e4 = tuple.source4.GetEnumerator();
            while(e1.MoveNext() && e2.MoveNext() && e3.MoveNext() && e4.MoveNext())
            {
                action(e1.Current, e2.Current, e3.Current, e4.Current);
            }
        }

        /// <summary>
        /// Performs the specified <paramref name="action"/> on each 5-tuple of elements from <paramref name="source"/>.
        /// </summary>
        /// <param name="tuple">Multiple <see cref="IEnumerable{T}"/>s to loop through together.</param>
        /// <param name="action">A <see cref="Action{T1,T2,T3,T4,T5}"/> delegate to perform on each 5 elements of <paramref name="tuple"/>.</param>
        public static void ForEach<T1, T2, T3, T4, T5>(this (IEnumerable<T1> source1, IEnumerable<T2> source2, IEnumerable<T3> source3, IEnumerable<T4> source4, IEnumerable<T5> source5) tuple, Action<T1, T2, T3, T4, T5> action)
        {
            var e1 = tuple.source1.GetEnumerator();
            var e2 = tuple.source2.GetEnumerator();
            var e3 = tuple.source3.GetEnumerator();
            var e4 = tuple.source4.GetEnumerator();
            var e5 = tuple.source5.GetEnumerator();
            while(e1.MoveNext() && e2.MoveNext() && e3.MoveNext() && e4.MoveNext() && e5.MoveNext())
            {
                action(e1.Current, e2.Current, e3.Current, e4.Current, e5.Current);
            }
        }

        /// <summary>
        /// Performs the specified <paramref name="action"/> on each 6-tuple of elements from <paramref name="source"/>.
        /// </summary>
        /// <param name="tuple">Multiple <see cref="IEnumerable{T}"/>s to loop through together.</param>
        /// <param name="action">A <see cref="Action{T1,T2,T3,T4,T5,T6}"/> delegate to perform on each 6 elements of <paramref name="tuple"/>.</param>
        public static void ForEach<T1, T2, T3, T4, T5, T6>(this (IEnumerable<T1> source1, IEnumerable<T2> source2, IEnumerable<T3> source3, IEnumerable<T4> source4, IEnumerable<T5> source5, IEnumerable<T6> source6) tuple, Action<T1, T2, T3, T4, T5, T6> action)
        {
            var e1 = tuple.source1.GetEnumerator();
            var e2 = tuple.source2.GetEnumerator();
            var e3 = tuple.source3.GetEnumerator();
            var e4 = tuple.source4.GetEnumerator();
            var e5 = tuple.source5.GetEnumerator();
            var e6 = tuple.source6.GetEnumerator();
            while(e1.MoveNext() && e2.MoveNext() && e3.MoveNext() && e4.MoveNext() && e5.MoveNext() && e6.MoveNext())
            {
                action(e1.Current, e2.Current, e3.Current, e4.Current, e5.Current, e6.Current);
            }
        }

        /// <summary>
        /// Performs the specified <paramref name="action"/> on each 7-tuple of elements from <paramref name="source"/>.
        /// </summary>
        /// <param name="tuple">Multiple <see cref="IEnumerable{T}"/>s to loop through together.</param>
        /// <param name="action">A <see cref="Action{T1,T2,T3,T4,T5,T6,T7}"/> delegate to perform on each 7 elements of <paramref name="tuple"/>.</param>
        public static void ForEach<T1, T2, T3, T4, T5, T6, T7>(this (IEnumerable<T1> source1, IEnumerable<T2> source2, IEnumerable<T3> source3, IEnumerable<T4> source4, IEnumerable<T5> source5, IEnumerable<T6> source6, IEnumerable<T7> source7) tuple, Action<T1, T2, T3, T4, T5, T6, T7> action)
        {
            var e1 = tuple.source1.GetEnumerator();
            var e2 = tuple.source2.GetEnumerator();
            var e3 = tuple.source3.GetEnumerator();
            var e4 = tuple.source4.GetEnumerator();
            var e5 = tuple.source5.GetEnumerator();
            var e6 = tuple.source6.GetEnumerator();
            var e7 = tuple.source7.GetEnumerator();
            while(e1.MoveNext() && e2.MoveNext() && e3.MoveNext() && e4.MoveNext() && e5.MoveNext() && e6.MoveNext() && e7.MoveNext())
            {
                action(e1.Current, e2.Current, e3.Current, e4.Current, e5.Current, e6.Current, e7.Current);
            }
        }

        /// <summary>
        /// Performs the specified <paramref name="action"/> on each 8-tuple of elements from <paramref name="source"/>.
        /// </summary>
        /// <param name="tuple">Multiple <see cref="IEnumerable{T}"/>s to loop through together.</param>
        /// <param name="action">A <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8}"/> delegate to perform on each 8 elements of <paramref name="tuple"/>.</param>
        public static void ForEach<T1, T2, T3, T4, T5, T6, T7, T8>(this (IEnumerable<T1> source1, IEnumerable<T2> source2, IEnumerable<T3> source3, IEnumerable<T4> source4, IEnumerable<T5> source5, IEnumerable<T6> source6, IEnumerable<T7> source7, IEnumerable<T8> source8) tuple, Action<T1, T2, T3, T4, T5, T6, T7, T8> action)
        {
            var e1 = tuple.source1.GetEnumerator();
            var e2 = tuple.source2.GetEnumerator();
            var e3 = tuple.source3.GetEnumerator();
            var e4 = tuple.source4.GetEnumerator();
            var e5 = tuple.source5.GetEnumerator();
            var e6 = tuple.source6.GetEnumerator();
            var e7 = tuple.source7.GetEnumerator();
            var e8 = tuple.source8.GetEnumerator();
            while(e1.MoveNext() && e2.MoveNext() && e3.MoveNext() && e4.MoveNext() && e5.MoveNext() && e6.MoveNext() && e7.MoveNext() && e8.MoveNext())
            {
                action(e1.Current, e2.Current, e3.Current, e4.Current, e5.Current, e6.Current, e7.Current, e8.Current);
            }
        }

        /// <summary>
        /// Performs the specified <paramref name="action"/> on each 9-tuple of elements from <paramref name="source"/>.
        /// </summary>
        /// <param name="tuple">Multiple <see cref="IEnumerable{T}"/>s to loop through together.</param>
        /// <param name="action">A <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9}"/> delegate to perform on each 9 elements of <paramref name="tuple"/>.</param>
        public static void ForEach<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this (IEnumerable<T1> source1, IEnumerable<T2> source2, IEnumerable<T3> source3, IEnumerable<T4> source4, IEnumerable<T5> source5, IEnumerable<T6> source6, IEnumerable<T7> source7, IEnumerable<T8> source8, IEnumerable<T9> source9) tuple, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action)
        {
            var e1 = tuple.source1.GetEnumerator();
            var e2 = tuple.source2.GetEnumerator();
            var e3 = tuple.source3.GetEnumerator();
            var e4 = tuple.source4.GetEnumerator();
            var e5 = tuple.source5.GetEnumerator();
            var e6 = tuple.source6.GetEnumerator();
            var e7 = tuple.source7.GetEnumerator();
            var e8 = tuple.source8.GetEnumerator();
            var e9 = tuple.source9.GetEnumerator();
            while(e1.MoveNext() && e2.MoveNext() && e3.MoveNext() && e4.MoveNext() && e5.MoveNext() && e6.MoveNext() && e7.MoveNext() && e8.MoveNext() && e9.MoveNext())
            {
                action(e1.Current, e2.Current, e3.Current, e4.Current, e5.Current, e6.Current, e7.Current, e8.Current, e9.Current);
            }
        }

        /// <summary>
        /// Performs the specified <paramref name="action"/> on each 10-tuple of elements from <paramref name="source"/>.
        /// </summary>
        /// <param name="tuple">Multiple <see cref="IEnumerable{T}"/>s to loop through together.</param>
        /// <param name="action">A <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10}"/> delegate to perform on each 10 elements of <paramref name="tuple"/>.</param>
        public static void ForEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this (IEnumerable<T1> source1, IEnumerable<T2> source2, IEnumerable<T3> source3, IEnumerable<T4> source4, IEnumerable<T5> source5, IEnumerable<T6> source6, IEnumerable<T7> source7, IEnumerable<T8> source8, IEnumerable<T9> source9, IEnumerable<T10> source10) tuple, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action)
        {
            var e1 = tuple.source1.GetEnumerator();
            var e2 = tuple.source2.GetEnumerator();
            var e3 = tuple.source3.GetEnumerator();
            var e4 = tuple.source4.GetEnumerator();
            var e5 = tuple.source5.GetEnumerator();
            var e6 = tuple.source6.GetEnumerator();
            var e7 = tuple.source7.GetEnumerator();
            var e8 = tuple.source8.GetEnumerator();
            var e9 = tuple.source9.GetEnumerator();
            var e10 = tuple.source10.GetEnumerator();
            while(e1.MoveNext() && e2.MoveNext() && e3.MoveNext() && e4.MoveNext() && e5.MoveNext() && e6.MoveNext() && e7.MoveNext() && e8.MoveNext() && e9.MoveNext() && e10.MoveNext())
            {
                action(e1.Current, e2.Current, e3.Current, e4.Current, e5.Current, e6.Current, e7.Current, e8.Current, e9.Current, e10.Current);
            }
        }

        /// <summary>
        /// Performs the specified <paramref name="action"/> on each 11-tuple of elements from <paramref name="source"/>.
        /// </summary>
        /// <param name="tuple">Multiple <see cref="IEnumerable{T}"/>s to loop through together.</param>
        /// <param name="action">A <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11}"/> delegate to perform on each 11 elements of <paramref name="tuple"/>.</param>
        public static void ForEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this (IEnumerable<T1> source1, IEnumerable<T2> source2, IEnumerable<T3> source3, IEnumerable<T4> source4, IEnumerable<T5> source5, IEnumerable<T6> source6, IEnumerable<T7> source7, IEnumerable<T8> source8, IEnumerable<T9> source9, IEnumerable<T10> source10, IEnumerable<T11> source11) tuple, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action)
        {
            var e1 = tuple.source1.GetEnumerator();
            var e2 = tuple.source2.GetEnumerator();
            var e3 = tuple.source3.GetEnumerator();
            var e4 = tuple.source4.GetEnumerator();
            var e5 = tuple.source5.GetEnumerator();
            var e6 = tuple.source6.GetEnumerator();
            var e7 = tuple.source7.GetEnumerator();
            var e8 = tuple.source8.GetEnumerator();
            var e9 = tuple.source9.GetEnumerator();
            var e10 = tuple.source10.GetEnumerator();
            var e11 = tuple.source11.GetEnumerator();
            while(e1.MoveNext() && e2.MoveNext() && e3.MoveNext() && e4.MoveNext() && e5.MoveNext() && e6.MoveNext() && e7.MoveNext() && e8.MoveNext() && e9.MoveNext() && e10.MoveNext() && e11.MoveNext())
            {
                action(e1.Current, e2.Current, e3.Current, e4.Current, e5.Current, e6.Current, e7.Current, e8.Current, e9.Current, e10.Current, e11.Current);
            }
        }

        /// <summary>
        /// Performs the specified <paramref name="action"/> on each 12-tuple of elements from <paramref name="source"/>.
        /// </summary>
        /// <param name="tuple">Multiple <see cref="IEnumerable{T}"/>s to loop through together.</param>
        /// <param name="action">A <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12}"/> delegate to perform on each 12 elements of <paramref name="tuple"/>.</param>
        public static void ForEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this (IEnumerable<T1> source1, IEnumerable<T2> source2, IEnumerable<T3> source3, IEnumerable<T4> source4, IEnumerable<T5> source5, IEnumerable<T6> source6, IEnumerable<T7> source7, IEnumerable<T8> source8, IEnumerable<T9> source9, IEnumerable<T10> source10, IEnumerable<T11> source11, IEnumerable<T12> source12) tuple, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action)
        {
            var e1 = tuple.source1.GetEnumerator();
            var e2 = tuple.source2.GetEnumerator();
            var e3 = tuple.source3.GetEnumerator();
            var e4 = tuple.source4.GetEnumerator();
            var e5 = tuple.source5.GetEnumerator();
            var e6 = tuple.source6.GetEnumerator();
            var e7 = tuple.source7.GetEnumerator();
            var e8 = tuple.source8.GetEnumerator();
            var e9 = tuple.source9.GetEnumerator();
            var e10 = tuple.source10.GetEnumerator();
            var e11 = tuple.source11.GetEnumerator();
            var e12 = tuple.source12.GetEnumerator();
            while(e1.MoveNext() && e2.MoveNext() && e3.MoveNext() && e4.MoveNext() && e5.MoveNext() && e6.MoveNext() && e7.MoveNext() && e8.MoveNext() && e9.MoveNext() && e10.MoveNext() && e11.MoveNext() && e12.MoveNext())
            {
                action(e1.Current, e2.Current, e3.Current, e4.Current, e5.Current, e6.Current, e7.Current, e8.Current, e9.Current, e10.Current, e11.Current, e12.Current);
            }
        }

        /// <summary>
        /// Performs the specified <paramref name="action"/> on each 13-tuple of elements from <paramref name="source"/>.
        /// </summary>
        /// <param name="tuple">Multiple <see cref="IEnumerable{T}"/>s to loop through together.</param>
        /// <param name="action">A <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13}"/> delegate to perform on each 13 elements of <paramref name="tuple"/>.</param>
        public static void ForEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this (IEnumerable<T1> source1, IEnumerable<T2> source2, IEnumerable<T3> source3, IEnumerable<T4> source4, IEnumerable<T5> source5, IEnumerable<T6> source6, IEnumerable<T7> source7, IEnumerable<T8> source8, IEnumerable<T9> source9, IEnumerable<T10> source10, IEnumerable<T11> source11, IEnumerable<T12> source12, IEnumerable<T13> source13) tuple, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action)
        {
            var e1 = tuple.source1.GetEnumerator();
            var e2 = tuple.source2.GetEnumerator();
            var e3 = tuple.source3.GetEnumerator();
            var e4 = tuple.source4.GetEnumerator();
            var e5 = tuple.source5.GetEnumerator();
            var e6 = tuple.source6.GetEnumerator();
            var e7 = tuple.source7.GetEnumerator();
            var e8 = tuple.source8.GetEnumerator();
            var e9 = tuple.source9.GetEnumerator();
            var e10 = tuple.source10.GetEnumerator();
            var e11 = tuple.source11.GetEnumerator();
            var e12 = tuple.source12.GetEnumerator();
            var e13 = tuple.source13.GetEnumerator();
            while(e1.MoveNext() && e2.MoveNext() && e3.MoveNext() && e4.MoveNext() && e5.MoveNext() && e6.MoveNext() && e7.MoveNext() && e8.MoveNext() && e9.MoveNext() && e10.MoveNext() && e11.MoveNext() && e12.MoveNext() && e13.MoveNext())
            {
                action(e1.Current, e2.Current, e3.Current, e4.Current, e5.Current, e6.Current, e7.Current, e8.Current, e9.Current, e10.Current, e11.Current, e12.Current, e13.Current);
            }
        }

        /// <summary>
        /// Performs the specified <paramref name="action"/> on each 14-tuple of elements from <paramref name="source"/>.
        /// </summary>
        /// <param name="tuple">Multiple <see cref="IEnumerable{T}"/>s to loop through together.</param>
        /// <param name="action">A <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14}"/> delegate to perform on each 14 elements of <paramref name="tuple"/>.</param>
        public static void ForEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this (IEnumerable<T1> source1, IEnumerable<T2> source2, IEnumerable<T3> source3, IEnumerable<T4> source4, IEnumerable<T5> source5, IEnumerable<T6> source6, IEnumerable<T7> source7, IEnumerable<T8> source8, IEnumerable<T9> source9, IEnumerable<T10> source10, IEnumerable<T11> source11, IEnumerable<T12> source12, IEnumerable<T13> source13, IEnumerable<T14> source14) tuple, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action)
        {
            var e1 = tuple.source1.GetEnumerator();
            var e2 = tuple.source2.GetEnumerator();
            var e3 = tuple.source3.GetEnumerator();
            var e4 = tuple.source4.GetEnumerator();
            var e5 = tuple.source5.GetEnumerator();
            var e6 = tuple.source6.GetEnumerator();
            var e7 = tuple.source7.GetEnumerator();
            var e8 = tuple.source8.GetEnumerator();
            var e9 = tuple.source9.GetEnumerator();
            var e10 = tuple.source10.GetEnumerator();
            var e11 = tuple.source11.GetEnumerator();
            var e12 = tuple.source12.GetEnumerator();
            var e13 = tuple.source13.GetEnumerator();
            var e14 = tuple.source14.GetEnumerator();
            while(e1.MoveNext() && e2.MoveNext() && e3.MoveNext() && e4.MoveNext() && e5.MoveNext() && e6.MoveNext() && e7.MoveNext() && e8.MoveNext() && e9.MoveNext() && e10.MoveNext() && e11.MoveNext() && e12.MoveNext() && e13.MoveNext() && e14.MoveNext())
            {
                action(e1.Current, e2.Current, e3.Current, e4.Current, e5.Current, e6.Current, e7.Current, e8.Current, e9.Current, e10.Current, e11.Current, e12.Current, e13.Current, e14.Current);
            }
        }

        /// <summary>
        /// Performs the specified <paramref name="action"/> on each 15-tuple of elements from <paramref name="source"/>.
        /// </summary>
        /// <param name="tuple">Multiple <see cref="IEnumerable{T}"/>s to loop through together.</param>
        /// <param name="action">A <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15}"/> delegate to perform on each 15 elements of <paramref name="tuple"/>.</param>
        public static void ForEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this (IEnumerable<T1> source1, IEnumerable<T2> source2, IEnumerable<T3> source3, IEnumerable<T4> source4, IEnumerable<T5> source5, IEnumerable<T6> source6, IEnumerable<T7> source7, IEnumerable<T8> source8, IEnumerable<T9> source9, IEnumerable<T10> source10, IEnumerable<T11> source11, IEnumerable<T12> source12, IEnumerable<T13> source13, IEnumerable<T14> source14, IEnumerable<T15> source15) tuple, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action)
        {
            var e1 = tuple.source1.GetEnumerator();
            var e2 = tuple.source2.GetEnumerator();
            var e3 = tuple.source3.GetEnumerator();
            var e4 = tuple.source4.GetEnumerator();
            var e5 = tuple.source5.GetEnumerator();
            var e6 = tuple.source6.GetEnumerator();
            var e7 = tuple.source7.GetEnumerator();
            var e8 = tuple.source8.GetEnumerator();
            var e9 = tuple.source9.GetEnumerator();
            var e10 = tuple.source10.GetEnumerator();
            var e11 = tuple.source11.GetEnumerator();
            var e12 = tuple.source12.GetEnumerator();
            var e13 = tuple.source13.GetEnumerator();
            var e14 = tuple.source14.GetEnumerator();
            var e15 = tuple.source15.GetEnumerator();
            while(e1.MoveNext() && e2.MoveNext() && e3.MoveNext() && e4.MoveNext() && e5.MoveNext() && e6.MoveNext() && e7.MoveNext() && e8.MoveNext() && e9.MoveNext() && e10.MoveNext() && e11.MoveNext() && e12.MoveNext() && e13.MoveNext() && e14.MoveNext() && e15.MoveNext())
            {
                action(e1.Current, e2.Current, e3.Current, e4.Current, e5.Current, e6.Current, e7.Current, e8.Current, e9.Current, e10.Current, e11.Current, e12.Current, e13.Current, e14.Current, e15.Current);
            }
        }

        /// <summary>
        /// Performs the specified <paramref name="action"/> on each 16-tuple of elements from <paramref name="source"/>.
        /// </summary>
        /// <param name="tuple">Multiple <see cref="IEnumerable{T}"/>s to loop through together.</param>
        /// <param name="action">A <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16}"/> delegate to perform on each 16 elements of <paramref name="tuple"/>.</param>
        public static void ForEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this (IEnumerable<T1> source1, IEnumerable<T2> source2, IEnumerable<T3> source3, IEnumerable<T4> source4, IEnumerable<T5> source5, IEnumerable<T6> source6, IEnumerable<T7> source7, IEnumerable<T8> source8, IEnumerable<T9> source9, IEnumerable<T10> source10, IEnumerable<T11> source11, IEnumerable<T12> source12, IEnumerable<T13> source13, IEnumerable<T14> source14, IEnumerable<T15> source15, IEnumerable<T16> source16) tuple, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action)
        {
            var e1 = tuple.source1.GetEnumerator();
            var e2 = tuple.source2.GetEnumerator();
            var e3 = tuple.source3.GetEnumerator();
            var e4 = tuple.source4.GetEnumerator();
            var e5 = tuple.source5.GetEnumerator();
            var e6 = tuple.source6.GetEnumerator();
            var e7 = tuple.source7.GetEnumerator();
            var e8 = tuple.source8.GetEnumerator();
            var e9 = tuple.source9.GetEnumerator();
            var e10 = tuple.source10.GetEnumerator();
            var e11 = tuple.source11.GetEnumerator();
            var e12 = tuple.source12.GetEnumerator();
            var e13 = tuple.source13.GetEnumerator();
            var e14 = tuple.source14.GetEnumerator();
            var e15 = tuple.source15.GetEnumerator();
            var e16 = tuple.source16.GetEnumerator();
            while(e1.MoveNext() && e2.MoveNext() && e3.MoveNext() && e4.MoveNext() && e5.MoveNext() && e6.MoveNext() && e7.MoveNext() && e8.MoveNext() && e9.MoveNext() && e10.MoveNext() && e11.MoveNext() && e12.MoveNext() && e13.MoveNext() && e14.MoveNext() && e15.MoveNext() && e16.MoveNext())
            {
                action(e1.Current, e2.Current, e3.Current, e4.Current, e5.Current, e6.Current, e7.Current, e8.Current, e9.Current, e10.Current, e11.Current, e12.Current, e13.Current, e14.Current, e15.Current, e16.Current);
            }
        }
    }
}

