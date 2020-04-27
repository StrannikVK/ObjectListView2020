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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataListView1 = new BrightIdeasSoftware.DataListView();
            this.olvColumnName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_Statu = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnAction = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.comboBoxFilterType = new System.Windows.Forms.ComboBox();
            this.textBoxFilterFast = new System.Windows.Forms.TextBox();
            this.listViewObjectsToControl1 = new ObjectListViewTools2020.Controllers.ListViewObjectsToControl();
            this.tabControl1.SuspendLayout();
            this.tabPage_Objects.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListView1)).BeginInit();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage_Objects);
            this.tabControl1.Controls.Add(this.tabPage1);
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox11);
            this.tabPage1.Controls.Add(this.dataListView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(931, 421);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Debug 2 Still not working";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataListView1
            // 
            this.dataListView1.AllColumns.Add(this.olvColumnName);
            this.dataListView1.AllColumns.Add(this.olvColumn_Statu);
            this.dataListView1.AllColumns.Add(this.olvColumnAction);
            this.dataListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnName,
            this.olvColumn_Statu,
            this.olvColumnAction});
            this.dataListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataListView1.DataSource = null;
            this.dataListView1.GridLines = true;
            this.dataListView1.HideSelection = false;
            this.dataListView1.Location = new System.Drawing.Point(9, 83);
            this.dataListView1.Name = "dataListView1";
            this.dataListView1.Size = new System.Drawing.Size(916, 332);
            this.dataListView1.TabIndex = 0;
            this.dataListView1.UseCompatibleStateImageBehavior = false;
            this.dataListView1.View = System.Windows.Forms.View.Details;
            // 
            // olvColumnName
            // 
            this.olvColumnName.AspectName = "Name";
            this.olvColumnName.Text = "Name";
            this.olvColumnName.Width = 300;
            // 
            // olvColumn_Statu
            // 
            this.olvColumn_Statu.AspectName = "Status";
            this.olvColumn_Statu.Text = "Status";
            this.olvColumn_Statu.Width = 100;
            // 
            // olvColumnAction
            // 
            this.olvColumnAction.AspectName = "Action";
            this.olvColumnAction.IsButton = true;
            this.olvColumnAction.Text = "Action";
            this.olvColumnAction.Width = 200;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.comboBoxFilterType);
            this.groupBox11.Controls.Add(this.textBoxFilterFast);
            this.groupBox11.Location = new System.Drawing.Point(9, 17);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(214, 45);
            this.groupBox11.TabIndex = 42;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Filter";
            // 
            // comboBoxFilterType
            // 
            this.comboBoxFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilterType.FormattingEnabled = true;
            this.comboBoxFilterType.Items.AddRange(new object[] {
            "Any text",
            "Prefix",
            "Regex"});
            this.comboBoxFilterType.Location = new System.Drawing.Point(114, 18);
            this.comboBoxFilterType.Name = "comboBoxFilterType";
            this.comboBoxFilterType.Size = new System.Drawing.Size(94, 21);
            this.comboBoxFilterType.TabIndex = 1;
            // 
            // textBoxFilterFast
            // 
            this.textBoxFilterFast.Location = new System.Drawing.Point(7, 18);
            this.textBoxFilterFast.Name = "textBoxFilterFast";
            this.textBoxFilterFast.Size = new System.Drawing.Size(100, 20);
            this.textBoxFilterFast.TabIndex = 0;
            this.textBoxFilterFast.TextChanged += new System.EventHandler(this.textBoxFilterFast_TextChanged);
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
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataListView1)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Objects;
        private Controllers.ListViewObjectsToControl listViewObjectsToControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private BrightIdeasSoftware.DataListView dataListView1;
        private BrightIdeasSoftware.OLVColumn olvColumnName;
        private BrightIdeasSoftware.OLVColumn olvColumn_Statu;
        private BrightIdeasSoftware.OLVColumn olvColumnAction;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.ComboBox comboBoxFilterType;
        private System.Windows.Forms.TextBox textBoxFilterFast;
    }
}

