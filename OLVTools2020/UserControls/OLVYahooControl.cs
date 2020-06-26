using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using GenericTools.Controllers;
using BrightIdeasSoftware;

namespace OLVTools2020
{
    public partial class OLVYahooControl : UserControl
    {

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        //public OLVMgr OLV_Mgr
        //{
        //    get { return _OLVMgr; }
        //    set
        //    {
        //        _OLVMgr = value;
        //        if (value != null)
        //        {
        //            this.InitializeTab();
        //            //this.SetupGeneralListViewEvents();
        //        }
        //    }
        //}
        //private OLVMgr _OLVMgr;
        private object _Object_Mgr;
        private GenericTools.Tools Gen_Tools = new GenericTools.Tools();

        private ObjectListView listView;
        public ObjectListView ListView
        {
            get { return this.listView; }
            protected set { this.listView = value; }
        }

        public List<object> List_Of_Objects { get; private set; } = new List<object>();
        public List<object> List_Of_Filtered_Objects { get; private set; } = new List<object>();
        public Utilities.OLVMgrObject OLV_Mgr_Object = new Utilities.OLVMgrObject();


        public OLVYahooControl()
        {
            InitializeComponent();
            this.ListView = this.OLV_Objects;

            

        }

        public void Set_List_Of_Object(List<object> oList_Of_Object, object oObject_Mgr)
        {
            _Object_Mgr = oObject_Mgr;
            List_Of_Objects = oList_Of_Object;
            this.OLV_Objects.SetObjects(List_Of_Objects);
            OLV_Objects.CheckBoxes = false;

            try 
            {
                bool oGood = false;
                object oObject = Gen_Tools.GetValue_ByPropertieName_As_Object(_Object_Mgr, "OLV_Mgr_Object", out oGood);
                if (oGood) { OLV_Mgr_Object = oObject as Utilities.OLVMgrObject; }
                foreach (Utilities.PropertieColumn oPropertieColumn in OLV_Mgr_Object.List_Of_PropertieColumn)
                {
                    Add_Column(oPropertieColumn);
                }
               
            }
            catch (Exception ex) { string oDebug = ex.Message; }
            
            SetupColumnWithButton();
            try 
            {
                List<string> oList = Parameters_List();
                if (oList.Count>0) 
                {
                    Gen_Tools.ComboBox_Create_Items_List_of_String(comboBox_Parameters, oList);
                    comboBox_Parameters.SelectedIndex = 0;
                    comboBox_Condition.SelectedIndex = 1;

                    Gen_Tools.ComboBox_Create_Items_List_of_String(comboBox_Parameters_Columns, oList);
                    comboBox_Parameters_Columns.SelectedIndex = 0;
                    comboBox_Parameters_Columns.SelectedIndex = 1;
                }
                

            }
            catch (Exception ex) { string oDebug = ex.Message; }
            
            try 
            {
                Gen_Tools.Bind_To_Propertie_Async(total_SymbolsTextBox, "Text", _Object_Mgr, "Total_Symbols", false, oClear: true);
                Gen_Tools.Bind_To_Propertie_Async(symbols_ProcessedTextBox, "Text", _Object_Mgr, "Symbols_Processed", false, oClear: true);
                //total_SymbolsTextBox
                //    symbols_ProcessedTextBox
                
                Gen_Tools.Bind_To_Propertie_Async(last_SymbolTextBox, "Text", _Object_Mgr, "Last_Symbol", false, oClear: true);
                //last_SymbolTextBox
                //comboBox_Parameters
                Gen_Tools.Bind_To_Propertie_Async(textBox_Elev_Average1, "Text", _Object_Mgr, "Elevation_Average", true, oClear: true);

                Gen_Tools.Bind_To_Propertie_Async(textBox_Elev_Average2, "Text", _Object_Mgr, "Elevation_Average", true, oClear: true);

                Gen_Tools.Bind_To_Propertie_Async(comboBox_Parameters, "Text", OLV_Mgr_Object, "Filter_Name", false, oClear: true);
                //comboBox_Condition
                Gen_Tools.Bind_To_Propertie_Async(comboBox_Condition, "Text", OLV_Mgr_Object, "Filter_Condition", false, oClear: true);
                //textBox_Filter_Value
                Gen_Tools.Bind_To_Propertie_Async(textBox_Filter_Value, "Text", OLV_Mgr_Object, "Filter_Value", false, oClear: true);

               
                
                //         public string Filter_Name { get; set; } = "Name";
                //public string Filter_Condition { get; set; } = "=";
                //public double Filter_Level { get; set; } = 3;
                //public double Filter_Value { get; set; } = 0
            }
            catch (Exception ex) { string oDebug = ex.Message; }
            List_Of_Colums_AspectName();
            Refresh_Objects();
        }

