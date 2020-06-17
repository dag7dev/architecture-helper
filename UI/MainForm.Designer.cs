namespace MeiSolver
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tabs = new System.Windows.Forms.TabControl();
            this.hitMissTab = new System.Windows.Forms.TabPage();
            this.hitMissAddresses1 = new MeiSolver.UI.HitMissAddresses();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pipeLineDrawer1 = new MeiSolver.UI.PipeLineDrawer();
            this.runButton = new System.Windows.Forms.Button();
            this.Tabs.SuspendLayout();
            this.hitMissTab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tabs.Controls.Add(this.tabPage2);
            this.Tabs.Controls.Add(this.hitMissTab);
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1056, 675);
            this.Tabs.TabIndex = 0;
            // 
            // hitMissTab
            // 
            this.hitMissTab.Controls.Add(this.hitMissAddresses1);
            this.hitMissTab.Location = new System.Drawing.Point(4, 22);
            this.hitMissTab.Name = "hitMissTab";
            this.hitMissTab.Padding = new System.Windows.Forms.Padding(3);
            this.hitMissTab.Size = new System.Drawing.Size(1048, 649);
            this.hitMissTab.TabIndex = 0;
            this.hitMissTab.Text = "Address Hit/Miss";
            this.hitMissTab.UseVisualStyleBackColor = true;
            // 
            // hitMissAddresses1
            // 
            this.hitMissAddresses1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hitMissAddresses1.Location = new System.Drawing.Point(3, 3);
            this.hitMissAddresses1.Name = "hitMissAddresses1";
            this.hitMissAddresses1.Size = new System.Drawing.Size(1042, 643);
            this.hitMissAddresses1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pipeLineDrawer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1048, 649);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "pipelineDrawerTab";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pipeLineDrawer1
            // 
            this.pipeLineDrawer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pipeLineDrawer1.Location = new System.Drawing.Point(3, 3);
            this.pipeLineDrawer1.Name = "pipeLineDrawer1";
            this.pipeLineDrawer1.Size = new System.Drawing.Size(1042, 643);
            this.pipeLineDrawer1.TabIndex = 0;
            // 
            // runButton
            // 
            this.runButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.runButton.Location = new System.Drawing.Point(0, 677);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(1056, 27);
            this.runButton.TabIndex = 11;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runHitMissAddress_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 704);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.Tabs);
            this.Name = "Form1";
            this.Text = "MeiSolver";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Tabs.ResumeLayout(false);
            this.hitMissTab.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage hitMissTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button runButton;
        private UI.HitMissAddresses hitMissAddresses1;
        private UI.PipeLineDrawer pipeLineDrawer1;
    }
}

