from CacheSimulator import CacheSimulator

addresses = [24, 64, 164, 32, 208, 128, 44, 192, 432, 452, 88, 212, 504, 384, 32, 52, 292, 232, 388, 400, 404, 288, 40, 376]

cache = CacheSimulator(blocks=8, blockSize=32, ways=1)
#enable the debug mode for verbose output
#cache.debug = True

hits = misses = 0

for address in addresses:
    if(cache.find(address)):
        hits += 1
        if(not cache.debug): print(address,"\tHIT")
    else:
        misses += 1
        if(not cache.debug): print(address,"\tMISS")

print(f"\nHITS: {hits} MISSES: {misses}")