        public List<string> Parameters_List()
        {
            object oObject = List_Of_Objects[0];
            List<string> oList = Gen_Tools.Get_Properties_List(oObject);
            return oList;
        }

        public void Refresh_Objects()
        {
            OLV_Objects.RefreshObjects(List_Of_Objects);
            OLV_Objects_Filtered.RefreshObjects(List_Of_Filtered_Objects);

        }
        protected void InitializeTab() {

            //this.SetupDescibedTaskColumn();
            //this.SetupColumns();
            this.SetupColumnWithButton();
            OLV_Objects.CheckBoxes = false;

            // How much space do we want to give each row? Obviously, this should be at least
            // the height of the images used by the renderer
            //this.OLV_Objects.RowHeight = 54;
            this.OLV_Objects.SmallImageList = imageListSmall;
            this.OLV_Objects.EmptyListMsg = "No tasks match the filter";
            this.OLV_Objects.UseAlternatingBackColors = false;
            this.OLV_Objects.UseHotItem = false;

            // Make and display a list of tasks
            this.OLV_Objects.SetObjects(List_Of_Objects);
            //try { object objectToControl = List_Of_Objects[0];
            //    if (objectToControl!=null) { Gen_Tools.DataBindings_ChangeDataSource(this, Objects_BindingSource, objectToControl); }
            //}
            //catch (Exception ex) { string oDebug = ex.Message; }
            

            

        }


        private void SetupColumnWithButton() {

            // Tell the columns that it is going to show buttons.
            // The label that goes into the button is the Aspect that would have been
            // displayed in the cell.
            this.olvColumnAction.IsButton = true;

            // How will the button be sized? That can either be:
            //   - FixedBounds. Each button is ButtonSize in size
            //   - CellBounds. Each button is as wide as the cell, inset by CellPadding
            //   - TextBounds. Each button resizes to match the width of the text plus ButtonPadding
            this.olvColumnAction.ButtonSizing = OLVColumn.ButtonSizingMode.CellBounds;
            this.olvColumnAction.ButtonSize = new Size(80, 26);

            // Make the buttons clickable even if the row itself is disabled
            this.olvColumnAction.EnableButtonWhenItemIsDisabled = true;
            this.olvColumnAction.AspectName = "Action";
            this.olvColumnAction.TextAlign = HorizontalAlignment.Center;

            //// Listen for button clicks -- which for the purpose of the demo will cycle the state of the service task
            //this.OLV_Objects.ButtonClick += delegate(object sender, CellClickEventArgs e) {
            //    OLV_Mgr.ToolStripStatus1 = String.Format("Button clicked: ({0}, {1}, {2})", e.RowIndex, e.SubItem, e.Model);

            //    // We only have one column with a button, but if there was more than one, you would have to check ColumnIndex to see which button was clicked
            //    TestObject task = (TestObject)e.Model;
            //    task.AdvanceToNextState();

            //    // Just to show off disabled rows, make tasks that are frozen be disabled.
            //    if (task.Status == TestObject.TaskStatus.Frozen)
            //        this.OLV_Objects.DisableObject(e.Model);
            //    else
            //        this.OLV_Objects.EnableObject(e.Model);

            //    this.OLV_Objects.RefreshObject(e.Model);
            //};
            try 
            {
                foreach (OLVColumn oOLVColumn in OLV_Objects_Filtered.Columns)
                {
                    if (oOLVColumn.AspectName == "Action") 
                    {
                        oOLVColumn.IsButton = true;

                        oOLVColumn.ButtonSizing = OLVColumn.ButtonSizingMode.CellBounds;
                        oOLVColumn.ButtonSize = new Size(80, 26);

                        oOLVColumn.EnableButtonWhenItemIsDisabled = true;
                        oOLVColumn.AspectName = "Action";
                        //oOLVColumn.TextAlign = HorizontalAlignment.Center;
                        return;
                    }
                }
                
            }
            catch (Exception ex) { string oDebug = ex.Message; }
        }

