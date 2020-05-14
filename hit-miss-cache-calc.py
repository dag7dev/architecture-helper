# 2020 - dag7 - hit-or-miss-cache-calc
import sys
import os
import json

# ugly part, I hate globals too!
global addresses_list
global address_byte_length
global cache_type
global cache_sets
global cache_word_length

# DEFAULT VALUES
# ==============
# data segment
addresses_list = \
    [
        # [24, 64, 164, 32, 208, 128, 44, 192, 432, 452, 88, 212, 504, 384, 32],
        [24, 64, 164, 32, 208, 128, 44, 192, 432, 452, 88, 212, 504, 384, 32, 52, 292, 232, 388, 400, 404, 288, 40,
         376]
    ]

address_byte_length = 32

# cache segment
# NOTE: any-other-way has not been implemented. DO NOT change this value.
cache_type = 2  # two-way by default
cache_sets = 2
cache_word_length = 8  # not sure if it could be useful


def main():
    show_help_maybe()

    # check if file option has been activated
    if "-f" in sys.argv:
        filename_index = sys.argv.index("-f") + 1

        if os.path.exists(sys.argv[filename_index]):
            # read
            with open(sys.argv[filename_index], "r") as fd:
                calc_params = json.load(fd)
                addresses_list = calc_params['addresses_list']
                address_byte_length = calc_params['address_byte_length']

                cache_type = calc_params['cache_type']
                cache_sets = calc_params['cache_sets']
                cache_word_length = calc_params['cache_word_length']  # not sure if it could be useful
        else:
            print(
                "Mmh, " + sys.argv[filename_index] + " doesn't appear to exist.\n" +
                "Did you read the help message, didn't you?\n" +
                "(launch the program with -h option)")
            exit(0)

    # cache_sets rows number
    # cache_type columns number
    cache = [[None] * cache_type for i in range(cache_sets)]
    last_element_pointers = [0 for i in range(cache_sets)]

    # foreach list of words
    for address_list in addresses_list:
        # beautiful print in a table
        print("data address\t"
              "block number\t"
              "set number\t\t"
              "hit or miss")

        for element in address_list:
            block_number = element // address_byte_length

            # there is a more efficient way. Currently idk
            set_number = block_number % cache_sets

            print("\t" + str(element) + "\t\t | \t" +
                  "\t" + str(block_number) + " \t\t | \t" +
                  "\t" + str(set_number) + " \t\t | \t" +
                  "\t" + hit_or_miss(cache, set_number, block_number, last_element_pointers) + " \t")
        print()


def hit_or_miss(cache, set_number, block_number, last_element_pointers):
    """
    # DETERMINE WHETHER HIT OR MISS
    # =============================
    # when miss? -> when i try to access to data and block is not stored anywhere in that set (row)
    # when hit? -> when i try to access to data and block is stored in the set (row)

    # last_element_pointers -> array who contains pointer to the last element
    """
    for cell in range(len(cache[set_number])):
        data = cache[set_number][cell]
        row = cache[set_number]  # row

        if block_number not in row and data is None:
            row[cell] = block_number
            last_element_pointers[set_number] = row.index(block_number)
            return "M"

        elif block_number not in row and None not in row:
            # it sucks but it works just for two-sided
            if last_element_pointers[set_number] == 1:
                last_element_pointers[set_number] -= 1
            else:
                last_element_pointers[set_number] += 1

            row[last_element_pointers[set_number]] = block_number

            return "M"

        elif block_number in row:
            return "H"


def show_help_maybe():
    if len(sys.argv) == 1 or "-h" in sys.argv:
        print("Usage: ")
        print("\t-t: \n\t\ttest mode - work with an example - no other parameter needed")
        print("\t-f filename: \n\t\tfile mode - import data from a json file - you shall pass the filename")
        print("\t-h: \n\t\thelp mode - you are reading this!")
        exit(0)


def print_debug(grid):
    """
    prints a matrix, just for debug
    :param grid:
    :return: nothing
    """
    for row in grid:
        print(row)


if __name__ == '__main__':
    main()
