using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeiSolver.BackEnd
{
    class CacheSimulator {
        public bool debug = false;

        //private fields
        private List<LRU> lrus;
        private List<List<int>> cacheSets;
        private int blockSize;
        private int blocks;
        private int ways;

        //constructor
        public CacheSimulator(int blocks = 8, int blockSize = 32, int ways = 1) {
            this.blocks = blocks;
            this.blockSize = blockSize;
            this.ways = ways;

            cacheSets = Enumerable.Select(Enumerable.Range(0, blocks), i => Enumerable.Repeat(-1, ways).ToList()).ToList();
            lrus = Enumerable.Select(Enumerable.Range(0, blocks), i => new LRU(ways)).ToList();

        }


        public (bool, int, int, int) find(int address) {
            //calculating memory block and cache block index
            int memBlock = calculateMemBlock(address);
            int index = calculatecacheSet(memBlock:memBlock);

            List<int> cacheSet = cacheSets[index];

            //searching the memory block inside the cache block
            int lru = -1;
            bool hit = true;
            if (cacheSet.Contains(memBlock)) {
                //HIT, updating LRU before returning
                lru = cacheSet.IndexOf(memBlock);
                if (debug) Console.WriteLine($"{address}: HIT (MEMBLOCK {memBlock} IS IN cacheSet {index}[{lru}])");
            }else {
                //MISS, NEED TO LOAD BLOCK
                lru = lrus[index].getLeastRecentlyUsed();
                cacheSet[lru] = memBlock;
                if (debug) Console.WriteLine($"{address}: MISS!!! MEMBLOCK {memBlock} -> cacheSet {index}[{lru}]");
                hit = false;
               }

            //updating LRU
            lrus[index].pushToTop(lru);
            if (debug) Console.WriteLine($"LAST USED BLOCK FOR cacheSet {index}: {lru}");

            return (hit, memBlock, index, lru);
        }

        public bool hitOrMiss(int address) {
            bool hit;
            Object _;

            (hit, _, _, _) = find(address);
            return hit;
        }

        public int calculateMemBlock(int address){
            return address / blockSize;
        }

        public int calculatecacheSet(int address = -1, int memBlock = -1) {
            if (address != -1) {
                memBlock = calculateMemBlock(address);
            }
            return memBlock % blocks;
        }

    }
}
