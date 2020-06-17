namespace MeiSolver.UI {
    partial class HitMissAddresses {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addressesLabel = new System.Windows.Forms.Label();
            this.addressesTextBox = new System.Windows.Forms.TextBox();
            this.waysLabel = new System.Windows.Forms.Label();
            this.blockSize = new System.Windows.Forms.NumericUpDown();
            this.setsLabel = new System.Windows.Forms.Label();
            this.cacheSets = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cacheWays = new System.Windows.Forms.NumericUpDown();
            this.result = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blockSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cacheSets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cacheWays)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Result";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.addressesLabel);
            this.groupBox1.Controls.Add(this.addressesTextBox);
            this.groupBox1.Controls.Add(this.waysLabel);
            this.groupBox1.Controls.Add(this.blockSize);
            this.groupBox1.Controls.Add(this.setsLabel);
            this.groupBox1.Controls.Add(this.cacheSets);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cacheWays);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 122);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input:";
            // 
            // addressesLabel
            // 
            this.addressesLabel.AutoSize = true;
            this.addressesLabel.Location = new System.Drawing.Point(6, 16);
            this.addressesLabel.Name = "addressesLabel";
            this.addressesLabel.Size = new System.Drawing.Size(59, 13);
            this.addressesLabel.TabIndex = 1;
            this.addressesLabel.Text = "Addresses:";
            // 
            // addresses
            // 
            this.addressesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressesTextBox.Location = new System.Drawing.Point(116, 13);
            this.addressesTextBox.Name = "addresses";
            this.addressesTextBox.Size = new System.Drawing.Size(256, 20);
            this.addressesTextBox.TabIndex = 0;
            this.addressesTextBox.Text = "[24, 64, 164, 32, 208, 128, 44, 192, 432, 452, 88, 212, 504, 384, 32, 52, 292, 23" +
    "2, 388, 400, 404, 288, 40, 376]";
            // 
            // waysLabel
            // 
            this.waysLabel.AutoSize = true;
            this.waysLabel.Location = new System.Drawing.Point(6, 41);
            this.waysLabel.Name = "waysLabel";
            this.waysLabel.Size = new System.Drawing.Size(104, 13);
            this.waysLabel.TabIndex = 3;
            this.waysLabel.Text = "Cache Type (Ways):";
            // 
            // blockSize
            // 
            this.blockSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blockSize.Location = new System.Drawing.Point(116, 94);
            this.blockSize.Name = "blockSize";
            this.blockSize.Size = new System.Drawing.Size(256, 20);
            this.blockSize.TabIndex = 10;
            this.blockSize.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // setsLabel
            // 
            this.setsLabel.AutoSize = true;
            this.setsLabel.Location = new System.Drawing.Point(6, 67);
            this.setsLabel.Name = "setsLabel";
            this.setsLabel.Size = new System.Drawing.Size(65, 13);
            this.setsLabel.TabIndex = 5;
            this.setsLabel.Text = "Cache Sets:";
            // 
            // cacheSets
            // 
            this.cacheSets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cacheSets.Location = new System.Drawing.Point(116, 65);
            this.cacheSets.Name = "cacheSets";
            this.cacheSets.Size = new System.Drawing.Size(256, 20);
            this.cacheSets.TabIndex = 9;
            this.cacheSets.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Addresses:";
            // 
            // cacheWays
            // 
            this.cacheWays.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cacheWays.Location = new System.Drawing.Point(116, 39);
            this.cacheWays.Name = "cacheWays";
            this.cacheWays.Size = new System.Drawing.Size(256, 20);
            this.cacheWays.TabIndex = 8;
            this.cacheWays.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // hitMissResult
            // 
            this.result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(3, 149);
            this.result.Multiline = true;
            this.result.Name = "hitMissResult";
            this.result.Size = new System.Drawing.Size(378, 108);
            this.result.TabIndex = 18;
            // 
            // HitMissAddresses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.result);
            this.Name = "HitMissAddresses";
            this.Size = new System.Drawing.Size(384, 260);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blockSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cacheSets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cacheWays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label addressesLabel;
        private System.Windows.Forms.TextBox addressesTextBox;
        private System.Windows.Forms.Label waysLabel;
        private System.Windows.Forms.NumericUpDown blockSize;
        private System.Windows.Forms.Label setsLabel;
        private System.Windows.Forms.NumericUpDown cacheSets;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown cacheWays;
        private System.Windows.Forms.TextBox result;
    }
}
