#!/usr/bin/env python3

import sys
import os
import json
from typing import List

from CacheSimulator import CacheSimulator

def main():
    #DEFAULT VALUES FOR -t
    cache_type = 2
    cache_sets = 8
    cache_block_size = 32
    addresses = [24, 64, 164, 32, 208, 128, 44, 192, 432, 452, 88, 212, 504, 384, 32, 52, 292, 232, 388, 400, 404, 288, 40, 376]
    
    #check if the help has been requested
    if "-h" in sys.argv:
        show_help()
        exit(0)

    # check if file option has been activated
    if "-f" in sys.argv:
        filename = sys.argv[sys.argv.index("-f") + 1]

        if os.path.exists(filename):
            # read
            with open(filename, "r") as fd:
                calc_params = json.load(fd)
                addresses = calc_params['addresses']
                cache_block_size = calc_params['cache_block_size']

                cache_type = calc_params['cache_type']
                cache_sets = calc_params['cache_sets']
        else:
            print(
                "Mmh, " + filename + " doesn't appear to exist.\n" +
                "Did you read the help message, didn't you?\n" +
                "(launch the program with -h option)")
            exit(0)

    #if the test option has not been activated, the help neither and the file neither, it means that the user want to input data by himself
    elif "-t" not in sys.argv:

        #addresses input
        addresses = formatAddressList(input("Insert address list ([]):"))
        print(addresses)

        #cache data
        cache_type          = int(input(f"Cache type number ({cache_type}): ") or cache_type)
        cache_sets          = int(input(f"Cache sets ({cache_sets}): ") or cache_sets)
        cache_block_size    = int(input(f"Block size ({cache_block_size}): ") or cache_block_size)
    
    run_tests(cache_type, cache_sets, cache_block_size, addresses)

    return

def run_tests(cache_type:int, cache_sets:int, cache_block_size:int, addresses:List[int]):
    cache = CacheSimulator(blocks=cache_sets, blockSize=cache_block_size, ways=cache_type)
    hits = misses = 0

    print("ADDRESS\tBLOCK\tSET\tHIT/MISS")
    for address in addresses:
        hit, memBlock, cacheBlock, wayIndex = cache.find(address)
        if(hit):
            hits += 1
        else:
            misses += 1
        
        wayIndex = "" if cache_type == 1 else f"[{wayIndex}]"
        print(f"{address}\t{memBlock}\t{cacheBlock}{wayIndex}\t{'Hit' if hit else 'Miss'}")

    print(f"HITS: {hits} MISSES: {misses}")

    input("PRESS ENTER TO CLOSE")
        

def show_help():
    if len(sys.argv) == 1 or "-h" in sys.argv:
        print("Usage: ")
        print("\tno parameters: \n\t\tinteractive mode - write your own data")
        print("\t-t: \n\t\ttest mode - work with an example - no other parameter needed")
        print("\t-f filename: \n\t\tfile mode - import data from a json file - you shall pass the filename")
        print("\t-h: \n\t\thelp mode - you are reading this!")
        exit(0)

def formatAddressList(address_list_string:str):
    addresses = []
    lastWasNumeric = False
    buffer = ""

    for char in address_list_string:
        if(char.isdigit()):
            buffer += char
            lastWasNumeric = True
        else:
            if(lastWasNumeric):
                addresses.append(int(buffer))
                buffer = ""
            lastWasNumeric = False
    
    if(lastWasNumeric):
        addresses.append(int(buffer))

    return addresses


if __name__ == '__main__':
    main()
