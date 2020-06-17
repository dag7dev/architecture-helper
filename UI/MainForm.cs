using MeiSolver.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeiSolver {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void runHitMissAddress_Click(object sender, EventArgs e) {
            ((Runnable)Tabs.SelectedTab.Controls[0]).Run();
        }

        private void Form1_Load(object sender, EventArgs e) {
            runButton.PerformClick();
        }

    }
}