        private void RebuildFilters() {
            // Build a composite filter that unify the three possible filtering criteria

            try
            {
                List<IModelFilter> filters = new List<IModelFilter>();
                //bool oResult = false;
                //double oFilter_Level = Gen_Tools.StringToDouble(textBox_Elevation_Filter.Text, ref oResult);
                //if (oResult && oFilter_Level!=0) 
                //{
                //    try 
                //    {
                   
                //    }
                //    catch (Exception ex) { string oDebug = ex.Message; }
                
                //}
                //Gen_Tools.StringToDouble
                //textBox_Elevation_Filter.Text
                //if (this.checkBox_HighPotential.Checked)
                //    filters.Add(new ModelFilter(delegate (object model) { return ((object)model).Filter_Value > ((object)model).Filter_Level;  }));

                //if (this.checkBox_LowPotential.Checked)
                //    filters.Add(new ModelFilter(delegate (object model) { return ((object)model).Filter_Value <= ((object)model).Filter_Level; }));

                if (!String.IsNullOrEmpty(this.textBoxFilter.Text))
                    filters.Add(new TextMatchFilter(this.OLV_Objects, this.textBoxFilter.Text));

                // Use AdditionalFilter (instead of ModelFilter) since AdditionalFilter plays well with any
                // extra filtering the user might specify via the column header
                this.OLV_Objects.AdditionalFilter = filters.Count == 0 ? null : new CompositeAllFilter(filters);
                //Gen_Tools.DataBindings_Refresh(this, objectToControlBindingSource);

            }

            catch (Exception ex) { string oDebug = ex.Message; }

            
        }

        private void textBoxFilter_Validated(object sender, EventArgs e) {
            this.RebuildFilters();
        }


        private void ObjectListButtonControl_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    List<ColumnHeader> oList_ColumnHeader = new List<ColumnHeader>();
            //    foreach (OLVColumn oOLVColumn in OLV_Objects.AllColumns)
            //    {
            //        if (oOLVColumn.Name == "olvColumnAction") { continue; }
            //        OLVColumn oNewOLVColumn = new OLVColumn();
            //        object oSource = oOLVColumn;
            //        object oDest = oNewOLVColumn;
            //        //string oReportLog = "";
            //        Gen_Tools.Update_All_Properties_By_Object(ref oDest, oSource);//,out  oReportLog);
            //        OLV_Objects_Filtered.AllColumns.Add(oNewOLVColumn);
            //        oList_ColumnHeader.Add(oNewOLVColumn);

            //    }
            //    OLV_Objects_Filtered.Columns.AddRange(oList_ColumnHeader.ToArray());
            //    OLV_Objects_Filtered.CheckBoxes = false;
            //}
            //catch (Exception ex) { string oDebug = ex.Message; }
        }

        private void OLV_Objects_ButtonClick(object sender, CellClickEventArgs e)
        {
            try
            {
                int oRowindes = e.RowIndex;
                object oSubitem = e.SubItem;
                object oModel = e.Model;
                object oobject = (object)e.Model;
                object oResult = null;
                string oSymbol = Gen_Tools.Get_Properie_String_By_Name(oobject, "Symbol");
                string oAction = Gen_Tools.Get_Properie_String_By_Name(oobject, "Action");
                
                object[] oArg = { oAction + oSymbol };
                Gen_Tools.Start_Generic_Methods(_Object_Mgr, "Action_Execute", oArg, out oResult);


                this.OLV_Objects.RefreshObject(e.Model);
                

            }
            catch (Exception ex) { string oDebug = ex.Message; }

        }

        private void OLV_Objects_Filtered_ButtonClick(object sender, CellClickEventArgs e)
        {
            try
            {
                int oRowindes = e.RowIndex;
                object oSubitem = e.SubItem;
                object oModel = e.Model;
                object oobject = (object)e.Model;
                object oResult = null;
                string oSymbol = Gen_Tools.Get_Properie_String_By_Name(oobject, "Symbol");
                string oAction = Gen_Tools.Get_Properie_String_By_Name(oobject, "Action");

                object[] oArg = { oAction + oSymbol };
                Gen_Tools.Start_Generic_Methods(_Object_Mgr, "Action_Execute", oArg, out oResult);


                this.OLV_Objects.RefreshObject(e.Model);


            }
            catch (Exception ex) { string oDebug = ex.Message; }
        }

