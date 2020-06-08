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
        public OLVMgr OLV_Mgr
        {
            get { return _OLVMgr; }
            set
            {
                _OLVMgr = value;
                if (value != null)
                {
                    this.InitializeTab();
                    //this.SetupGeneralListViewEvents();
                }
            }
        }
        private OLVMgr _OLVMgr;
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
        //private BindingSource Objects_BindingSource = new BindingSource();


        public OLVYahooControl()
        {
            InitializeComponent();
            this.ListView = this.OLV_Objects;

            try
            {
                List<ColumnHeader> oList_ColumnHeader = new List<ColumnHeader>();
                foreach (OLVColumn oOLVColumn in OLV_Objects.AllColumns)
                {
                    if (oOLVColumn.Name== "olvColumnAction") { continue;   }
                    OLVColumn oNewOLVColumn = new OLVColumn();
                    object oSource = oOLVColumn;
                    object oDest = oNewOLVColumn;
                    //string oReportLog = "";
                    Gen_Tools.Update_All_Properties_By_Object(ref oDest, oSource);//,out  oReportLog);
                    OLV_Objects_Filtered.AllColumns.Add(oNewOLVColumn);
                    oList_ColumnHeader.Add(oNewOLVColumn);

                }
                OLV_Objects_Filtered.Columns.AddRange(oList_ColumnHeader.ToArray());
                OLV_Objects_Filtered.CheckBoxes = false;
            }
            catch (Exception ex) { string oDebug = ex.Message; }

        }

        public void Set_List_Of_Object(List<object> oList_Of_Object, object oObject_Mgr)
        {
            _Object_Mgr = oObject_Mgr;
            List_Of_Objects = oList_Of_Object;
            this.OLV_Objects.SetObjects(List_Of_Objects);
            OLV_Objects.CheckBoxes = false;
            
            SetupColumnWithButton();
            try 
            {
                List<string> oList = Parameters_List();
                if (oList.Count>0) 
                {
                    Gen_Tools.ComboBox_Create_Items_List_of_String(comboBox_Parameters, oList);
                    comboBox_Parameters.SelectedIndex = 0;
                    comboBox_Condition.SelectedIndex = 1;
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
                Gen_Tools.Bind_To_Propertie_Async(comboBox_Parameters, "Text", _Object_Mgr, "Filter_Name", false, oClear: true);
                //comboBox_Condition
                Gen_Tools.Bind_To_Propertie_Async(comboBox_Condition, "Text", _Object_Mgr, "Filter_Condition", false, oClear: true);
                //textBox_Filter_Value
                Gen_Tools.Bind_To_Propertie_Async(textBox_Filter_Value, "Text", _Object_Mgr, "Filter_Value_String", false, oClear: true);

                Gen_Tools.Bind_To_Propertie_Async(textBox_Elev_Average1, "Text", _Object_Mgr, "Elevation_Average", true,oClear:true);

                Gen_Tools.Bind_To_Propertie_Async(textBox_Elev_Average2, "Text", _Object_Mgr, "Elevation_Average",true, oClear: true);

                //         public string Filter_Name { get; set; } = "Name";
                //public string Filter_Condition { get; set; } = "=";
                //public double Filter_Level { get; set; } = 3;
                //public double Filter_Value { get; set; } = 0
            }
            catch (Exception ex) { string oDebug = ex.Message; }
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
                if (oCondition == ">") { List_Of_Filtered_Objects = List_Of_Objects.FindAll(X => Gen_Tools.GetValue_ByPropertieName_As_Double(X, oParameter_Name) > oDouble_Value); }
                if (oCondition == "<") { List_Of_Filtered_Objects = List_Of_Objects.FindAll(X => Gen_Tools.GetValue_ByPropertieName_As_Double(X, oParameter_Name) < oDouble_Value); }
                if (oCondition == "=") { List_Of_Filtered_Objects = List_Of_Objects.FindAll(X => Gen_Tools.GetValue_ByPropertieName_As_Double(X, oParameter_Name) == oDouble_Value); }
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

      
    }


}
