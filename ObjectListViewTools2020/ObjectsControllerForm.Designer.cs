namespace ObjectListViewTools2020
{
    partial class ObjectsControllerForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Objects = new System.Windows.Forms.TabPage();
            this.listViewObjectsToControl1 = new ObjectListViewTools2020.Controllers.ListViewObjectsToControl();
            this.tabControl1.SuspendLayout();
            this.tabPage_Objects.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage_Objects);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(939, 447);
            this.tabControl1.TabIndex = 38;
            // 
            // tabPage_Objects
            // 
            this.tabPage_Objects.Controls.Add(this.listViewObjectsToControl1);
            this.tabPage_Objects.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Objects.Name = "tabPage_Objects";
            this.tabPage_Objects.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Objects.Size = new System.Drawing.Size(931, 421);
            this.tabPage_Objects.TabIndex = 0;
            this.tabPage_Objects.Text = "Objects";
            this.tabPage_Objects.UseVisualStyleBackColor = true;
            // 
            // listViewObjectsToControl1
            // 
            this.listViewObjectsToControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewObjectsToControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.listViewObjectsToControl1.Location = new System.Drawing.Point(3, 6);
            this.listViewObjectsToControl1.Name = "listViewObjectsToControl1";
            this.listViewObjectsToControl1.Size = new System.Drawing.Size(920, 409);
            this.listViewObjectsToControl1.TabIndex = 0;
            // 
            // ObjectsControllerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "ObjectsControllerForm";
            this.Text = "Object Controller Status Of Objects";
            this.Load += new System.EventHandler(this.ObjectsControllerForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Objects.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Objects;
        private Controllers.ListViewObjectsToControl listViewObjectsToControl1;
    }
}

