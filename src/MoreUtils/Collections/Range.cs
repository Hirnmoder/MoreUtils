using System.Collections;
using System.Collections.Generic;

namespace MoreUtils.Collections
{
    public sealed class Range : IEnumerable<int>
    {
        private int _End;
        private int _Start = 0;
        private int _Step = 1;

        public Range(int end)
        {
            this._End = end;
        }

        public Range(int start, int end)
        {
            this._End = end;
            this._Start = start;
        }

        public Range(int start, int end, int step)
        {
            this._End = end;
            this._Start = start;
            this._Step = step;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = this._Start; i < this._End; i += this._Step)
                yield return i;
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
