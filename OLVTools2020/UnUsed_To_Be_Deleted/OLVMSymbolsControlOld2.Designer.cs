namespace OLVTools2020
{
    partial class OLVMSymbolsControl2
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
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label auto_StartLabel;
            System.Windows.Forms.Label synchronousLabel;
            System.Windows.Forms.Label status_Check_IntervalLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OLVMSymbolsControl2));
            this.olvColumnAction = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.checkBox_LowPotential = new System.Windows.Forms.CheckBox();
            this.status_Check_IntervalTextBox = new System.Windows.Forms.TextBox();
            this.objectToControlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkBox_HighPotential = new System.Windows.Forms.CheckBox();
            this.auto_StartCheckBox1 = new System.Windows.Forms.CheckBox();
            this.synchronousCheckBox = new System.Windows.Forms.CheckBox();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.checkBoxGroups = new System.Windows.Forms.CheckBox();
            this.checkBoxCheckboxes = new System.Windows.Forms.CheckBox();
            this.imageListTasks = new System.Windows.Forms.ImageList(this.components);
            this.OLV_Objects = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn_Name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnStatus = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_Log_Last = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_Description = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_Auto_Start = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_Potential = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.hotItemStyle1 = new BrightIdeasSoftware.HotItemStyle();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_List_DataTree = new System.Windows.Forms.TabPage();
            this.olvDataTree = new BrightIdeasSoftware.DataTreeListView();
            this.olvColumn_Symbol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabPage_List_with_Actions = new System.Windows.Forms.TabPage();
            this.tabPage_DataGridView = new System.Windows.Forms.TabPage();
            this.dataGridView_Symbols = new System.Windows.Forms.DataGridView();
            this.tabPage_Properties = new System.Windows.Forms.TabPage();
            this.button_Enable_Edit = new System.Windows.Forms.Button();
            this.button_Status_Refresh = new System.Windows.Forms.Button();
            this.propertyGrid_Selected_Object = new System.Windows.Forms.PropertyGrid();
            this.button_Action = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            notesLabel = new System.Windows.Forms.Label();
            auto_StartLabel = new System.Windows.Forms.Label();
            synchronousLabel = new System.Windows.Forms.Label();
            status_Check_IntervalLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectToControlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OLV_Objects)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage_List_DataTree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvDataTree)).BeginInit();
            this.tabPage_List_with_Actions.SuspendLayout();
            this.tabPage_DataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Symbols)).BeginInit();
            this.tabPage_Properties.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(0, 3);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(38, 13);
            notesLabel.TabIndex = 7;
            notesLabel.Text = "Notes:";
            // 
            // auto_StartLabel
            // 
            auto_StartLabel.AutoSize = true;
            auto_StartLabel.Location = new System.Drawing.Point(236, 26);
            auto_StartLabel.Name = "auto_StartLabel";
            auto_StartLabel.Size = new System.Drawing.Size(57, 13);
            auto_StartLabel.TabIndex = 0;
            auto_StartLabel.Text = "Auto Start:";
            // 
            // synchronousLabel
            // 
            synchronousLabel.AutoSize = true;
            synchronousLabel.Location = new System.Drawing.Point(236, 11);
            synchronousLabel.Name = "synchronousLabel";
            synchronousLabel.Size = new System.Drawing.Size(72, 13);
            synchronousLabel.TabIndex = 2;
            synchronousLabel.Text = "Synchronous:";
            // 
            // status_Check_IntervalLabel
            // 
            status_Check_IntervalLabel.AutoSize = true;
            status_Check_IntervalLabel.Location = new System.Drawing.Point(314, 10);
            status_Check_IntervalLabel.Name = "status_Check_IntervalLabel";
            status_Check_IntervalLabel.Size = new System.Drawing.Size(112, 13);
            status_Check_IntervalLabel.TabIndex = 4;
            status_Check_IntervalLabel.Text = "Status Check Interval:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(-1, 27);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 5;
            statusLabel.Text = "Status:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(2, 6);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // olvColumnAction
            // 
            this.olvColumnAction.AspectName = "Action";
            this.olvColumnAction.Text = "Action";
            this.olvColumnAction.Width = 90;
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox9.Controls.Add(this.button_Refresh);
            this.groupBox9.Controls.Add(this.checkBox_LowPotential);
            this.groupBox9.Controls.Add(this.status_Check_IntervalTextBox);
            this.groupBox9.Controls.Add(this.checkBox_HighPotential);
            this.groupBox9.Controls.Add(this.auto_StartCheckBox1);
            this.groupBox9.Controls.Add(this.synchronousCheckBox);
            this.groupBox9.Controls.Add(this.textBoxFilter);
            this.groupBox9.Controls.Add(this.checkBoxGroups);
            this.groupBox9.Controls.Add(synchronousLabel);
            this.groupBox9.Controls.Add(auto_StartLabel);
            this.groupBox9.Controls.Add(this.checkBoxCheckboxes);
            this.groupBox9.Controls.Add(status_Check_IntervalLabel);
            this.groupBox9.Location = new System.Drawing.Point(3, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(561, 66);
            this.groupBox9.TabIndex = 40;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Filter";
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(7, 35);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(113, 23);
            this.button_Refresh.TabIndex = 3;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // checkBox_LowPotential
            // 
            this.checkBox_LowPotential.AutoSize = true;
            this.checkBox_LowPotential.Location = new System.Drawing.Point(126, 25);
            this.checkBox_LowPotential.Name = "checkBox_LowPotential";
            this.checkBox_LowPotential.Size = new System.Drawing.Size(90, 17);
            this.checkBox_LowPotential.TabIndex = 2;
            this.checkBox_LowPotential.Text = "Low Potential";
            this.checkBox_LowPotential.UseVisualStyleBackColor = true;
            this.checkBox_LowPotential.CheckedChanged += new System.EventHandler(this.checkBoxIncomplete_CheckedChanged);
            // 
            // status_Check_IntervalTextBox
            // 
            this.status_Check_IntervalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objectToControlBindingSource, "Status_Check_Interval", true));
            this.status_Check_IntervalTextBox.Location = new System.Drawing.Point(314, 22);
            this.status_Check_IntervalTextBox.Name = "status_Check_IntervalTextBox";
            this.status_Check_IntervalTextBox.Size = new System.Drawing.Size(60, 20);
            this.status_Check_IntervalTextBox.TabIndex = 5;
            // 
            // objectToControlBindingSource
            // 
            this.objectToControlBindingSource.DataSource = typeof(GenericTools.Controllers.ObjectToControl);
            // 
            // checkBox_HighPotential
            // 
            this.checkBox_HighPotential.AutoSize = true;
            this.checkBox_HighPotential.Location = new System.Drawing.Point(126, 10);
            this.checkBox_HighPotential.Name = "checkBox_HighPotential";
            this.checkBox_HighPotential.Size = new System.Drawing.Size(92, 17);
            this.checkBox_HighPotential.TabIndex = 1;
            this.checkBox_HighPotential.Text = "&High Potential";
            this.checkBox_HighPotential.UseVisualStyleBackColor = true;
            this.checkBox_HighPotential.CheckedChanged += new System.EventHandler(this.checkBoxHighPriority_CheckedChanged);
            // 
            // auto_StartCheckBox1
            // 
            this.auto_StartCheckBox1.AutoSize = true;
            this.auto_StartCheckBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.objectToControlBindingSource, "Auto_Start", true));
            this.auto_StartCheckBox1.Location = new System.Drawing.Point(224, 25);
            this.auto_StartCheckBox1.Name = "auto_StartCheckBox1";
            this.auto_StartCheckBox1.Size = new System.Drawing.Size(15, 14);
            this.auto_StartCheckBox1.TabIndex = 1;
            this.auto_StartCheckBox1.UseVisualStyleBackColor = true;
            // 
            // synchronousCheckBox
            // 
            this.synchronousCheckBox.AutoSize = true;
            this.synchronousCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.objectToControlBindingSource, "Synchronous", true));
            this.synchronousCheckBox.Location = new System.Drawing.Point(224, 11);
            this.synchronousCheckBox.Name = "synchronousCheckBox";
            this.synchronousCheckBox.Size = new System.Drawing.Size(15, 14);
            this.synchronousCheckBox.TabIndex = 3;
            this.synchronousCheckBox.UseVisualStyleBackColor = true;
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(7, 13);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(113, 20);
            this.textBoxFilter.TabIndex = 0;
            this.textBoxFilter.Validated += new System.EventHandler(this.textBoxFilter_Validated);
            // 
            // checkBoxGroups
            // 
            this.checkBoxGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxGroups.Location = new System.Drawing.Point(126, 39);
            this.checkBoxGroups.Name = "checkBoxGroups";
            this.checkBoxGroups.Size = new System.Drawing.Size(60, 21);
            this.checkBoxGroups.TabIndex = 36;
            this.checkBoxGroups.Text = "&Groups";
            this.checkBoxGroups.UseVisualStyleBackColor = true;
            this.checkBoxGroups.CheckedChanged += new System.EventHandler(this.checkBoxGroups_CheckedChanged);
            // 
            // checkBoxCheckboxes
            // 
            this.checkBoxCheckboxes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxCheckboxes.Location = new System.Drawing.Point(224, 37);
            this.checkBoxCheckboxes.Name = "checkBoxCheckboxes";
            this.checkBoxCheckboxes.Size = new System.Drawing.Size(87, 21);
            this.checkBoxCheckboxes.TabIndex = 37;
            this.checkBoxCheckboxes.Text = "Check&boxes";
            this.checkBoxCheckboxes.UseVisualStyleBackColor = true;
            this.checkBoxCheckboxes.CheckedChanged += new System.EventHandler(this.checkBoxCheckboxes_CheckedChanged);
            // 
            // imageListTasks
            // 
            this.imageListTasks.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTasks.ImageStream")));
            this.imageListTasks.TransparentColor = System.Drawing.Color.Fuchsia;
            this.imageListTasks.Images.SetKeyName(0, "download");
            this.imageListTasks.Images.SetKeyName(1, "backandforth");
            this.imageListTasks.Images.SetKeyName(2, "faq");
            this.imageListTasks.Images.SetKeyName(3, "windows");
            this.imageListTasks.Images.SetKeyName(4, "filter");
            this.imageListTasks.Images.SetKeyName(5, "printer");
            this.imageListTasks.Images.SetKeyName(6, "electronics");
            this.imageListTasks.Images.SetKeyName(7, "film");
            // 
            // OLV_Objects
            // 
            this.OLV_Objects.AllColumns.Add(this.olvColumn_Name);
            this.OLV_Objects.AllColumns.Add(this.olvColumnStatus);
            this.OLV_Objects.AllColumns.Add(this.olvColumnAction);
            this.OLV_Objects.AllColumns.Add(this.olvColumn_Log_Last);
            this.OLV_Objects.AllColumns.Add(this.olvColumn_Description);
            this.OLV_Objects.AllColumns.Add(this.olvColumn_Auto_Start);
            this.OLV_Objects.AllColumns.Add(this.olvColumn_Potential);
            this.OLV_Objects.AllowColumnReorder = true;
            this.OLV_Objects.AllowDrop = true;
            this.OLV_Objects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OLV_Objects.CheckBoxes = true;
            this.OLV_Objects.CheckedAspectName = "";
            this.OLV_Objects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn_Name,
            this.olvColumnStatus,
            this.olvColumnAction,
            this.olvColumn_Log_Last,
            this.olvColumn_Description,
            this.olvColumn_Auto_Start,
            this.olvColumn_Potential});
            this.OLV_Objects.Cursor = System.Windows.Forms.Cursors.Default;
            this.OLV_Objects.FullRowSelect = true;
            this.OLV_Objects.GridLines = true;
            this.OLV_Objects.HeaderWordWrap = true;
            this.OLV_Objects.HideSelection = false;
            this.OLV_Objects.IncludeColumnHeadersInCopy = true;
            this.OLV_Objects.Location = new System.Drawing.Point(3, 75);
            this.OLV_Objects.Name = "OLV_Objects";
            this.OLV_Objects.OverlayText.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            this.OLV_Objects.OverlayText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.OLV_Objects.OverlayText.BorderWidth = 2F;
            this.OLV_Objects.OverlayText.Rotation = -20;
            this.OLV_Objects.OverlayText.Text = "";
            this.OLV_Objects.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.OLV_Objects.ShowCommandMenuOnRightClick = true;
            this.OLV_Objects.ShowGroups = false;
            this.OLV_Objects.ShowHeaderInAllViews = false;
            this.OLV_Objects.ShowItemToolTips = true;
            this.OLV_Objects.Size = new System.Drawing.Size(402, 475);
            this.OLV_Objects.SortGroupItemsByPrimaryColumn = false;
            this.OLV_Objects.TabIndex = 36;
            this.OLV_Objects.TriStateCheckBoxes = true;
            this.OLV_Objects.UseAlternatingBackColors = true;
            this.OLV_Objects.UseCellFormatEvents = true;
            this.OLV_Objects.UseCompatibleStateImageBehavior = false;
            this.OLV_Objects.UseFilterIndicator = true;
            this.OLV_Objects.UseFiltering = true;
            this.OLV_Objects.UseHotItem = true;
            this.OLV_Objects.View = System.Windows.Forms.View.Details;
            this.OLV_Objects.ButtonClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.OLV_Objects_ButtonClick);
            this.OLV_Objects.SelectedIndexChanged += new System.EventHandler(this.OLV_Objects_SelectedIndexChanged);
            // 
            // olvColumn_Name
            // 
            this.olvColumn_Name.AspectName = "Name";
            this.olvColumn_Name.MinimumWidth = 40;
            this.olvColumn_Name.Text = "Name";
            this.olvColumn_Name.ToolTipText = "";
            this.olvColumn_Name.Width = 150;
            // 
            // olvColumnStatus
            // 
            this.olvColumnStatus.AspectName = "Status";
            this.olvColumnStatus.IsTileViewColumn = true;
            this.olvColumnStatus.MinimumWidth = 30;
            this.olvColumnStatus.Text = "Status";
            this.olvColumnStatus.ToolTipText = "";
            this.olvColumnStatus.Width = 120;
            // 
            // olvColumn_Log_Last
            // 
            this.olvColumn_Log_Last.AspectName = "Log_Last";
            this.olvColumn_Log_Last.Text = "Log_Last";
            this.olvColumn_Log_Last.Width = 200;
            // 
            // olvColumn_Description
            // 
            this.olvColumn_Description.AspectName = "Description";
            this.olvColumn_Description.Text = "Description";
            this.olvColumn_Description.Width = 300;
            // 
            // olvColumn_Auto_Start
            // 
            this.olvColumn_Auto_Start.AspectName = "Auto_Start";
            this.olvColumn_Auto_Start.CheckBoxes = true;
            this.olvColumn_Auto_Start.Text = "Auto_Start";
            // 
            // olvColumn_Potential
            // 
            this.olvColumn_Potential.AspectName = "Potential";
            this.olvColumn_Potential.Text = "Potential";
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "Add");
            this.imageListSmall.Images.SetKeyName(1, "Cancel");
            this.imageListSmall.Images.SetKeyName(2, "Heart");
            this.imageListSmall.Images.SetKeyName(3, "Tick");
            this.imageListSmall.Images.SetKeyName(4, "Coin");
            this.imageListSmall.Images.SetKeyName(5, "Lamp");
            // 
            // hotItemStyle1
            // 
            this.hotItemStyle1.BackColor = System.Drawing.Color.Black;
            // 
            // statusTextBox
            // 
            this.statusTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objectToControlBindingSource, "Status", true));
            this.statusTextBox.Location = new System.Drawing.Point(38, 24);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(367, 20);
            this.statusTextBox.TabIndex = 6;
            // 
            // notesTextBox
            // 
            this.notesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objectToControlBindingSource, "Notes", true));
            this.notesTextBox.Location = new System.Drawing.Point(44, 3);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(520, 633);
            this.notesTextBox.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage_List_DataTree);
            this.tabControl1.Controls.Add(this.tabPage_List_with_Actions);
            this.tabControl1.Controls.Add(this.tabPage_DataGridView);
            this.tabControl1.Controls.Add(this.tabPage_Properties);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(419, 579);
            this.tabControl1.TabIndex = 42;
            // 
            // tabPage_List_DataTree
            // 
            this.tabPage_List_DataTree.AutoScroll = true;
            this.tabPage_List_DataTree.Controls.Add(this.olvDataTree);
            this.tabPage_List_DataTree.Location = new System.Drawing.Point(4, 22);
            this.tabPage_List_DataTree.Name = "tabPage_List_DataTree";
            this.tabPage_List_DataTree.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_List_DataTree.Size = new System.Drawing.Size(411, 553);
            this.tabPage_List_DataTree.TabIndex = 1;
            this.tabPage_List_DataTree.Text = "List DataTree";
            this.tabPage_List_DataTree.UseVisualStyleBackColor = true;
            // 
            // olvDataTree
            // 
            this.olvDataTree.AllColumns.Add(this.olvColumn_Symbol);
            this.olvDataTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olvDataTree.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn_Symbol});
            this.olvDataTree.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvDataTree.DataSource = null;
            this.olvDataTree.HideSelection = false;
            this.olvDataTree.KeyAspectName = "Id";
            this.olvDataTree.Location = new System.Drawing.Point(3, 45);
            this.olvDataTree.Name = "olvDataTree";
            this.olvDataTree.ParentKeyAspectName = "ParentId";
            this.olvDataTree.RootKeyValueString = "";
            this.olvDataTree.ShowGroups = false;
            this.olvDataTree.ShowKeyColumns = false;
            this.olvDataTree.Size = new System.Drawing.Size(402, 502);
            this.olvDataTree.TabIndex = 1;
            this.olvDataTree.UseCompatibleStateImageBehavior = false;
            this.olvDataTree.UseFilterIndicator = true;
            this.olvDataTree.UseFiltering = true;
            this.olvDataTree.View = System.Windows.Forms.View.Details;
            this.olvDataTree.VirtualMode = true;
            // 
            // olvColumn_Symbol
            // 
            this.olvColumn_Symbol.AspectName = "Symbol";
            this.olvColumn_Symbol.Text = "Symbol";
            this.olvColumn_Symbol.Width = 154;
            // 
            // tabPage_List_with_Actions
            // 
            this.tabPage_List_with_Actions.AutoScroll = true;
            this.tabPage_List_with_Actions.Controls.Add(this.groupBox9);
            this.tabPage_List_with_Actions.Controls.Add(this.OLV_Objects);
            this.tabPage_List_with_Actions.Location = new System.Drawing.Point(4, 22);
            this.tabPage_List_with_Actions.Name = "tabPage_List_with_Actions";
            this.tabPage_List_with_Actions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_List_with_Actions.Size = new System.Drawing.Size(411, 553);
            this.tabPage_List_with_Actions.TabIndex = 3;
            this.tabPage_List_with_Actions.Text = "List with Action";
            this.tabPage_List_with_Actions.UseVisualStyleBackColor = true;
            // 
            // tabPage_DataGridView
            // 
            this.tabPage_DataGridView.Controls.Add(this.dataGridView_Symbols);
            this.tabPage_DataGridView.Location = new System.Drawing.Point(4, 22);
            this.tabPage_DataGridView.Name = "tabPage_DataGridView";
            this.tabPage_DataGridView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_DataGridView.Size = new System.Drawing.Size(411, 553);
            this.tabPage_DataGridView.TabIndex = 4;
            this.tabPage_DataGridView.Text = "DataGridView";
            this.tabPage_DataGridView.UseVisualStyleBackColor = true;
            this.tabPage_DataGridView.Validated += new System.EventHandler(this.tabPage_DataGridView_Validated);
            // 
            // dataGridView_Symbols
            // 
            this.dataGridView_Symbols.AllowUserToOrderColumns = true;
            this.dataGridView_Symbols.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Symbols.Location = new System.Drawing.Point(3, 35);
            this.dataGridView_Symbols.Name = "dataGridView_Symbols";
            this.dataGridView_Symbols.Size = new System.Drawing.Size(405, 515);
            this.dataGridView_Symbols.TabIndex = 0;
            // 
            // tabPage_Properties
            // 
            this.tabPage_Properties.Controls.Add(this.button_Enable_Edit);
            this.tabPage_Properties.Controls.Add(this.button_Status_Refresh);
            this.tabPage_Properties.Controls.Add(this.propertyGrid_Selected_Object);
            this.tabPage_Properties.Controls.Add(this.button_Action);
            this.tabPage_Properties.Controls.Add(this.nameTextBox);
            this.tabPage_Properties.Controls.Add(nameLabel);
            this.tabPage_Properties.Controls.Add(this.statusTextBox);
            this.tabPage_Properties.Controls.Add(statusLabel);
            this.tabPage_Properties.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Properties.Name = "tabPage_Properties";
            this.tabPage_Properties.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Properties.Size = new System.Drawing.Size(411, 553);
            this.tabPage_Properties.TabIndex = 0;
            this.tabPage_Properties.Text = "Properties";
            this.tabPage_Properties.UseVisualStyleBackColor = true;
            // 
            // button_Enable_Edit
            // 
            this.button_Enable_Edit.Location = new System.Drawing.Point(67, 50);
            this.button_Enable_Edit.Name = "button_Enable_Edit";
            this.button_Enable_Edit.Size = new System.Drawing.Size(72, 23);
            this.button_Enable_Edit.TabIndex = 43;
            this.button_Enable_Edit.Text = "Enable Edit";
            this.button_Enable_Edit.UseVisualStyleBackColor = true;
            this.button_Enable_Edit.Click += new System.EventHandler(this.button_Enable_Edit_Click);
            // 
            // button_Status_Refresh
            // 
            this.button_Status_Refresh.Location = new System.Drawing.Point(145, 50);
            this.button_Status_Refresh.Name = "button_Status_Refresh";
            this.button_Status_Refresh.Size = new System.Drawing.Size(91, 23);
            this.button_Status_Refresh.TabIndex = 7;
            this.button_Status_Refresh.Text = "Status/Refresh";
            this.button_Status_Refresh.UseVisualStyleBackColor = true;
            this.button_Status_Refresh.Click += new System.EventHandler(this.button_Status_Refresh_Click);
            // 
            // propertyGrid_Selected_Object
            // 
            this.propertyGrid_Selected_Object.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid_Selected_Object.Enabled = false;
            this.propertyGrid_Selected_Object.Location = new System.Drawing.Point(6, 73);
            this.propertyGrid_Selected_Object.Name = "propertyGrid_Selected_Object";
            this.propertyGrid_Selected_Object.Size = new System.Drawing.Size(402, 474);
            this.propertyGrid_Selected_Object.TabIndex = 9;
            // 
            // button_Action
            // 
            this.button_Action.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objectToControlBindingSource, "Action", true));
            this.button_Action.Location = new System.Drawing.Point(2, 50);
            this.button_Action.Name = "button_Action";
            this.button_Action.Size = new System.Drawing.Size(59, 23);
            this.button_Action.TabIndex = 8;
            this.button_Action.Text = "Start";
            this.button_Action.UseVisualStyleBackColor = true;
            this.button_Action.Click += new System.EventHandler(this.button_Action_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objectToControlBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(38, 3);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(367, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(notesLabel);
            this.tabPage3.Controls.Add(this.notesTextBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(411, 553);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Notes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // OLVMSymbolsControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tabControl1);
            this.Name = "OLVMSymbolsControl2";
            this.Size = new System.Drawing.Size(422, 582);
            this.Load += new System.EventHandler(this.ObjectListButtonControl_Load);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectToControlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OLV_Objects)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_List_DataTree.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvDataTree)).EndInit();
            this.tabPage_List_with_Actions.ResumeLayout(false);
            this.tabPage_DataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Symbols)).EndInit();
            this.tabPage_Properties.ResumeLayout(false);
            this.tabPage_Properties.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox textBoxFilter;
        private BrightIdeasSoftware.ObjectListView OLV_Objects;
        private BrightIdeasSoftware.OLVColumn olvColumn_Name;
        private BrightIdeasSoftware.OLVColumn olvColumnStatus;
        private System.Windows.Forms.ImageList imageListTasks;
        private BrightIdeasSoftware.OLVColumn olvColumn_Potential;
        private BrightIdeasSoftware.OLVColumn olvColumnAction;
        private System.Windows.Forms.ImageList imageListSmall;
        private BrightIdeasSoftware.HotItemStyle hotItemStyle1;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.CheckBox checkBox_LowPotential;
        private System.Windows.Forms.CheckBox checkBox_HighPotential;
        private System.Windows.Forms.CheckBox checkBoxCheckboxes;
        private System.Windows.Forms.CheckBox checkBoxGroups;
        private BrightIdeasSoftware.OLVColumn olvColumn_Log_Last;
        private BrightIdeasSoftware.OLVColumn olvColumn_Description;
        private BrightIdeasSoftware.OLVColumn olvColumn_Auto_Start;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.BindingSource objectToControlBindingSource;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Properties;
        private System.Windows.Forms.Button button_Action;
        private System.Windows.Forms.Button button_Status_Refresh;
        private System.Windows.Forms.TabPage tabPage_List_DataTree;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage_List_with_Actions;
        private System.Windows.Forms.TextBox status_Check_IntervalTextBox;
        private System.Windows.Forms.CheckBox synchronousCheckBox;
        private System.Windows.Forms.CheckBox auto_StartCheckBox1;
        private System.Windows.Forms.TabPage tabPage_DataGridView;
        private System.Windows.Forms.PropertyGrid propertyGrid_Selected_Object;
        private System.Windows.Forms.Button button_Enable_Edit;
        private System.Windows.Forms.TextBox nameTextBox;
        private BrightIdeasSoftware.DataTreeListView olvDataTree;
        private BrightIdeasSoftware.OLVColumn olvColumn_Symbol;
        private System.Windows.Forms.DataGridView dataGridView_Symbols;
    }
}
