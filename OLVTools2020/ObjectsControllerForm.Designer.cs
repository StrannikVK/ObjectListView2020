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
            this.olvSymbolsControl1 = new OLVTools2020.OLVSymbolsControl();
            this.SuspendLayout();
            // 
            // olvSymbolsControl1
            // 
            this.olvSymbolsControl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.olvSymbolsControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.olvSymbolsControl1.Location = new System.Drawing.Point(12, 40);
            this.olvSymbolsControl1.Name = "olvSymbolsControl1";
            this.olvSymbolsControl1.Size = new System.Drawing.Size(792, 497);
            this.olvSymbolsControl1.TabIndex = 0;
            // 
            // ObjectsControllerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 566);
            this.Controls.Add(this.olvSymbolsControl1);
            this.Name = "ObjectsControllerForm";
            this.Text = "ObjectListView Demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

		private OLVSymbolsControl olvSymbolsControl1;
	}
}
