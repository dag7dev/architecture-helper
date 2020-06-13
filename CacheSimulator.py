DEBUG = False

from typing import List

class LRU:
    _values:List
    _lastIndex:int

    def __init__(self, ways):
        #values = 3,2,1,0, so the cache will use 0 as the first
        self._values = list(range(ways-1,-1,-1))
        self._lastIndex = ways -1

    def getLeastRecentlyUsed(self):
        return self._values[self._lastIndex]

    def pushToTop(self, element):
        self._values.remove(element)
        self._values.insert(0,element)

class CacheSimulator:
    debug = False

    #private fields
    _lrus:List[LRU]
    _cacheBlocks:List[List]
    _blockSize:int
    _blocks:int
    _ways:int

    #constructor
    def __init__(self, blocks = 8, blockSize = 32, ways = 1):
        self._blocks = blocks
        self._blockSize = blockSize
        self._ways = ways
        self._cacheBlocks = list(map(lambda i: [-1]*ways, range(blocks)))
        self._lrus = list(map(lambda i: LRU(ways), range(blockSize)))

    
    def find(self, address) -> bool:
        #calculating memory block and cache block index
        memBlock = self.calculateMemBlock(address)
        index = self.calculateCacheBlock(memBlock=memBlock)

        cacheBlock = self._cacheBlocks[index]

        #searching the memory block inside the cache block
        lru = -1
        hit = True
        if(memBlock in cacheBlock):
            #HIT, updating LRU before returning
            lru = cacheBlock.index(memBlock)
            if(self.debug): print(f"{address}: HIT (MEMBLOCK {memBlock} IS IN CACHEBLOCK {index}[{lru}])")
        else:
            #MISS, NEED TO LOAD BLOCK
            lru = self._lrus[index].getLeastRecentlyUsed()
            cacheBlock[lru] = memBlock
            if(self.debug): print(f"{address}: MISS!!! MEMBLOCK {memBlock} -> CACHEBLOCK {index}[{lru}]")
            hit = False
        
        #updating LRU
        self._lrus[index].pushToTop(lru)
        if(self.debug): print(f"LAST USED BLOCK FOR CACHEBLOCK {index}: {lru}")

        return hit

    def calculateMemBlock(self, address:int) -> int:
        return address // self._blockSize

    def calculateCacheBlock(self, address:int = -1, memBlock:int = -1) -> int:
        if(address != -1):
            memBlock = self.calculateMemBlock(address)
        return memBlock % self._blocks
