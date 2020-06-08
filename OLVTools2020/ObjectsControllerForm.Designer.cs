using BrightIdeasSoftware;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace OLVTools2020
{
	partial class ObjectsControllerForm : System.Windows.Forms.Form
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:DoNotPassLiteralsAsLocalizedParameters", MessageId = "System.Windows.Forms.Control.set_Text(System.String)")]
		private void InitializeComponent()
		{
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDescribedTasks = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.olvForecastCNNControl1 = new OLVTools2020.OLVForecastCNNControl();
            this.olvmSymbolsControl21 = new OLVTools2020.OLVMSymbolsControl2();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.olvMarketSymbolControl1 = new OLVTools2020.OLVYahooControl();
            this.tabControl1.SuspendLayout();
            this.tabDescribedTasks.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(897, 17);
            this.toolStripStatusLabel3.Spring = true;
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDescribedTasks);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(912, 566);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabDescribedTasks
            // 
            this.tabDescribedTasks.Controls.Add(this.olvMarketSymbolControl1);
            this.tabDescribedTasks.Location = new System.Drawing.Point(4, 22);
            this.tabDescribedTasks.Name = "tabDescribedTasks";
            this.tabDescribedTasks.Padding = new System.Windows.Forms.Padding(3);
            this.tabDescribedTasks.Size = new System.Drawing.Size(904, 540);
            this.tabDescribedTasks.TabIndex = 18;
            this.tabDescribedTasks.Text = "Pretty Tasks";
            this.tabDescribedTasks.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.olvForecastCNNControl1);
            this.tabPage1.Controls.Add(this.olvmSymbolsControl21);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(904, 540);
            this.tabPage1.TabIndex = 19;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // olvForecastCNNControl1
            // 
            this.olvForecastCNNControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.olvForecastCNNControl1.Location = new System.Drawing.Point(454, 56);
            this.olvForecastCNNControl1.Name = "olvForecastCNNControl1";
            this.olvForecastCNNControl1.Size = new System.Drawing.Size(629, 497);
            this.olvForecastCNNControl1.TabIndex = 1;
            // 
            // olvmSymbolsControl21
            // 
            this.olvmSymbolsControl21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.olvmSymbolsControl21.Location = new System.Drawing.Point(95, 31);
            this.olvmSymbolsControl21.Name = "olvmSymbolsControl21";
            this.olvmSymbolsControl21.Size = new System.Drawing.Size(341, 426);
            this.olvmSymbolsControl21.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(0, 0);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(200, 100);
            this.tabPage7.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 544);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(912, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // olvMarketSymbolControl1
            // 
            this.olvMarketSymbolControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.olvMarketSymbolControl1.Location = new System.Drawing.Point(36, 22);
            this.olvMarketSymbolControl1.Name = "olvMarketSymbolControl1";
            this.olvMarketSymbolControl1.Size = new System.Drawing.Size(387, 313);
            this.olvMarketSymbolControl1.TabIndex = 0;
            // 
            // ObjectsControllerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 566);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "ObjectsControllerForm";
            this.Text = "ObjectListView Demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabDescribedTasks.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.StatusStrip statusStrip1;

        private System.Windows.Forms.TabControl tabControl1;
        private TabPage tabPage7;
        public ToolStripStatusLabel toolStripStatusLabel3;
        public ToolStripStatusLabel toolStripStatusLabel1;
        private TabPage tabDescribedTasks;
        private TabPage tabPage1;
        private OLVMSymbolsControl2 olvmSymbolsControl21;
        private OLVForecastCNNControl olvForecastCNNControl1;
        private OLVYahooControl olvMarketSymbolControl1;
    }
}
