namespace ObjectListViewTools2020.Controllers
{
    partial class ListViewObjectsToControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FastDataListView_ObjectsToControl = new BrightIdeasSoftware.FastDataListView();
            this.olvColumn_Name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_Status = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_Action = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.checkBoxCheckboxes = new System.Windows.Forms.CheckBox();
            this.checkBoxGroups = new System.Windows.Forms.CheckBox();
            this.comboBoxEditable = new System.Windows.Forms.ComboBox();
            this.comboBoxView = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip_StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.comboBoxFilterType = new System.Windows.Forms.ComboBox();
            this.textBoxFilterFast = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.FastDataListView_ObjectsToControl)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // FastDataListView_ObjectsToControl
            // 
            this.FastDataListView_ObjectsToControl.AllColumns.Add(this.olvColumn_Name);
            this.FastDataListView_ObjectsToControl.AllColumns.Add(this.olvColumn_Status);
            this.FastDataListView_ObjectsToControl.AllColumns.Add(this.olvColumn_Action);
            this.FastDataListView_ObjectsToControl.AlternateRowBackColor = System.Drawing.Color.Aqua;
            this.FastDataListView_ObjectsToControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FastDataListView_ObjectsToControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FastDataListView_ObjectsToControl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn_Name,
            this.olvColumn_Status,
            this.olvColumn_Action});
            this.FastDataListView_ObjectsToControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.FastDataListView_ObjectsToControl.DataSource = null;
            this.FastDataListView_ObjectsToControl.EmptyListMsg = "No Itmes";
            this.FastDataListView_ObjectsToControl.GridLines = true;
            this.FastDataListView_ObjectsToControl.HideSelection = false;
            this.FastDataListView_ObjectsToControl.Location = new System.Drawing.Point(1, 47);
            this.FastDataListView_ObjectsToControl.Name = "FastDataListView_ObjectsToControl";
            this.FastDataListView_ObjectsToControl.ShowGroups = false;
            this.FastDataListView_ObjectsToControl.Size = new System.Drawing.Size(698, 397);
            this.FastDataListView_ObjectsToControl.TabIndex = 1;
            this.FastDataListView_ObjectsToControl.UseAlternatingBackColors = true;
            this.FastDataListView_ObjectsToControl.UseCompatibleStateImageBehavior = false;
            this.FastDataListView_ObjectsToControl.UseHotControls = false;
            this.FastDataListView_ObjectsToControl.UseOverlays = false;
            this.FastDataListView_ObjectsToControl.View = System.Windows.Forms.View.Details;
            this.FastDataListView_ObjectsToControl.VirtualMode = true;
            this.FastDataListView_ObjectsToControl.ButtonClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.FastDataListView_ObjectsToControl_ButtonClick);
            // 
            // olvColumn_Name
            // 
            this.olvColumn_Name.AspectName = "Name";
            this.olvColumn_Name.Text = "Name";
            this.olvColumn_Name.Width = 200;
            // 
            // olvColumn_Status
            // 
            this.olvColumn_Status.AspectName = "Status";
            this.olvColumn_Status.Text = "Status";
            this.olvColumn_Status.Width = 200;
            // 
            // olvColumn_Action
            // 
            this.olvColumn_Action.AspectName = "Action";
            this.olvColumn_Action.ButtonSize = new System.Drawing.Size(60, 20);
            this.olvColumn_Action.ButtonSizing = BrightIdeasSoftware.OLVColumn.ButtonSizingMode.CellBounds;
            this.olvColumn_Action.EnableButtonWhenItemIsDisabled = true;
            this.olvColumn_Action.HeaderForeColor = System.Drawing.Color.Black;
            this.olvColumn_Action.IsButton = true;
            this.olvColumn_Action.MinimumWidth = 40;
            this.olvColumn_Action.Text = "Action";
            this.olvColumn_Action.Width = 100;
            // 
            // checkBoxCheckboxes
            // 
            this.checkBoxCheckboxes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxCheckboxes.Location = new System.Drawing.Point(71, 450);
            this.checkBoxCheckboxes.Name = "checkBoxCheckboxes";
            this.checkBoxCheckboxes.Size = new System.Drawing.Size(87, 21);
            this.checkBoxCheckboxes.TabIndex = 39;
            this.checkBoxCheckboxes.Text = "Check&boxes";
            this.checkBoxCheckboxes.UseVisualStyleBackColor = true;
            this.checkBoxCheckboxes.CheckedChanged += new System.EventHandler(this.checkBoxCheckboxes_CheckedChanged);
            // 
            // checkBoxGroups
            // 
            this.checkBoxGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxGroups.Location = new System.Drawing.Point(3, 450);
            this.checkBoxGroups.Name = "checkBoxGroups";
            this.checkBoxGroups.Size = new System.Drawing.Size(60, 21);
            this.checkBoxGroups.TabIndex = 38;
            this.checkBoxGroups.Text = "&Groups";
            this.checkBoxGroups.UseVisualStyleBackColor = true;
            this.checkBoxGroups.CheckedChanged += new System.EventHandler(this.checkBoxGroups_CheckedChanged);
            // 
            // comboBoxEditable
            // 
            this.comboBoxEditable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxEditable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEditable.FormattingEnabled = true;
            this.comboBoxEditable.Items.AddRange(new object[] {
            "No",
            "Single Click",
            "Double Click",
            "F2 Only"});
            this.comboBoxEditable.Location = new System.Drawing.Point(164, 450);
            this.comboBoxEditable.Name = "comboBoxEditable";
            this.comboBoxEditable.Size = new System.Drawing.Size(83, 21);
            this.comboBoxEditable.TabIndex = 36;
            this.comboBoxEditable.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditable_SelectedIndexChanged);
            // 
            // comboBoxView
            // 
            this.comboBoxView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxView.FormattingEnabled = true;
            this.comboBoxView.Items.AddRange(new object[] {
            "Small Icon",
            "Large Icon",
            "List",
            "Tile",
            "Details"});
            this.comboBoxView.Location = new System.Drawing.Point(296, 450);
            this.comboBoxView.Name = "comboBoxView";
            this.comboBoxView.Size = new System.Drawing.Size(83, 21);
            this.comboBoxView.TabIndex = 37;
            this.comboBoxView.SelectedIndexChanged += new System.EventHandler(this.comboBoxView_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 475);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(702, 21);
            this.statusStrip1.TabIndex = 40;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip_StatusLabel
            // 
            this.toolStrip_StatusLabel.Name = "toolStrip_StatusLabel";
            this.toolStrip_StatusLabel.Size = new System.Drawing.Size(46, 16);
            this.toolStrip_StatusLabel.Text = "Loaded";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.comboBoxFilterType);
            this.groupBox11.Controls.Add(this.textBoxFilterFast);
            this.groupBox11.Location = new System.Drawing.Point(2, 1);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(214, 45);
            this.groupBox11.TabIndex = 41;
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
            // ListViewObjectsToControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.checkBoxCheckboxes);
            this.Controls.Add(this.checkBoxGroups);
            this.Controls.Add(this.comboBoxEditable);
            this.Controls.Add(this.comboBoxView);
            this.Controls.Add(this.FastDataListView_ObjectsToControl);
            this.Name = "ListViewObjectsToControl";
            this.Size = new System.Drawing.Size(702, 496);
            this.Load += new System.EventHandler(this.ListViewObjectsToControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FastDataListView_ObjectsToControl)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private BrightIdeasSoftware.FastDataListView FastDataListView_ObjectsToControl;
        private BrightIdeasSoftware.OLVColumn olvColumn_Name;
        private BrightIdeasSoftware.OLVColumn olvColumn_Status;
        private BrightIdeasSoftware.OLVColumn olvColumn_Action;
        private System.Windows.Forms.CheckBox checkBoxCheckboxes;
        private System.Windows.Forms.CheckBox checkBoxGroups;
        private System.Windows.Forms.ComboBox comboBoxEditable;
        private System.Windows.Forms.ComboBox comboBoxView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStrip_StatusLabel;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.ComboBox comboBoxFilterType;
        private System.Windows.Forms.TextBox textBoxFilterFast;
    }
}
