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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.FastDataListView_ObjectsToControl = new BrightIdeasSoftware.FastDataListView();
            this.olvColumn_Name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_Status = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_Action = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.hotItemStyle1 = new BrightIdeasSoftware.HotItemStyle();
            this.checkBoxCheckboxes = new System.Windows.Forms.CheckBox();
            this.checkBoxGroups = new System.Windows.Forms.CheckBox();
            this.comboBoxEditable = new System.Windows.Forms.ComboBox();
            this.comboBoxView = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.FastDataListView_ObjectsToControl)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            this.FastDataListView_ObjectsToControl.HotItemStyle = this.hotItemStyle1;
            this.FastDataListView_ObjectsToControl.Location = new System.Drawing.Point(3, 60);
            this.FastDataListView_ObjectsToControl.Name = "FastDataListView_ObjectsToControl";
            this.FastDataListView_ObjectsToControl.ShowGroups = false;
            this.FastDataListView_ObjectsToControl.Size = new System.Drawing.Size(696, 408);
            this.FastDataListView_ObjectsToControl.TabIndex = 1;
            this.FastDataListView_ObjectsToControl.UseAlternatingBackColors = true;
            this.FastDataListView_ObjectsToControl.UseCompatibleStateImageBehavior = false;
            this.FastDataListView_ObjectsToControl.UseHotItem = true;
            this.FastDataListView_ObjectsToControl.View = System.Windows.Forms.View.Details;
            this.FastDataListView_ObjectsToControl.VirtualMode = true;
            this.FastDataListView_ObjectsToControl.ButtonClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.FastDataListView_ObjectsToControl_ButtonClick);
            // 
            // olvColumn_Name
            // 
            this.olvColumn_Name.AspectName = "Name";
            this.olvColumn_Name.Text = "Name";
            // 
            // olvColumn_Status
            // 
            this.olvColumn_Status.AspectName = "Status";
            this.olvColumn_Status.Text = "Status";
            this.olvColumn_Status.WordWrap = true;
            // 
            // olvColumn_Action
            // 
            this.olvColumn_Action.AspectName = "Action";
            this.olvColumn_Action.ButtonSize = new System.Drawing.Size(60, 20);
            this.olvColumn_Action.ButtonSizing = BrightIdeasSoftware.OLVColumn.ButtonSizingMode.CellBounds;
            this.olvColumn_Action.EnableButtonWhenItemIsDisabled = true;
            this.olvColumn_Action.HeaderForeColor = System.Drawing.Color.Black;
            this.olvColumn_Action.MinimumWidth = 40;
            this.olvColumn_Action.Text = "Action";
            // 
            // hotItemStyle1
            // 
            this.hotItemStyle1.BackColor = System.Drawing.Color.Lime;
            this.hotItemStyle1.ForeColor = System.Drawing.Color.Black;
            // 
            // checkBoxCheckboxes
            // 
            this.checkBoxCheckboxes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxCheckboxes.Checked = true;
            this.checkBoxCheckboxes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCheckboxes.Location = new System.Drawing.Point(69, 475);
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
            this.checkBoxGroups.Location = new System.Drawing.Point(1, 475);
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
            this.comboBoxEditable.Location = new System.Drawing.Point(256, 474);
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
            this.comboBoxView.Location = new System.Drawing.Point(388, 474);
            this.comboBoxView.Name = "comboBoxView";
            this.comboBoxView.Size = new System.Drawing.Size(83, 21);
            this.comboBoxView.TabIndex = 37;
            this.comboBoxView.SelectedIndexChanged += new System.EventHandler(this.comboBoxView_SelectedIndexChanged);
            // 
            // ListViewObjectsToControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.checkBoxCheckboxes);
            this.Controls.Add(this.checkBoxGroups);
            this.Controls.Add(this.comboBoxEditable);
            this.Controls.Add(this.comboBoxView);
            this.Controls.Add(this.FastDataListView_ObjectsToControl);
            this.Name = "ListViewObjectsToControl";
            this.Size = new System.Drawing.Size(702, 496);
            this.Load += new System.EventHandler(this.ListViewObjectsToControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FastDataListView_ObjectsToControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private BrightIdeasSoftware.FastDataListView FastDataListView_ObjectsToControl;
        private BrightIdeasSoftware.OLVColumn olvColumn_Name;
        private BrightIdeasSoftware.OLVColumn olvColumn_Status;
        private BrightIdeasSoftware.OLVColumn olvColumn_Action;
        private System.Windows.Forms.CheckBox checkBoxCheckboxes;
        private System.Windows.Forms.CheckBox checkBoxGroups;
        private System.Windows.Forms.ComboBox comboBoxEditable;
        private System.Windows.Forms.ComboBox comboBoxView;
        private BrightIdeasSoftware.HotItemStyle hotItemStyle1;
    }
}
