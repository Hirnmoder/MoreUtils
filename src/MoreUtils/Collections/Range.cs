using System.Collections;
using System.Collections.Generic;

namespace MoreUtils.Collections
{
    public sealed class Range : IEnumerable<int>
    {
        private readonly int _End;
        private readonly int _Start;
        private readonly int _Step;

        /// <inheritdoc cref="Range.Range(int, int, int)"/>
        public Range(int end)
            : this(0, end, 1)
        { }

        /// <inheritdoc cref="Range.Range(int, int, int)"/>
        public Range(int start, int end)
            : this(start, end, 1)
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Range"/> class.
        /// </summary>
        /// <param name="start">Start value (inclusive).</param>
        /// <param name="end">End value (exclusive).</param>
        /// <param name="step">Interval added to the current value each iteration.</param>
        public Range(int start, int end, int step)
        {
            this._End = end;
            this._Start = start;
            this._Step = step;
        }

        /// <inheritdoc />
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = this._Start; i < this._End; i += this._Step)
                yield return i;
        }

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
