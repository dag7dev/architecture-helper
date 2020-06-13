from CacheSimulator import CacheSimulator

addresses = [24, 64, 164, 32, 208, 128, 44, 192, 432, 452, 88, 212, 504, 384, 32, 52, 292, 232, 388, 400, 404, 288, 40, 376]


cache = CacheSimulator(blocks=8,blockSize=32,ways=1)
#cache.debug = True


hits = misses = 0

for address, hit in map(lambda address: (address, cache.find(address)),addresses):
    hits += 1 if hit else 0
    misses += 1 if not hit else 0
    if(not cache.debug): print(address,"\t","HIT" if hit else "MISS")

print(f"HITS: {hits} MISSES: {misses}")