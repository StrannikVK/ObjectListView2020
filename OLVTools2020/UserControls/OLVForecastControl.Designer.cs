namespace OLVTools2020
{
    partial class OLVForecastControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OLVForecastControl));
            this.olvColumnAction = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.button_Pause_Q = new System.Windows.Forms.Button();
            this.button_Start_Q = new System.Windows.Forms.Button();
            this.button_Stop_Q = new System.Windows.Forms.Button();
            this.button_Save_Current_Columns2 = new System.Windows.Forms.Button();
            this.textBox_Generic_Filter = new System.Windows.Forms.TextBox();
            this.button_Get_All_Forecast_Properties = new System.Windows.Forms.Button();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.button_Load_Browser = new System.Windows.Forms.Button();
            this.imageListTasks = new System.Windows.Forms.ImageList(this.components);
            this.OLV_Objects = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn_Symbol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnCompanyName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_Forecasts_Used_Description = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.hotItemStyle1 = new BrightIdeasSoftware.HotItemStyle();
            this.tabControl_Symbols = new System.Windows.Forms.TabControl();
            this.tabPage_SymbolsObjects = new System.Windows.Forms.TabPage();
            this.tabPage_Symbol_Properties = new System.Windows.Forms.TabPage();
            this.propertyGrid_Symbol = new System.Windows.Forms.PropertyGrid();
            this.tabPage_Settings_Controls_Collumns = new System.Windows.Forms.TabPage();
            this.button_Import_Replace_Columns = new System.Windows.Forms.Button();
            this.button_Import_New_Columns = new System.Windows.Forms.Button();
            this.button_Export_Current_Columns = new System.Windows.Forms.Button();
            this.textBox_AspectToStringFormat = new System.Windows.Forms.TextBox();
            this.propertyGrid_Column = new System.Windows.Forms.PropertyGrid();
            this.textBox_Sorting_Parameter = new System.Windows.Forms.TextBox();
            this.button_Update_Sorting_Parameter = new System.Windows.Forms.Button();
            this.button_Save_Current_Columns = new System.Windows.Forms.Button();
            this.button_Move_To_New_Index = new System.Windows.Forms.Button();
            this.comboBox_Column_Index = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Column_Index = new System.Windows.Forms.TextBox();
            this.button_Delete_Column = new System.Windows.Forms.Button();
            this.textBox_Minimal_Width = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_Width = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_AspectToStringFormat = new System.Windows.Forms.ComboBox();
            this.textBox_ToolTipText = new System.Windows.Forms.TextBox();
            this.comboBox_Existing_Columns = new System.Windows.Forms.ComboBox();
            this.textBox_Header_Text = new System.Windows.Forms.TextBox();
            this.comboBox_Parameters_Columns = new System.Windows.Forms.ComboBox();
            this.button_Add_Column_For_Propertie = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OLV_Objects)).BeginInit();
            this.tabControl_Symbols.SuspendLayout();
            this.tabPage_SymbolsObjects.SuspendLayout();
            this.tabPage_Symbol_Properties.SuspendLayout();
            this.tabPage_Settings_Controls_Collumns.SuspendLayout();
            this.SuspendLayout();
            // 
            // olvColumnAction
            // 
            this.olvColumnAction.AspectName = "Action";
            this.olvColumnAction.Text = "Action";
            this.olvColumnAction.ToolTipText = "Action";
            this.olvColumnAction.Width = 85;
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox9.Controls.Add(this.button_Pause_Q);
            this.groupBox9.Controls.Add(this.button_Start_Q);
            this.groupBox9.Controls.Add(this.button_Stop_Q);
            this.groupBox9.Controls.Add(this.button_Save_Current_Columns2);
            this.groupBox9.Controls.Add(this.textBox_Generic_Filter);
            this.groupBox9.Controls.Add(this.button_Get_All_Forecast_Properties);
            this.groupBox9.Controls.Add(this.button_Refresh);
            this.groupBox9.Controls.Add(this.button_Load_Browser);
            this.groupBox9.Location = new System.Drawing.Point(4, -2);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(623, 33);
            this.groupBox9.TabIndex = 40;
            this.groupBox9.TabStop = false;
            // 
            // button_Pause_Q
            // 
            this.button_Pause_Q.AutoSize = true;
            this.button_Pause_Q.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_Pause_Q.Location = new System.Drawing.Point(114, 7);
            this.button_Pause_Q.Name = "button_Pause_Q";
            this.button_Pause_Q.Size = new System.Drawing.Size(47, 23);
            this.button_Pause_Q.TabIndex = 59;
            this.button_Pause_Q.Text = "Pause";
            this.button_Pause_Q.UseVisualStyleBackColor = true;
            this.button_Pause_Q.Click += new System.EventHandler(this.button_Pause_Q_Click);
            // 
            // button_Start_Q
            // 
            this.button_Start_Q.AutoSize = true;
            this.button_Start_Q.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_Start_Q.Location = new System.Drawing.Point(76, 7);
            this.button_Start_Q.Name = "button_Start_Q";
            this.button_Start_Q.Size = new System.Drawing.Size(39, 23);
            this.button_Start_Q.TabIndex = 58;
            this.button_Start_Q.Text = "Start";
            this.button_Start_Q.UseVisualStyleBackColor = true;
            this.button_Start_Q.Click += new System.EventHandler(this.button_Start_Q_Click);
            // 
            // button_Stop_Q
            // 
            this.button_Stop_Q.AutoSize = true;
            this.button_Stop_Q.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_Stop_Q.Location = new System.Drawing.Point(160, 7);
            this.button_Stop_Q.Name = "button_Stop_Q";
            this.button_Stop_Q.Size = new System.Drawing.Size(39, 23);
            this.button_Stop_Q.TabIndex = 39;
            this.button_Stop_Q.Text = "Stop";
            this.button_Stop_Q.UseVisualStyleBackColor = true;
            this.button_Stop_Q.Click += new System.EventHandler(this.button_Stop_Update_All_Click);
            // 
            // button_Save_Current_Columns2
            // 
            this.button_Save_Current_Columns2.Location = new System.Drawing.Point(403, 8);
            this.button_Save_Current_Columns2.Name = "button_Save_Current_Columns2";
            this.button_Save_Current_Columns2.Size = new System.Drawing.Size(116, 20);
            this.button_Save_Current_Columns2.TabIndex = 55;
            this.button_Save_Current_Columns2.Text = "Save Current LayOut";
            this.button_Save_Current_Columns2.UseVisualStyleBackColor = true;
            this.button_Save_Current_Columns2.Click += new System.EventHandler(this.button_Save_Current_Columns2_Click);
            // 
            // textBox_Generic_Filter
            // 
            this.textBox_Generic_Filter.Location = new System.Drawing.Point(1, 9);
            this.textBox_Generic_Filter.Name = "textBox_Generic_Filter";
            this.textBox_Generic_Filter.Size = new System.Drawing.Size(73, 20);
            this.textBox_Generic_Filter.TabIndex = 41;
            this.textBox_Generic_Filter.TextChanged += new System.EventHandler(this.textBox_Generic_Filter_TextChanged);
            // 
            // button_Get_All_Forecast_Properties
            // 
            this.button_Get_All_Forecast_Properties.Location = new System.Drawing.Point(280, 8);
            this.button_Get_All_Forecast_Properties.Name = "button_Get_All_Forecast_Properties";
            this.button_Get_All_Forecast_Properties.Size = new System.Drawing.Size(67, 20);
            this.button_Get_All_Forecast_Properties.TabIndex = 40;
            this.button_Get_All_Forecast_Properties.Text = "Properties";
            this.button_Get_All_Forecast_Properties.UseVisualStyleBackColor = true;
            this.button_Get_All_Forecast_Properties.Click += new System.EventHandler(this.button_Get_All_Forecast_Properties_Click);
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(346, 8);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(53, 20);
            this.button_Refresh.TabIndex = 3;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // button_Load_Browser
            // 
            this.button_Load_Browser.Location = new System.Drawing.Point(202, 8);
            this.button_Load_Browser.Name = "button_Load_Browser";
            this.button_Load_Browser.Size = new System.Drawing.Size(80, 20);
            this.button_Load_Browser.TabIndex = 37;
            this.button_Load_Browser.Text = "Load Browser";
            this.button_Load_Browser.UseVisualStyleBackColor = true;
            this.button_Load_Browser.Click += new System.EventHandler(this.button_Load_Browser_Click);
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
            this.OLV_Objects.AllColumns.Add(this.olvColumn_Symbol);
            this.OLV_Objects.AllColumns.Add(this.olvColumnAction);
            this.OLV_Objects.AllColumns.Add(this.olvColumnCompanyName);
            this.OLV_Objects.AllColumns.Add(this.olvColumn_Forecasts_Used_Description);
            this.OLV_Objects.AllowColumnReorder = true;
            this.OLV_Objects.AllowDrop = true;
            this.OLV_Objects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OLV_Objects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OLV_Objects.CheckBoxes = true;
            this.OLV_Objects.CheckedAspectName = "";
            this.OLV_Objects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn_Symbol,
            this.olvColumnAction,
            this.olvColumnCompanyName,
            this.olvColumn_Forecasts_Used_Description});
            this.OLV_Objects.Cursor = System.Windows.Forms.Cursors.Default;
            this.OLV_Objects.FullRowSelect = true;
            this.OLV_Objects.GridLines = true;
            this.OLV_Objects.HeaderWordWrap = true;
            this.OLV_Objects.HideSelection = false;
            this.OLV_Objects.IncludeColumnHeadersInCopy = true;
            this.OLV_Objects.Location = new System.Drawing.Point(3, 32);
            this.OLV_Objects.Name = "OLV_Objects";
            this.OLV_Objects.OverlayText.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            this.OLV_Objects.OverlayText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.OLV_Objects.OverlayText.BorderWidth = 2F;
            this.OLV_Objects.OverlayText.Rotation = -20;
            this.OLV_Objects.OverlayText.Text = "";
            this.OLV_Objects.PersistentCheckBoxes = false;
            this.OLV_Objects.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.OLV_Objects.ShowCommandMenuOnRightClick = true;
            this.OLV_Objects.ShowGroups = false;
            this.OLV_Objects.ShowHeaderInAllViews = false;
            this.OLV_Objects.ShowItemToolTips = true;
            this.OLV_Objects.Size = new System.Drawing.Size(624, 436);
            this.OLV_Objects.SortGroupItemsByPrimaryColumn = false;
            this.OLV_Objects.TabIndex = 36;
            this.OLV_Objects.TriStateCheckBoxes = true;
            this.OLV_Objects.UseAlternatingBackColors = true;
            this.OLV_Objects.UseCellFormatEvents = true;
            this.OLV_Objects.UseCompatibleStateImageBehavior = false;
            this.OLV_Objects.UseFilterIndicator = true;
            this.OLV_Objects.UseFiltering = true;
            this.OLV_Objects.UseHotControls = false;
            this.OLV_Objects.View = System.Windows.Forms.View.Details;
            this.OLV_Objects.ButtonClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.OLV_Objects_ButtonClick);
            this.OLV_Objects.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.OLV_Objects_ColumnClick);
            this.OLV_Objects.SelectedIndexChanged += new System.EventHandler(this.OLV_Objects_SelectedIndexChanged);
            // 
            // olvColumn_Symbol
            // 
            this.olvColumn_Symbol.AspectName = "Symbol";
            this.olvColumn_Symbol.MinimumWidth = 40;
            this.olvColumn_Symbol.Text = "Symbol";
            this.olvColumn_Symbol.ToolTipText = "Symbol";
            this.olvColumn_Symbol.Width = 50;
            // 
            // olvColumnCompanyName
            // 
            this.olvColumnCompanyName.AspectName = "CompanyName";
            this.olvColumnCompanyName.Text = "Company Name";
            this.olvColumnCompanyName.ToolTipText = "CompanyName";
            this.olvColumnCompanyName.Width = 119;
            // 
            // olvColumn_Forecasts_Used_Description
            // 
            this.olvColumn_Forecasts_Used_Description.AspectName = "Forecasts_Used_Description";
            this.olvColumn_Forecasts_Used_Description.Text = "Forecast Name";
            this.olvColumn_Forecasts_Used_Description.Width = 100;
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
            // tabControl_Symbols
            // 
            this.tabControl_Symbols.Controls.Add(this.tabPage_SymbolsObjects);
            this.tabControl_Symbols.Controls.Add(this.tabPage_Symbol_Properties);
            this.tabControl_Symbols.Controls.Add(this.tabPage_Settings_Controls_Collumns);
            this.tabControl_Symbols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Symbols.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Symbols.Name = "tabControl_Symbols";
            this.tabControl_Symbols.SelectedIndex = 0;
            this.tabControl_Symbols.Size = new System.Drawing.Size(641, 497);
            this.tabControl_Symbols.TabIndex = 41;
            this.tabControl_Symbols.SelectedIndexChanged += new System.EventHandler(this.tabControl_Symbols_SelectedIndexChanged);
            // 
            // tabPage_SymbolsObjects
            // 
            this.tabPage_SymbolsObjects.BackColor = System.Drawing.Color.Transparent;
            this.tabPage_SymbolsObjects.Controls.Add(this.groupBox9);
            this.tabPage_SymbolsObjects.Controls.Add(this.OLV_Objects);
            this.tabPage_SymbolsObjects.Location = new System.Drawing.Point(4, 22);
            this.tabPage_SymbolsObjects.Name = "tabPage_SymbolsObjects";
            this.tabPage_SymbolsObjects.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_SymbolsObjects.Size = new System.Drawing.Size(633, 471);
            this.tabPage_SymbolsObjects.TabIndex = 0;
            this.tabPage_SymbolsObjects.Text = "Forecast";
            // 
            // tabPage_Symbol_Properties
            // 
            this.tabPage_Symbol_Properties.Controls.Add(this.propertyGrid_Symbol);
            this.tabPage_Symbol_Properties.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Symbol_Properties.Name = "tabPage_Symbol_Properties";
            this.tabPage_Symbol_Properties.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Symbol_Properties.Size = new System.Drawing.Size(633, 471);
            this.tabPage_Symbol_Properties.TabIndex = 3;
            this.tabPage_Symbol_Properties.Text = "Forecast Properties";
            this.tabPage_Symbol_Properties.UseVisualStyleBackColor = true;
            // 
            // propertyGrid_Symbol
            // 
            this.propertyGrid_Symbol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid_Symbol.Location = new System.Drawing.Point(3, 3);
            this.propertyGrid_Symbol.Name = "propertyGrid_Symbol";
            this.propertyGrid_Symbol.Size = new System.Drawing.Size(603, 465);
            this.propertyGrid_Symbol.TabIndex = 0;
            // 
            // tabPage_Settings_Controls_Collumns
            // 
            this.tabPage_Settings_Controls_Collumns.Controls.Add(this.button_Import_Replace_Columns);
            this.tabPage_Settings_Controls_Collumns.Controls.Add(this.button_Import_New_Columns);
            this.tabPage_Settings_Controls_Collumns.Controls.Add(this.button_Export_Current_Columns);
            this.tabPage_Settings_Controls_Collumns.Controls.Add(this.textBox_AspectToStringFormat);
            this.tabPage_Settings_Controls_Collumns.Controls.Add(this.propertyGrid_Column);
            this.tabPage_Settings_Controls_Collumns.Controls.Add(this.textBox_Sorting_Parameter);
            this.tabPage_Settings_Controls_Collumns.Controls.Add(this.button_Update_Sorting_Parameter);
            this.tabPage_Settings_Controls_Collumns.Controls.Add(this.button_Save_Current_Columns);
            this.tabPage_Settings_Controls_Collumns.Controls.Add(this.button_Move_To_New_Index);
            this.tabPage_Settings_Controls_Collumns.Controls.Add(this.comboBox_Column_Index);
            this.tabPage_Settings_Controls_Collumns.Controls.Add(this.label6);
            this.tabPage_Settings_Controls_Collumns.Controls.Add(this.textBox_Column_Index);
            this.tabPage_Settings_Controls_Collumns.Controls.Add(this.button_Delete_Column);
            this.tabPage_Settings_Controls_Collumns.Controls.Add(this.textBox_Minimal_Width);
            this.tabPage_Settings_Controls_Collumns.Controls.Add(this.label11);
            this.tabPage_Settings_Controls_Collumns.Controls.Add(this.textBox_Width);
            this.tabPage_Settings_Controls_Collumns.Controls.Add(this.label10);
            this.tabPage_Settings_Controls_Collumns.Controls.Add(this.comboBox_AspectToStringFormat);
            this.tabPage_Settings_Controls_Collumns.Controls.Add(this.textBox_ToolTipText);
            this.tabPage_Settings_Controls_Collumns.Controls.Add(this.comboBox_Existing_Columns);
            this.tabPage_Settings_Controls_Collumns.Controls.Add(this.textBox_Header_Text);
            this.tabPage_Settings_Controls_Collumns.Controls.Add(this.comboBox_Parameters_Columns);
            this.tabPage_Settings_Controls_Collumns.Controls.Add(this.button_Add_Column_For_Propertie);
            this.tabPage_Settings_Controls_Collumns.Controls.Add(this.label8);
            this.tabPage_Settings_Controls_Collumns.Controls.Add(this.label4);
            this.tabPage_Settings_Controls_Collumns.Controls.Add(this.label7);
            this.tabPage_Settings_Controls_Collumns.Controls.Add(this.label9);
            this.tabPage_Settings_Controls_Collumns.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Settings_Controls_Collumns.Name = "tabPage_Settings_Controls_Collumns";
            this.tabPage_Settings_Controls_Collumns.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Settings_Controls_Collumns.Size = new System.Drawing.Size(633, 471);
            this.tabPage_Settings_Controls_Collumns.TabIndex = 4;
            this.tabPage_Settings_Controls_Collumns.Text = "Settings/Properties/Controls";
            this.tabPage_Settings_Controls_Collumns.UseVisualStyleBackColor = true;
            // 
            // button_Import_Replace_Columns
            // 
            this.button_Import_Replace_Columns.Enabled = false;
            this.button_Import_Replace_Columns.Location = new System.Drawing.Point(66, 368);
            this.button_Import_Replace_Columns.Name = "button_Import_Replace_Columns";
            this.button_Import_Replace_Columns.Size = new System.Drawing.Size(168, 23);
            this.button_Import_Replace_Columns.TabIndex = 62;
            this.button_Import_Replace_Columns.Text = "Import_Replace_Columns";
            this.button_Import_Replace_Columns.UseVisualStyleBackColor = true;
            this.button_Import_Replace_Columns.Click += new System.EventHandler(this.button_Import_Replace_Columns_Click);
            // 
            // button_Import_New_Columns
            // 
            this.button_Import_New_Columns.Enabled = false;
            this.button_Import_New_Columns.Location = new System.Drawing.Point(66, 339);
            this.button_Import_New_Columns.Name = "button_Import_New_Columns";
            this.button_Import_New_Columns.Size = new System.Drawing.Size(168, 23);
            this.button_Import_New_Columns.TabIndex = 61;
            this.button_Import_New_Columns.Text = "Import Add New Columns";
            this.button_Import_New_Columns.UseVisualStyleBackColor = true;
            this.button_Import_New_Columns.Click += new System.EventHandler(this.button_Import_New_Columns_Click);
            // 
            // button_Export_Current_Columns
            // 
            this.button_Export_Current_Columns.Enabled = false;
            this.button_Export_Current_Columns.Location = new System.Drawing.Point(66, 310);
            this.button_Export_Current_Columns.Name = "button_Export_Current_Columns";
            this.button_Export_Current_Columns.Size = new System.Drawing.Size(168, 23);
            this.button_Export_Current_Columns.TabIndex = 60;
            this.button_Export_Current_Columns.Text = "Export_Current_Columns";
            this.button_Export_Current_Columns.UseVisualStyleBackColor = true;
            this.button_Export_Current_Columns.Click += new System.EventHandler(this.button_Export_Current_Columns_Click);
            // 
            // textBox_AspectToStringFormat
            // 
            this.textBox_AspectToStringFormat.Enabled = false;
            this.textBox_AspectToStringFormat.Location = new System.Drawing.Point(240, 85);
            this.textBox_AspectToStringFormat.Name = "textBox_AspectToStringFormat";
            this.textBox_AspectToStringFormat.ReadOnly = true;
            this.textBox_AspectToStringFormat.Size = new System.Drawing.Size(168, 20);
            this.textBox_AspectToStringFormat.TabIndex = 59;
            this.textBox_AspectToStringFormat.Text = "{0:N}";
            // 
            // propertyGrid_Column
            // 
            this.propertyGrid_Column.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid_Column.Location = new System.Drawing.Point(414, 4);
            this.propertyGrid_Column.Name = "propertyGrid_Column";
            this.propertyGrid_Column.Size = new System.Drawing.Size(216, 465);
            this.propertyGrid_Column.TabIndex = 57;
            // 
            // textBox_Sorting_Parameter
            // 
            this.textBox_Sorting_Parameter.Enabled = false;
            this.textBox_Sorting_Parameter.Location = new System.Drawing.Point(240, 29);
            this.textBox_Sorting_Parameter.Name = "textBox_Sorting_Parameter";
            this.textBox_Sorting_Parameter.ReadOnly = true;
            this.textBox_Sorting_Parameter.Size = new System.Drawing.Size(168, 20);
            this.textBox_Sorting_Parameter.TabIndex = 56;
            // 
            // button_Update_Sorting_Parameter
            // 
            this.button_Update_Sorting_Parameter.Enabled = false;
            this.button_Update_Sorting_Parameter.Location = new System.Drawing.Point(240, 4);
            this.button_Update_Sorting_Parameter.Name = "button_Update_Sorting_Parameter";
            this.button_Update_Sorting_Parameter.Size = new System.Drawing.Size(168, 23);
            this.button_Update_Sorting_Parameter.TabIndex = 55;
            this.button_Update_Sorting_Parameter.Text = "Update Sorting Parameter:";
            this.button_Update_Sorting_Parameter.UseVisualStyleBackColor = true;
            this.button_Update_Sorting_Parameter.Click += new System.EventHandler(this.button_Update_Sorting_Parameter_Click);
            // 
            // button_Save_Current_Columns
            // 
            this.button_Save_Current_Columns.Enabled = false;
            this.button_Save_Current_Columns.Location = new System.Drawing.Point(66, 222);
            this.button_Save_Current_Columns.Name = "button_Save_Current_Columns";
            this.button_Save_Current_Columns.Size = new System.Drawing.Size(168, 23);
            this.button_Save_Current_Columns.TabIndex = 54;
            this.button_Save_Current_Columns.Text = "Save Current Columns";
            this.button_Save_Current_Columns.UseVisualStyleBackColor = true;
            this.button_Save_Current_Columns.Click += new System.EventHandler(this.button_Save_Current_Columns_Click);
            // 
            // button_Move_To_New_Index
            // 
            this.button_Move_To_New_Index.Enabled = false;
            this.button_Move_To_New_Index.Location = new System.Drawing.Point(240, 254);
            this.button_Move_To_New_Index.Name = "button_Move_To_New_Index";
            this.button_Move_To_New_Index.Size = new System.Drawing.Size(168, 23);
            this.button_Move_To_New_Index.TabIndex = 53;
            this.button_Move_To_New_Index.Text = "Move Column To New Index";
            this.button_Move_To_New_Index.UseVisualStyleBackColor = true;
            this.button_Move_To_New_Index.Click += new System.EventHandler(this.button_Move_To_New_Index_Click);
            // 
            // comboBox_Column_Index
            // 
            this.comboBox_Column_Index.Enabled = false;
            this.comboBox_Column_Index.FormattingEnabled = true;
            this.comboBox_Column_Index.Location = new System.Drawing.Point(66, 283);
            this.comboBox_Column_Index.Name = "comboBox_Column_Index";
            this.comboBox_Column_Index.Size = new System.Drawing.Size(168, 21);
            this.comboBox_Column_Index.TabIndex = 52;
            this.comboBox_Column_Index.Text = "New Column Index";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(32, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Index";
            // 
            // textBox_Column_Index
            // 
            this.textBox_Column_Index.Enabled = false;
            this.textBox_Column_Index.Location = new System.Drawing.Point(85, 112);
            this.textBox_Column_Index.Name = "textBox_Column_Index";
            this.textBox_Column_Index.Size = new System.Drawing.Size(149, 20);
            this.textBox_Column_Index.TabIndex = 50;
            this.textBox_Column_Index.Text = "Last";
            // 
            // button_Delete_Column
            // 
            this.button_Delete_Column.Enabled = false;
            this.button_Delete_Column.Location = new System.Drawing.Point(240, 225);
            this.button_Delete_Column.Name = "button_Delete_Column";
            this.button_Delete_Column.Size = new System.Drawing.Size(168, 23);
            this.button_Delete_Column.TabIndex = 49;
            this.button_Delete_Column.Text = "Delete Column";
            this.button_Delete_Column.UseVisualStyleBackColor = true;
            this.button_Delete_Column.Click += new System.EventHandler(this.button_Delete_Column_Click);
            // 
            // textBox_Minimal_Width
            // 
            this.textBox_Minimal_Width.Enabled = false;
            this.textBox_Minimal_Width.Location = new System.Drawing.Point(85, 164);
            this.textBox_Minimal_Width.Name = "textBox_Minimal_Width";
            this.textBox_Minimal_Width.Size = new System.Drawing.Size(149, 20);
            this.textBox_Minimal_Width.TabIndex = 47;
            this.textBox_Minimal_Width.Text = "40";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Location = new System.Drawing.Point(3, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "Minimal Width:";
            // 
            // textBox_Width
            // 
            this.textBox_Width.Enabled = false;
            this.textBox_Width.Location = new System.Drawing.Point(85, 138);
            this.textBox_Width.Name = "textBox_Width";
            this.textBox_Width.Size = new System.Drawing.Size(149, 20);
            this.textBox_Width.TabIndex = 45;
            this.textBox_Width.Text = "40";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Location = new System.Drawing.Point(32, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Width:";
            // 
            // comboBox_AspectToStringFormat
            // 
            this.comboBox_AspectToStringFormat.Enabled = false;
            this.comboBox_AspectToStringFormat.FormattingEnabled = true;
            this.comboBox_AspectToStringFormat.Items.AddRange(new object[] {
            "String/Text",
            "Number",
            "N/A"});
            this.comboBox_AspectToStringFormat.Location = new System.Drawing.Point(66, 85);
            this.comboBox_AspectToStringFormat.Name = "comboBox_AspectToStringFormat";
            this.comboBox_AspectToStringFormat.Size = new System.Drawing.Size(168, 21);
            this.comboBox_AspectToStringFormat.TabIndex = 43;
            this.comboBox_AspectToStringFormat.Text = "N/A";
            this.comboBox_AspectToStringFormat.SelectedIndexChanged += new System.EventHandler(this.comboBox_AspectToStringFormat_SelectedIndexChanged);
            // 
            // textBox_ToolTipText
            // 
            this.textBox_ToolTipText.Enabled = false;
            this.textBox_ToolTipText.Location = new System.Drawing.Point(66, 59);
            this.textBox_ToolTipText.Name = "textBox_ToolTipText";
            this.textBox_ToolTipText.Size = new System.Drawing.Size(168, 20);
            this.textBox_ToolTipText.TabIndex = 41;
            this.textBox_ToolTipText.Text = "Parameter Name";
            // 
            // comboBox_Existing_Columns
            // 
            this.comboBox_Existing_Columns.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Existing_Columns.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Existing_Columns.Enabled = false;
            this.comboBox_Existing_Columns.FormattingEnabled = true;
            this.comboBox_Existing_Columns.Location = new System.Drawing.Point(66, 257);
            this.comboBox_Existing_Columns.Name = "comboBox_Existing_Columns";
            this.comboBox_Existing_Columns.Size = new System.Drawing.Size(168, 21);
            this.comboBox_Existing_Columns.TabIndex = 39;
            this.comboBox_Existing_Columns.Text = "Select Existing Column";
            this.comboBox_Existing_Columns.SelectedIndexChanged += new System.EventHandler(this.comboBox_Existing_Columns_SelectedIndexChanged);
            // 
            // textBox_Header_Text
            // 
            this.textBox_Header_Text.Enabled = false;
            this.textBox_Header_Text.Location = new System.Drawing.Point(66, 33);
            this.textBox_Header_Text.Name = "textBox_Header_Text";
            this.textBox_Header_Text.Size = new System.Drawing.Size(168, 20);
            this.textBox_Header_Text.TabIndex = 35;
            this.textBox_Header_Text.Text = "Shart Parameter Name";
            this.textBox_Header_Text.Validated += new System.EventHandler(this.textBox_Header_Text_Validated);
            // 
            // comboBox_Parameters_Columns
            // 
            this.comboBox_Parameters_Columns.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Parameters_Columns.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Parameters_Columns.Enabled = false;
            this.comboBox_Parameters_Columns.FormattingEnabled = true;
            this.comboBox_Parameters_Columns.Location = new System.Drawing.Point(66, 6);
            this.comboBox_Parameters_Columns.Name = "comboBox_Parameters_Columns";
            this.comboBox_Parameters_Columns.Size = new System.Drawing.Size(168, 21);
            this.comboBox_Parameters_Columns.Sorted = true;
            this.comboBox_Parameters_Columns.TabIndex = 34;
            this.comboBox_Parameters_Columns.Text = "Select Propertie To display";
            this.comboBox_Parameters_Columns.SelectedIndexChanged += new System.EventHandler(this.comboBox_Parameters_Columns_SelectedIndexChanged);
            // 
            // button_Add_Column_For_Propertie
            // 
            this.button_Add_Column_For_Propertie.Enabled = false;
            this.button_Add_Column_For_Propertie.Location = new System.Drawing.Point(66, 190);
            this.button_Add_Column_For_Propertie.Name = "button_Add_Column_For_Propertie";
            this.button_Add_Column_For_Propertie.Size = new System.Drawing.Size(168, 23);
            this.button_Add_Column_For_Propertie.TabIndex = 33;
            this.button_Add_Column_For_Propertie.Text = "Add_Column";
            this.button_Add_Column_For_Propertie.UseVisualStyleBackColor = true;
            this.button_Add_Column_For_Propertie.Click += new System.EventHandler(this.button_Add_Column_For_Propertie_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(3, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "ToolTipText:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(13, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Properties:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(1, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Header Text:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Location = new System.Drawing.Point(23, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Formats:";
            // 
            // OLVForecastControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tabControl_Symbols);
            this.Name = "OLVForecastControl";
            this.Size = new System.Drawing.Size(641, 497);
            this.Load += new System.EventHandler(this.ObjectListButtonControl_Load);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OLV_Objects)).EndInit();
            this.tabControl_Symbols.ResumeLayout(false);
            this.tabPage_SymbolsObjects.ResumeLayout(false);
            this.tabPage_Symbol_Properties.ResumeLayout(false);
            this.tabPage_Settings_Controls_Collumns.ResumeLayout(false);
            this.tabPage_Settings_Controls_Collumns.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox9;
        private BrightIdeasSoftware.ObjectListView OLV_Objects;
        private BrightIdeasSoftware.OLVColumn olvColumn_Symbol;
        private System.Windows.Forms.ImageList imageListTasks;
        private BrightIdeasSoftware.OLVColumn olvColumnAction;
        private System.Windows.Forms.ImageList imageListSmall;
        private BrightIdeasSoftware.HotItemStyle hotItemStyle1;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Button button_Load_Browser;
        private BrightIdeasSoftware.OLVColumn olvColumnCompanyName;
        private System.Windows.Forms.Button button_Get_All_Forecast_Properties;
        private System.Windows.Forms.TabControl tabControl_Symbols;
        private System.Windows.Forms.TabPage tabPage_SymbolsObjects;
        private System.Windows.Forms.TextBox textBox_Generic_Filter;
        private System.Windows.Forms.TabPage tabPage_Symbol_Properties;
        private System.Windows.Forms.PropertyGrid propertyGrid_Symbol;
        private System.Windows.Forms.TabPage tabPage_Settings_Controls_Collumns;
        private System.Windows.Forms.ComboBox comboBox_Existing_Columns;
        private System.Windows.Forms.TextBox textBox_Header_Text;
        private System.Windows.Forms.ComboBox comboBox_Parameters_Columns;
        private System.Windows.Forms.Button button_Add_Column_For_Propertie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_ToolTipText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_Delete_Column;
        private System.Windows.Forms.TextBox textBox_Minimal_Width;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_Width;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_AspectToStringFormat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Column_Index;
        private System.Windows.Forms.ComboBox comboBox_Column_Index;
        private System.Windows.Forms.Button button_Move_To_New_Index;
        private System.Windows.Forms.Button button_Update_Sorting_Parameter;
        private System.Windows.Forms.TextBox textBox_Sorting_Parameter;
        private System.Windows.Forms.PropertyGrid propertyGrid_Column;
        private System.Windows.Forms.TextBox textBox_AspectToStringFormat;
        private System.Windows.Forms.Button button_Save_Current_Columns2;
        private System.Windows.Forms.Button button_Save_Current_Columns;
        private System.Windows.Forms.Button button_Import_New_Columns;
        private System.Windows.Forms.Button button_Export_Current_Columns;
        private System.Windows.Forms.Button button_Import_Replace_Columns;
        private System.Windows.Forms.Button button_Stop_Q;
        private System.Windows.Forms.Button button_Pause_Q;
        private System.Windows.Forms.Button button_Start_Q;
        private BrightIdeasSoftware.OLVColumn olvColumn_Forecasts_Used_Description;
    }
}