        private void OLV_Objects_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                object oModel = OLV_Objects.SelectedObject;
                

            }
            catch (Exception ex) { string oDebug = ex.Message; }
        }
       

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            object oResult = null;
            object[] oArg = {};
            Gen_Tools.Start_Generic_Methods(_Object_Mgr, "Refresh", oArg, out oResult);
            
            Refresh_Objects();
        }

        private void button_Load_Browser_Click(object sender, EventArgs e)
        {
            try
            {
                object oModel = OLV_Objects.SelectedObject;
                object oobject = (object)oModel;
                string oSymbol = Gen_Tools.Get_Properie_String_By_Name(oobject, "Symbol");
                string oAction = "Load_Browser";

                object[] oArg = { oAction + oSymbol };
                object oResult = null;
                Gen_Tools.Start_Generic_Methods(_Object_Mgr, "Action_Execute", oArg, out oResult);


            }
            catch (Exception ex) { string oDebug = ex.Message; }
        }

        private void button_Start_Update_All_Click(object sender, EventArgs e)
        {
            string oAction = "Start_Updating_All_From_Web";

            object[] oArg = { oAction };
            object oResult = null;
            Gen_Tools.Start_Generic_Methods(_Object_Mgr, "Action_Execute", oArg, out oResult);
        }

        private void button_Stop_Update_All_Click(object sender, EventArgs e)
        {
            string oAction = "Stop_Updating_All_From_Web";

            object[] oArg = { oAction };
            object oResult = null;
            Gen_Tools.Start_Generic_Methods(_Object_Mgr, "Action_Execute", oArg, out oResult);
        }

        private void button_Get_All_Forecast_Properties_Click(object sender, EventArgs e)
        {
            object oModel = OLV_Objects.SelectedObject;
            if (oModel==null) 
            {
                if (List_Of_Objects==null) { return;   }
                if (List_Of_Objects.Count<1) { return; }
                oModel = List_Of_Objects[0];
            }
            //object oobject = (object)oModel;
            propertyGrid_Symbol.SelectedObject = oModel;

            try 
            {
                TabPage oPropTab = tabControl_Symbols.TabPages["tabPage_Symbol_Properties"];
                tabControl_Symbols.SelectedTab = oPropTab;
                //tabControl_Symbo_Properties
            }
            catch (Exception ex) { string oDebug = ex.Message; }
            //string oSymbol = Gen_Tools.Get_Properie_String_By_Name(oobject, "Symbol");
            //string oAction = "Get_ForecastsObject_Properties";

            //object[] oArg = { oAction + oSymbol };
            //object oResult = null;
            //Gen_Tools.Start_Generic_Methods(_Object_Mgr, "Action_Execute", oArg, out oResult);
        }

        private void button_Apply_Filter_Click(object sender, EventArgs e)
        {
            Apply_Filter(comboBox_Parameters.Text, textBox_Filter_Value.Text, comboBox_Condition.Text);

            OLV_Objects_Filtered.SetObjects(List_Of_Filtered_Objects);
            Refresh_Objects();
        }
        private void button_Continue_Filter_Click(object sender, EventArgs e)
        {
            Continue_Filter(comboBox_Parameters.Text, textBox_Filter_Value.Text, comboBox_Condition.Text);

            OLV_Objects_Filtered.SetObjects(List_Of_Filtered_Objects);
            Refresh_Objects();
        }
        private void button_Apply_Generic_Filter_Click(object sender, EventArgs e)
        {
            button_Refresh_Click(null, null);
        }

        public bool Apply_Filter(string oParameter_Name, string oParameter_Value, string oCondition)
        {
            //WalletInvestorObject oObject = new WalletInvestorObject();
            bool oIsSucsecfull = false;
            double oDouble_Value = 0;
            try
            {
                oDouble_Value = Gen_Tools.String_To_Double(oParameter_Value, 5, ref oIsSucsecfull);
                if (oIsSucsecfull) 
                {
                    if (oCondition == ">") { List_Of_Filtered_Objects = List_Of_Objects.FindAll(X => Gen_Tools.GetValue_ByPropertieName_As_Double(X, oParameter_Name) > oDouble_Value); }
                    if (oCondition == "<") { List_Of_Filtered_Objects = List_Of_Objects.FindAll(X => Gen_Tools.GetValue_ByPropertieName_As_Double(X, oParameter_Name) < oDouble_Value); }
                    if (oCondition == "=") { List_Of_Filtered_Objects = List_Of_Objects.FindAll(X => Gen_Tools.GetValue_ByPropertieName_As_Double(X, oParameter_Name) == oDouble_Value); }
                }
                else
                {
                    if (oCondition == "=") { List_Of_Filtered_Objects = List_Of_Objects.FindAll(X => Gen_Tools.GetValue_ByPropertieName_As_Object(X, oParameter_Name,out oIsSucsecfull).ToString() == oParameter_Value); }

                }
                return true;
            }
            catch (Exception ex) { string oDebug = ex.Message; }

            return true;
        }

        public bool Continue_Filter(string oParameter_Name, string oParameter_Value, string oCondition)
        {
            List<object> oList_Of_Filtered_Objects = new List<object>();
            bool oIsSucsecfull = false;
            double oDouble_Value = 0;
            try
            {
                oDouble_Value = Gen_Tools.String_To_Double(oParameter_Value, 5, ref oIsSucsecfull);
                if (oCondition == ">") { oList_Of_Filtered_Objects = List_Of_Filtered_Objects.FindAll(X => Gen_Tools.GetValue_ByPropertieName_As_Double(X, oParameter_Name) > oDouble_Value); }
                if (oCondition == "<") { oList_Of_Filtered_Objects = List_Of_Filtered_Objects.FindAll(X => Gen_Tools.GetValue_ByPropertieName_As_Double(X, oParameter_Name) < oDouble_Value); }
                if (oCondition == "=") { oList_Of_Filtered_Objects = List_Of_Filtered_Objects.FindAll(X => Gen_Tools.GetValue_ByPropertieName_As_Double(X, oParameter_Name) == oDouble_Value); }
                List_Of_Filtered_Objects = oList_Of_Filtered_Objects;
                return true;
            }
            catch (Exception ex) { string oDebug = ex.Message; }

            return true;
        }

        private void textBox_Generic_Filter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<IModelFilter> filters = new List<IModelFilter>();
                if (!String.IsNullOrEmpty(this.textBox_Generic_Filter.Text))
                    filters.Add(new TextMatchFilter(this.OLV_Objects, this.textBox_Generic_Filter.Text));

                this.OLV_Objects.AdditionalFilter = filters.Count == 0 ? null : new CompositeAllFilter(filters);

            }

            catch (Exception ex) { string oDebug = ex.Message; }

        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<IModelFilter> filters = new List<IModelFilter>();
                if (!String.IsNullOrEmpty(this.textBoxFilter.Text))
                    filters.Add(new TextMatchFilter(this.OLV_Objects_Filtered, this.textBoxFilter.Text));

                this.OLV_Objects_Filtered.AdditionalFilter = filters.Count == 0 ? null : new CompositeAllFilter(filters);

            }

            catch (Exception ex) { string oDebug = ex.Message; }

        }
        private void comboBox_Parameters_Columns_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_Header_Text.Text= comboBox_Parameters_Columns.Text;
            textBox_ToolTipText.Text = comboBox_Parameters_Columns.Text;
        }
        private void textBox_Header_Text_Validated(object sender, EventArgs e)
        {
            int oWidth = textBox_Header_Text.Text.Length * 10;
            textBox_Width.Text = oWidth.ToString();
        }

        private void button_Add_Column_For_Propertie_Click(object sender, EventArgs e)
        {
            if (OLV_Mgr_Object==null) { return;   }
            string oAspectName = comboBox_Parameters_Columns.Text;
            string oHeader_Text = textBox_Header_Text.Text;
            string oAspectToStringFormat = "";
            if (comboBox_AspectToStringFormat.Text == "Number") { oAspectToStringFormat = "{0:N}"; }
            bool oSucsessfull = false;
           
            int oIndex= Gen_Tools.String_To_Integer(textBox_Column_Index.Text, ref oSucsessfull);
            if (!oSucsessfull) { oIndex = 0;  }

            int oWidth = Gen_Tools.String_To_Integer(textBox_Width.Text, ref oSucsessfull);
            if (!oSucsessfull) { textBox_Width.Text = 40.ToString(); oWidth = 40; }

            int oMinWidth = Gen_Tools.String_To_Integer(textBox_Minimal_Width.Text, ref oSucsessfull);
            if (!oSucsessfull) { textBox_Minimal_Width.Text = 40.ToString(); oWidth = 40; }

            //string oColumnNameSuffix = "";

            Utilities.PropertieColumn oPropertieColumn = OLV_Mgr_Object.List_Of_PropertieColumn.Find(x => x.AspectName == oAspectName);
            if (oPropertieColumn != null)
            {
                DialogResult dialogResult = MessageBox.Show("Create Duplicate Column?", "Colum for same parameter exist", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                   //continue
                   
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;

                }
            }

            oPropertieColumn = new Utilities.PropertieColumn();
            oPropertieColumn.Propertie_Name = oAspectName;
            oPropertieColumn.Text = oHeader_Text;
            oPropertieColumn.Width = oWidth;
            //oPropertieColumn.MinimumWidth = oMinWidth;
            oPropertieColumn.AspectToStringFormat = oAspectToStringFormat;
            OLV_Mgr_Object.List_Of_PropertieColumn.Add(oPropertieColumn);
            Add_Column(oPropertieColumn);
            List_Of_Colums_AspectName();
            Refresh_Objects();

            //try
            //{

            //    //List<ColumnHeader> oList_ColumnHeader = new List<ColumnHeader>();
            //    OLVColumn oNewOLVColumn = new OLVColumn();

            //    object oSource = OLV_Objects.Columns[4];
            //    object oDest = oNewOLVColumn;
            //    //string oReportLog = "";
            //    Gen_Tools.Update_All_Properties_By_Object(ref oDest, oSource);//,out  oReportLog);
            //    oNewOLVColumn.Name = "olvColumn_" + oAspectName + oColumnNameSuffix;
            //    oNewOLVColumn.AspectName = oAspectName;
            //    oNewOLVColumn.AspectToStringFormat = oAspectToStringFormat;
            //    oNewOLVColumn.Width = oWidth;
            //    oNewOLVColumn.MinimumWidth = oMinWidth;
            //    oNewOLVColumn.Text = oHeader_Text;
            //    oNewOLVColumn.ToolTipText = oAspectName;

            //    OLV_Objects.AllColumns.Add(oNewOLVColumn);
            //    OLV_Mgr_Object.List_Of_OLVColumns.Add(oNewOLVColumn);

            //    OLV_Objects.Columns.AddRange(OLV_Mgr_Object.List_Of_OLVColumns.ToArray());
            //    OLV_Objects.CheckBoxes = false;
            //    Refresh_Objects();
            //}
            //catch (Exception ex) { string oDebug = ex.Message; }

        }

        private void Add_Column(Utilities.PropertieColumn oPropertieColumn, bool oDuplicates_Not_Allowed = true )
        {
            if (oPropertieColumn==null) { return;   }
            try
            {

                if (oDuplicates_Not_Allowed)
                {
                    foreach (OLVColumn oOLVColumn in OLV_Objects.Columns)
                    {
                        if (oOLVColumn.AspectName == oPropertieColumn.AspectName) { return; }
                    }
                }
                //List<ColumnHeader> oList_ColumnHeader = new List<ColumnHeader>();
                OLVColumn oNewOLVColumn = new OLVColumn();
                OLVColumn oNewOLVColumn2 = new OLVColumn();

                //object oSource = OLV_Objects.Columns[4];
                object oSource = oPropertieColumn;
                object oDest = oNewOLVColumn;
                //string oReportLog = "";
                Gen_Tools.Update_All_Properties_By_Object( oDest, oSource);//,out  oReportLog);

                OLV_Objects.AllColumns.Add(oNewOLVColumn);
                OLV_Objects.Columns.Add(oNewOLVColumn);
                OLV_Objects.CheckBoxes = false;

                oDest = oNewOLVColumn2;
                Gen_Tools.Update_All_Properties_By_Object( oDest, oSource);//,out  oReportLog);

                OLV_Objects_Filtered.AllColumns.Add(oNewOLVColumn);
                OLV_Objects_Filtered.Columns.Add(oNewOLVColumn);
                OLV_Objects_Filtered.CheckBoxes = false;

            }
            catch (Exception ex) { string oDebug = ex.Message; }

        }

        private List<string> List_Of_Colums_AspectName()
        {
            List<string> oList = new List<string>();
            List<string> oList_Index = new List<string>();
            int oIndex = 0;
            try 
            {
                foreach (OLVColumn oOLVColumn in OLV_Objects.Columns)
                {
                    oList.Add(oOLVColumn.AspectName);
                    oList_Index.Add(oIndex.ToString());
                    oIndex  = oIndex + 1;
                }
                Gen_Tools.ComboBox_Create_Items_List_of_String(comboBox_Existing_Columns, oList);
                Gen_Tools.ComboBox_Create_Items_List_of_String(comboBox_Column_Index, oList_Index);
                comboBox_Existing_Columns.SelectedIndex = comboBox_Existing_Columns.Items.Count-1;
            }
            catch (Exception ex) { string oDebug = ex.Message; }

            return oList;
        }

        private void button_Delete_Column_Click(object sender, EventArgs e)
        {
            
            foreach (OLVColumn oOLVColumn in OLV_Objects.Columns)
            {
                if (oOLVColumn.AspectName == comboBox_Existing_Columns.Text) 
                { 
                    OLV_Objects.Columns.Remove(oOLVColumn);
                    OLV_Objects.AllColumns.Remove(oOLVColumn);
                    
                    break;
                }
               
            }

            foreach (OLVColumn oOLVColumn in OLV_Objects_Filtered.Columns)
            {
                if (oOLVColumn.AspectName == comboBox_Existing_Columns.Text)
                {
                    OLV_Objects_Filtered.Columns.Remove(oOLVColumn);
                    OLV_Objects_Filtered.AllColumns.Remove(oOLVColumn);

                    break;
                }

            }
            List_Of_Colums_AspectName();
            Refresh_Objects();
        }

        private void button_Move_To_New_Index_Click(object sender, EventArgs e)
        {
            bool oresutl = false;
            int oIndex = Gen_Tools.String_To_Integer(comboBox_Column_Index.Text, ref oresutl);
            if (!oresutl) { return;  }
            foreach (OLVColumn oOLVColumn in OLV_Objects.Columns)
            {
                if (oOLVColumn.AspectName == comboBox_Existing_Columns.Text)
                {
                    oOLVColumn.DisplayIndex = oIndex;
                    Utilities.PropertieColumn oPropertieColumn = OLV_Mgr_Object.List_Of_PropertieColumn.Find(x => x.AspectName == oOLVColumn.AspectName);
                    if (oPropertieColumn != null)
                    {
                        if (oIndex< OLV_Mgr_Object.List_Of_PropertieColumn.Count) 
                        {
                            OLV_Mgr_Object.List_Of_PropertieColumn.Remove(oPropertieColumn);
                            OLV_Mgr_Object.List_Of_PropertieColumn.Insert(oIndex, oPropertieColumn);
                        }
                        
                    }
                    break;
                }
                   
                
            }

            foreach (OLVColumn oOLVColumn in OLV_Objects_Filtered.Columns)
            {
                if (oOLVColumn.AspectName == comboBox_Existing_Columns.Text)
                {
                    oOLVColumn.DisplayIndex = oIndex;
                   
                    break;
                }


            }

            List_Of_Colums_AspectName();
            Refresh_Objects();
        }

        private void button_Save_Current_Columns_Click(object sender, EventArgs e)
        {
            OLV_Mgr_Object.List_Of_PropertieColumn.Clear();
            foreach (OLVColumn oOLVColumn in OLV_Objects.Columns)
            {
                try 
                {
                    Utilities.PropertieColumn oPropertieColumn = new Utilities.PropertieColumn();
                    object oSource = oOLVColumn;
                    object oDest = oPropertieColumn;
                    //string oReportLog = "";
                    Gen_Tools.Update_All_Properties_By_Object( oDest, oSource);//,out  oReportLog);
                    oPropertieColumn.Propertie_Name = oOLVColumn.AspectName;
                    OLV_Mgr_Object.List_Of_PropertieColumn.Add(oPropertieColumn);
                }
                catch (Exception ex) { string oDebug = ex.Message; }
                

            }
        }
    }


}
