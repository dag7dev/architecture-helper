using System.Collections.Generic;
using System.Linq;

namespace MeiSolver.BackEnd {
    class LRU {
        private List<int> values;
        private int lastIndex;

        public LRU(int elements) {
            //values = 3,2,1,0, so the cache will use 0 as the first
            values = Enumerable.Range(0, elements).Reverse().ToList();
            lastIndex = elements - 1;
        }

        public int getLeastRecentlyUsed() {
            return values[lastIndex];
        }

        public void pushToTop(int index) {
            values.Remove(index);
            values.Insert(0, index);
        }
    }
}
