using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeiSolver.BackEnd;

namespace MeiSolver.UI {
    public partial class HitMissAddresses : UserControl, Runnable {
        public HitMissAddresses() {
            InitializeComponent();
        }

        public void Run() {
            outputClear();

            //input data
            int cache_type = decimal.ToInt32(cacheWays.Value);
            int cache_sets = decimal.ToInt32(cacheSets.Value);
            int cache_block_size = decimal.ToInt32(blockSize.Value);

            List<int> addresses = formatAddressList(addressesTextBox.Text);

            //preparing for simulation
            CacheSimulator cache = new CacheSimulator(blocks: cache_sets, blockSize: cache_block_size, ways: cache_type);

            int hits = 0, misses = 0;

            bool hit;
            int memBlock, cacheBlock, wayIndex;
            print("ADDRESS\tBLOCK\tSET\tHIT/MISS");
            
            //running simulation
            foreach (var address in addresses) {
                (hit, memBlock, cacheBlock, wayIndex) = cache.find(address);
                if (hit) {
                    hits++;
                } else {
                    misses++;
                }

                string wayIndexStr = cache_type == 1 ? "" : $"[{wayIndex}]";
                print($"{address}\t{memBlock}\t{cacheBlock}{wayIndexStr}\t{(hit ? "Hit" : "Miss")}");
            }

            print($"HITS: {hits} MISSES: {misses}");
        }

        private void outputClear() {
            result.Text = "";
        }

        private void print(string text, string end = "\r\n") {
            result.Text += text + end; 
        }

        List<int> formatAddressList(string address_list_string) {
            List<int> addresses = new List<int>();
            bool lastWasNumeric = false;
            string buffer = "";

            foreach (char character in address_list_string) {
                if (char.IsDigit(character)){
                    buffer += character;
                    lastWasNumeric = true;
                } else {
                    if (lastWasNumeric) { 
                        addresses.Add(int.Parse(buffer));
                        buffer = "";
                    }
                    lastWasNumeric = false;
                }
            }


            if (lastWasNumeric) {
                addresses.Add(int.Parse(buffer));
            }

            return addresses;
        }
    
    }
}
