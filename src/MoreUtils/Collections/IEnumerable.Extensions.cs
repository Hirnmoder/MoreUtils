using System;
using System.Collections.Generic;

namespace MoreUtils.Collections
{
    public static partial class IEnumerableExtensions
    {
        /// <summary>
        /// Performs the specified <paramref name="action"/> on each element of <paramref name="source"/>.
        /// </summary>
        /// <typeparam name="T">The type of elements in <paramref name="source"/>.</typeparam>
        /// <param name="source">An <see cref="IEnumerable{T}"/>.</param>
        /// <param name="action">The <see cref="Action{T}"/> delegate to perform on each element of <paramref name="source"/>.</param>
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (T element in source)
            {
                action(element);
            }
        }

        /// <param name="action">The <see cref="Action{T,int}"/> delegate to perform on each element of <paramref name="source"/>.</param>
        /// <inheritdoc cref="ForEach{T}(IEnumerable{T}, Action{T})"/>
        public static void ForEach<T>(this IEnumerable<T> source, Action<T, int> action)
        {
            var enumerator = source.GetEnumerator();
            for (int i = 0; enumerator.MoveNext(); i++)
            {
                action(enumerator.Current, i);
            }
        }
    }
}
