using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using GenericTools.Controllers;
using BrightIdeasSoftware;
using OLVTools2020.Utilities;
using System.Linq;

namespace OLVTools2020
{
    public partial class OLVSymbolsControl : UserControl
    {

        public const string TimeFormat_yyyy_MM_dd = "yyyy'-'MM'-'dd";
        private object _Object_Mgr;
        private GenericTools.Tools Gen_Tools = new GenericTools.Tools();
        public GenericTools.Files.FileObject File_Object { get; set; } = new GenericTools.Files.FileObject();
        public string Current_Directory { get { return System.IO.Directory.GetCurrentDirectory(); } }
        public string Parent_Directory { get { return System.IO.Directory.GetParent(Current_Directory).FullName; } }

        private System.Drawing.Color Green_Color = System.Drawing.Color.Green;
        private System.Drawing.Color Yellow_Color = System.Drawing.Color.Yellow;
        private System.Drawing.Color Red_Color = System.Drawing.Color.Salmon;
        private System.Drawing.Color Original_Button_BackColor = System.Drawing.Color.Transparent;
        public bool Symbols_Update_InProgress { get; private set; } = false;
        public bool Symbols_Update_Paused { get; private set; } = false;

        public GenericTools.SettingsManager Settings_Mgr;

        //public List<PropertieColumn> List_Of_Visible_Columns_Sorted { get; set; } = new List<PropertieColumn>();

        public event EventHandler SelectedIndexChanged_Event;
        public void Raise_SelectedIndexChanged_Event(object sender, EventArgs e)
        {
            SelectedIndexChanged_Event?.Invoke(sender,e);
        }

        public List<object> List_Of_Objects { get; private set; } = new List<object>();
        public List<object> List_Of_Filtered_Objects { get; private set; } = new List<object>();

        public Utilities.OLVMgrObject OLV_Mgr_Object = new Utilities.OLVMgrObject();
        public double Elev_Average_Filtered { get;  set; } = 0;
        
        

        public OLVSymbolsControl()
        {
            InitializeComponent();
            Symbols_Update_InProgress = false;
            Symbols_Update_Paused = false;
            try 
            {
                File_Object.Name_No_Extension =DateTime.Now.ToString(TimeFormat_yyyy_MM_dd)+ "-Columns_Layout";
                File_Object.Extension = ".columns";
                File_Object.DirectoryName = Parent_Directory;
                Settings_Mgr = new GenericTools.SettingsManager(File_Object.FullFile_Name);
            }
            catch (Exception ex) { string oDebug = ex.Message; }
        }

        public void Initial_Set_List_Of_Object(List<object> oList_Of_Object, object oObject_Mgr)
        {
            try 
            {
                _Object_Mgr = oObject_Mgr;
                List_Of_Objects = oList_Of_Object;
                
                this.OLV_Objects.SetObjects(List_Of_Objects);
                OLV_Objects.CheckBoxes = false;
                Original_Button_BackColor = button_Start_Q.BackColor;
            }
            catch (Exception ex) { string oDebug = ex.Message; }
            
            //if (!_Is_It_First_run) { Refresh_Objects(); return;  }
            //_Is_It_First_run = true;

            try
            {
                bool oGood = false;
                object oObject = Gen_Tools.GetValue_ByPropertieName_As_Object(_Object_Mgr, "OLV_Mgr_Object", out oGood);
                if (oGood) { OLV_Mgr_Object = oObject as Utilities.OLVMgrObject; }
                //                List_Of_SymbolObject.Sort((x, y) => Gen_Tools.GetValue_ByPropertieName_As_Double(x, oSortingParameter).CompareTo(Gen_Tools.GetValue_ByPropertieName_As_Double(y, oSortingParameter)));

                OLV_Mgr_Object.List_Of_PropertieColumn.Sort((x,y)=> (x.DisplayIndex).CompareTo(y.DisplayIndex));
                //OLV_Mgr_Object.List_Of_PropertieColumn.Sort((x, y) => (x.IsVisible).CompareTo(y.IsVisible));

                foreach (Utilities.PropertieColumn oPropertieColumn in OLV_Mgr_Object.List_Of_PropertieColumn)
                {

                    if (oPropertieColumn.IsVisible) { OLVColumn oNewOLVColumn = OLV_Add_Column(OLV_Objects, oPropertieColumn); } 

                }

                foreach (Utilities.PropertieColumn oPropertieColumn in OLV_Mgr_Object.List_Of_PropertieColumn)
                {

                    if (!oPropertieColumn.IsVisible) { OLVColumn oNewOLVColumn = OLV_Add_Column(OLV_Objects, oPropertieColumn); }

                }

                ////List_Of_Filtered_Objects=
                //foreach (OLVColumn oOLVColumn in OLV_Objects.Columns)
                //{
                //    Utilities.PropertieColumn oPropertieColumn = OLV_Mgr_Object.List_Of_PropertieColumn.Find(x => x.AspectName == oOLVColumn.AspectName);
                //    try
                //    {
                //        if (oPropertieColumn != null) { oOLVColumn.DisplayIndex = oPropertieColumn.DisplayIndex; }

                //    }
                //    catch (Exception ex) { string oDebug = ex.Message; }

                //}

            }
            catch (Exception ex) { string oDebug = ex.Message; }

            try
            {
                List<string> oList = Parameters_List();
                if (oList.Count > 0)
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
                SetupColumnWithButton();
                List_Of_Colums_AspectName();
                Refresh_Objects();
            }
            catch (Exception ex) { string oDebug = ex.Message; }

            
        }


        public void Update_List_Of_Object() //List<object> oList_Of_Object)//, object oObject_Mgr)
        {
            try
            {
                List<GenericTools.SymbolObject> oList_Of_SymbolObject;// = new List<GenericTools.SymbolObject>();
                object oList_Of_Objects_Temp;
                object[] oArg = { };
                Gen_Tools.Start_Generic_Methods(_Object_Mgr, "Get_List_Of_Object", oArg, out oList_Of_Objects_Temp);
                oList_Of_SymbolObject = oList_Of_Objects_Temp as List<GenericTools.SymbolObject>;
                List_Of_Objects= oList_Of_SymbolObject.Cast<object>().ToList();
                this.OLV_Objects.SetObjects(List_Of_Objects);


                //List<object> oTemp = oList_Of_SymbolObject.Cast<object>().ToList();

                //List_Of_Objects = oTemp;
                //this.OLV_Objects.SetObjects(oTemp);


                //// workign public void Update_List_Of_Object(List<object> oList_Of_Object)//, object oObject_Mgr)
                ////-Workign 
                //List_Of_Objects = oList_Of_Object;

                //List<object> oListTemp = oList_Of_Object as List<object>;
                //this.OLV_Objects.SetObjects(oListTemp);
                ////-Workign 
            }
            catch (Exception ex) { string oDebug = ex.Message; }

            
            try
            {
                //SetupColumnWithButton();
                //List_Of_Colums_AspectName();
                Refresh_Objects();
            }
            catch (Exception ex) { string oDebug = ex.Message; }

        }


        public List<string> Parameters_List()
        {
            List<string> oList = new List<string>();
            try
            {
                object oObject = List_Of_Objects[0];

                oList = Gen_Tools.Get_Properties_List(oObject);
               
            }
            catch (Exception ex) { string oDebug = ex.Message; }
            return oList;
        }

        public void Refresh_Objects()
        {
            try
            {
                bool oResutl = false;

                Gen_Tools.Bind_To_Propertie_Async(total_SymbolsTextBox, "Text", OLV_Mgr_Object, "Total_Symbols", false, oClear: true);

                Gen_Tools.Bind_To_Propertie_Async(symbols_ProcessedTextBox, "Text", OLV_Mgr_Object, "Symbols_Processed", false, oClear: true);

                Gen_Tools.Bind_To_Propertie_Async(last_SymbolTextBox, "Text", OLV_Mgr_Object, "Last_Symbol", false, oClear: true);

                Gen_Tools.Bind_To_Propertie_Async(textBox_Elev_Average1, "Text", OLV_Mgr_Object, "Elevation_Average", true, oClear: true);

                Gen_Tools.Bind_To_Propertie_Async(textBox_Elev_Average2, "Text", OLV_Mgr_Object, "Elevation_Average", true, oClear: true);

                Gen_Tools.Bind_To_Propertie_Async(comboBox_Parameters, "Text", OLV_Mgr_Object, "Filter_Name", false, oClear: true);

                Gen_Tools.Bind_To_Propertie_Async(comboBox_Condition, "Text", OLV_Mgr_Object, "Filter_Condition", false, oClear: true);

                Gen_Tools.Bind_To_Propertie_Async(textBox_Filter_Value, "Text", OLV_Mgr_Object, "Filter_Value", false, oClear: true);
                
                Gen_Tools.Bind_To_Propertie_Async(textBox_Sorting_Parameter, "Text", OLV_Mgr_Object, "Sorting_Parameter", false, oClear: true);

                Gen_Tools.Bind_To_Propertie_Async(textBox_In_Q, "Text", OLV_Mgr_Object, "In_Q", false, oClear: true);

                Gen_Tools.Bind_To_Propertie_Async(textBox_Updating_Seconds, "Text", OLV_Mgr_Object, "Updating_Seconds", true, oClear: true);

                Gen_Tools.Bind_To_Propertie_Async(textBox_Updating_Minutes, "Text", OLV_Mgr_Object, "Updating_Minutess", true, oClear: true);

                Symbols_Update_InProgress = (bool) Gen_Tools.GetValue_ByPropertieName_As_Object(_Object_Mgr, "Symbols_Update_InProgress",out oResutl);

                Symbols_Update_Paused = (bool)Gen_Tools.GetValue_ByPropertieName_As_Object(_Object_Mgr, "Symbols_Update_Paused", out oResutl);

                if (Symbols_Update_InProgress) 
                { 
                    Gen_Tools.Update_Control_BackColor(button_Start_Q, Green_Color);
                    Gen_Tools.Update_Control_BackColor(button_Stop_Q, Original_Button_BackColor);
                    Gen_Tools.Update_Control_BackColor(button_Pause_Q, Original_Button_BackColor);
                }
                else 
                {
                    Gen_Tools.Update_Control_BackColor(button_Start_Q, Original_Button_BackColor);
                    Gen_Tools.Update_Control_BackColor(button_Stop_Q, Red_Color);
                   
                    if (Symbols_Update_Paused) { Gen_Tools.Update_Control_BackColor(button_Pause_Q, Red_Color); }
                    else { Gen_Tools.Update_Control_BackColor(button_Pause_Q, Original_Button_BackColor); }
                }

            }
            catch (Exception ex) { string oDebug = ex.Message; }

            OLV_Objects.RefreshObjects(List_Of_Objects);
            OLV_Objects_Filtered.RefreshObjects(List_Of_Filtered_Objects);

        }


        private bool OLV_Objects_Filtered_Initilized=false;

        public void Setup_OLV_Objects_Filtered()
        {
            if (OLV_Objects_Filtered_Initilized) { return;  }
            OLV_Objects_Filtered_Initilized = true;
            try
            {
                List<ColumnHeader> oList_ColumnHeader = new List<ColumnHeader>();
                foreach (OLVColumn oOLVColumn in OLV_Objects.AllColumns)
                {
                    //if (oOLVColumn.Name == "olvColumnAction") { continue; }
                    OLVColumn oNewOLVColumn = new OLVColumn();
                    object oSource = oOLVColumn;
                    object oDest = oNewOLVColumn;
                    //string oReportLog = "";
                    Gen_Tools.Update_All_Properties_By_Object( oDest, oSource);//,out  oReportLog);
                    OLV_Objects_Filtered.AllColumns.Add(oNewOLVColumn);
                    oList_ColumnHeader.Add(oNewOLVColumn);

                }
                OLV_Objects_Filtered.Columns.AddRange(oList_ColumnHeader.ToArray());
                OLV_Objects_Filtered.CheckBoxes = false;
                OLV_Objects_Filtered.ButtonClick += OLV_Objects_ButtonClick;
                List_Of_Filtered_Objects = List_Of_Objects;
            }
            catch (Exception ex) { string oDebug = ex.Message; }

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
                    if (oCondition == "<>") { List_Of_Filtered_Objects = List_Of_Objects.FindAll(X => Gen_Tools.GetValue_ByPropertieName_As_Double(X, oParameter_Name) != oDouble_Value); }

                }
                else
                {
                    if (oCondition == "=") { List_Of_Filtered_Objects = List_Of_Objects.FindAll(X => Gen_Tools.GetValue_ByPropertieName_As_Object(X, oParameter_Name, out oIsSucsecfull).ToString().ToUpper() == oParameter_Value.ToUpper()); }
                    if (oCondition == "<>") { List_Of_Filtered_Objects = List_Of_Objects.FindAll(X => Gen_Tools.GetValue_ByPropertieName_As_Object(X, oParameter_Name, out oIsSucsecfull).ToString().ToUpper() != oParameter_Value.ToUpper()); }
                    if (oCondition == "Contains") { List_Of_Filtered_Objects = List_Of_Objects.FindAll(X => Gen_Tools.GetValue_ByPropertieName_As_Object(X, oParameter_Name, out oIsSucsecfull).ToString().ToUpper().Contains(oParameter_Value.ToUpper())); }

                }

                double ovalue = 0;
                try
                {
                    int oDevider = 0;
                    double oSum = 0;
                    foreach (GenericTools.SymbolObject oSymbolObject in List_Of_Filtered_Objects)
                    {
                        oSum = oSum + oSymbolObject.Elevation_52_Weeks;
                        if (oSymbolObject.Elevation_52_Weeks != 0) { oDevider = oDevider + 1; }
                    }
                    if (oDevider > 0) { ovalue = oSum / oDevider; Elev_Average_Filtered = ovalue; }
                    Gen_Tools.Bind_To_Propertie_Async(textBox_Elev_Average_Filtered, "Text", this, "Elev_Average_Filtered", true, oClear: true);

                }
                catch (Exception ex) { string oDebug = ex.Message; }




                return true;
            }
            catch (Exception ex) { string oDebug = ex.Message; }

            return true;
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
            //this.olvColumnAction.AspectName = "Action";
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
            //ParentForm.FormClosing += ParentForm_FormClosing;
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
                
                object[] oArg = { oAction + oSymbol,null };
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
                Raise_SelectedIndexChanged_Event(oModel, e);

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

                object[] oArg = { oAction + oSymbol,null };
                object oResult = null;
                Gen_Tools.Start_Generic_Methods(_Object_Mgr, "Action_Execute", oArg, out oResult);


            }
            catch (Exception ex) { string oDebug = ex.Message; }
        }

        private void button_Add_All_To_Q_Click(object sender, EventArgs e)
        {
            string oAction = "Add_All_To_Q";

            object[] oArg = { oAction,null };
            object oResult = null;
            Gen_Tools.Start_Generic_Methods(_Object_Mgr, "Action_Execute", oArg, out oResult);
            Gen_Tools.Update_Control_BackColor(button_Start_Q, Green_Color);
            Gen_Tools.Update_Control_BackColor(button_Stop_Q, Original_Button_BackColor);
            Gen_Tools.Update_Control_BackColor(button_Pause_Q, Original_Button_BackColor);


            if (Symbols_Update_InProgress)
            {
                Gen_Tools.Update_Control_BackColor(button_Start_Q, Green_Color);
                Gen_Tools.Update_Control_BackColor(button_Stop_Q, Red_Color);
                Gen_Tools.Update_Control_BackColor(button_Pause_Q, Yellow_Color);
            }
            else
            {
                Gen_Tools.Update_Control_BackColor(button_Start_Q, Original_Button_BackColor);
                Gen_Tools.Update_Control_BackColor(button_Stop_Q, Original_Button_BackColor);

                if (Symbols_Update_Paused) { Gen_Tools.Update_Control_BackColor(button_Pause_Q, Red_Color); }
                else { Gen_Tools.Update_Control_BackColor(button_Pause_Q, Original_Button_BackColor); }
            }

        }

        private void button_Start_Q_Click(object sender, EventArgs e)
        {
            string oAction = "Start_Q";

            object[] oArg = { oAction,null };
            object oResult = null;
            Gen_Tools.Start_Generic_Methods(_Object_Mgr, "Action_Execute", oArg, out oResult);
            Gen_Tools.Update_Control_BackColor(button_Start_Q, Green_Color);
            Gen_Tools.Update_Control_BackColor(button_Stop_Q, Original_Button_BackColor);
            Gen_Tools.Update_Control_BackColor(button_Pause_Q, Original_Button_BackColor);
        }

        private void button_Pause_Q_Click(object sender, EventArgs e)
        {
            string oAction = "Pause_Q";

            object[] oArg = { oAction,null };
            object oResult = null;
            Gen_Tools.Start_Generic_Methods(_Object_Mgr, "Action_Execute", oArg, out oResult);
            Gen_Tools.Update_Control_BackColor(button_Start_Q, Original_Button_BackColor);
            Gen_Tools.Update_Control_BackColor(button_Stop_Q, Original_Button_BackColor);
            Gen_Tools.Update_Control_BackColor(button_Pause_Q, Yellow_Color);

        }

        private void button_Add_To_Update_Q_Click(object sender, EventArgs e)
        {
            string oAction = "Add_Symbols_To_Updating_Q";

            object[] oArg = { oAction , List_Of_Filtered_Objects};
            object oResult = null;
            Gen_Tools.Start_Generic_Methods(_Object_Mgr, "Action_Execute", oArg, out oResult);

            Gen_Tools.Update_Control_BackColor(button_Start_Q, Green_Color);
            Gen_Tools.Update_Control_BackColor(button_Stop_Q, Original_Button_BackColor);
            Gen_Tools.Update_Control_BackColor(button_Pause_Q, Original_Button_BackColor);
        }

        private void button_Incert_To_Update_Q_Click(object sender, EventArgs e)
        {
            string oAction = "Insert_Symbols_To_Updating_Q";

            object[] oArg = { oAction, List_Of_Filtered_Objects };
            object oResult = null;
            Gen_Tools.Start_Generic_Methods(_Object_Mgr, "Action_Execute", oArg, out oResult);

            Gen_Tools.Update_Control_BackColor(button_Start_Q, Green_Color);
            Gen_Tools.Update_Control_BackColor(button_Stop_Q, Original_Button_BackColor);
            Gen_Tools.Update_Control_BackColor(button_Pause_Q, Original_Button_BackColor);
        }


        private void button_Stop_Update_All_Click(object sender, EventArgs e)
        {
            string oAction = "Stop_Updating_Symbols_Q";

            object[] oArg = { oAction,null };
            object oResult = null;
            Gen_Tools.Start_Generic_Methods(_Object_Mgr, "Action_Execute", oArg, out oResult);

            Gen_Tools.Update_Control_BackColor(button_Start_Q, Original_Button_BackColor);
            Gen_Tools.Update_Control_BackColor(button_Stop_Q, Red_Color);
            Gen_Tools.Update_Control_BackColor(button_Pause_Q, Original_Button_BackColor);
            
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

            foreach (OLVColumn oOLVColumn in OLV_Objects_Filtered.Columns)
            {
                if (oOLVColumn.AspectName == "Action")
                {
                    oOLVColumn.IsButton = true;

                    // How will the button be sized? That can either be:
                    //   - FixedBounds. Each button is ButtonSize in size
                    //   - CellBounds. Each button is as wide as the cell, inset by CellPadding
                    //   - TextBounds. Each button resizes to match the width of the text plus ButtonPadding
                    oOLVColumn.ButtonSizing = OLVColumn.ButtonSizingMode.CellBounds;
                    oOLVColumn.ButtonSize = new Size(80, 26);

                    // Make the buttons clickable even if the row itself is disabled
                    oOLVColumn.EnableButtonWhenItemIsDisabled = true;
                    //oOLVColumn.AspectName = "Action";
                    oOLVColumn.TextAlign = HorizontalAlignment.Center;

                    break;
                }
            }
            Refresh_Objects();
        }

        private void button_Continue_Filter_Click(object sender, EventArgs e)
        {
            Continue_Filter(comboBox_Parameters.Text, textBox_Filter_Value.Text, comboBox_Condition.Text);

            OLV_Objects_Filtered.SetObjects(List_Of_Filtered_Objects);
            Refresh_Objects();
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

        private int _Column__Minimal_Width = 10;
        private void button_Add_Column_For_Propertie_Click(object sender, EventArgs e)
        {
            if (OLV_Mgr_Object == null) { return; }
            string oAspectName = comboBox_Parameters_Columns.Text;
            string oName = "OLVColumn_" + oAspectName;
            string oHeader_Text = textBox_Header_Text.Text;
            string oAspectToStringFormat = "";
            if (comboBox_AspectToStringFormat.Text == "Number") { oAspectToStringFormat = "{0:N}"; }
            bool oSucsessfull = false;
            try 
            {
               

                int oIndex = Gen_Tools.String_To_Integer(textBox_Column_Index.Text, ref oSucsessfull);
                if (!oSucsessfull) { oIndex = 0; }

                int oWidth = Gen_Tools.String_To_Integer(textBox_Width.Text, ref oSucsessfull);
                if (!oSucsessfull) { textBox_Width.Text = _Column__Minimal_Width.ToString(); oWidth = _Column__Minimal_Width; }

                int oMinWidth = Gen_Tools.String_To_Integer(textBox_Minimal_Width.Text, ref oSucsessfull);
                if (!oSucsessfull) { textBox_Minimal_Width.Text = _Column__Minimal_Width.ToString(); oWidth = _Column__Minimal_Width; }


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
                oPropertieColumn.AspectName = oAspectName;
                oPropertieColumn.Propertie_Name = oAspectName;
                oPropertieColumn.Name = oName;
                oPropertieColumn.Text = oHeader_Text;
                oPropertieColumn.Width = oWidth;
                oPropertieColumn.AspectToStringFormat = oAspectToStringFormat;
                OLV_Mgr_Object.List_Of_PropertieColumn.Add(oPropertieColumn);
                OLV_Add_Column(OLV_Objects, oPropertieColumn);
                if (OLV_Objects_Filtered_Initilized) { OLV_Add_Column(OLV_Objects_Filtered, oPropertieColumn); }
            }
            catch (Exception ex) { string oDebug = ex.Message; return; }


            List_Of_Colums_AspectName();
            Refresh_Objects();
        }

        private OLVColumn OLV_Add_Column(ObjectListView oObjectListView, Utilities.PropertieColumn oPropertieColumn, bool oDuplicates_Not_Allowed = true )
        {
            if (oPropertieColumn==null) { return null;   }
            if (oObjectListView == null) { return null; }
            try
            {

                if (oDuplicates_Not_Allowed)
                {
                    foreach (OLVColumn oOLVColumn in oObjectListView.AllColumns)
                    {
                        if (oOLVColumn.AspectName == oPropertieColumn.AspectName) { return null; }
                    }
                }
                

                OLVColumn oNewOLVColumn = new OLVColumn();

                oPropertieColumn.PropertieColumn_To_OLVColumn(oNewOLVColumn);
                ////object oSource = OLV_Objects.Columns[4];
                //object oSource = oPropertieColumn;
                //object oDest = oNewOLVColumn;
                ////string oReportLog = "";
                //Gen_Tools.Update_All_Properties_By_Object( oDest, oSource);//,out  oReportLog);

                oObjectListView.AllColumns.Add(oNewOLVColumn);
                //oObjectListView.Columns.Add(oNewOLVColumn);
                if(oPropertieColumn.IsVisible) { oObjectListView.Columns.Add(oNewOLVColumn); } 
                //oNewOLVColumn.Text = oPropertieColumn.Text;
                //oNewOLVColumn.DisplayIndex = oPropertieColumn.DisplayIndex;
                //oNewOLVColumn.Width = oPropertieColumn.Width;
               // oObjectListView.CheckBoxes = false;

                return oNewOLVColumn;
            }
            catch (Exception ex) { string oDebug = ex.Message; }
            return null;
        }

        private void OLV_Objects_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            try 
            {
                ObjectListView oObjectListView = sender as ObjectListView;
                OLVColumn oOLVColumn = oObjectListView.GetColumn(e.Column);
                propertyGrid_Column.SelectedObject = oOLVColumn;
                comboBox_Existing_Columns.Text = oOLVColumn.AspectName;
            }
            catch (Exception ex) { string oDebug = ex.Message; }
        }

        private void comboBox_AspectToStringFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_AspectToStringFormat.Text == "Number") { textBox_AspectToStringFormat.Text = "{0:N}"; }

        }

        private void comboBox_Existing_Columns_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (OLVColumn oOLVColumn in OLV_Objects.AllColumns)
            {
                if (oOLVColumn.AspectName == comboBox_Existing_Columns.Text)
                {
                    propertyGrid_Column.SelectedObject = oOLVColumn;

                    break;
                }

            }
        }
        private List<string> List_Of_Colums_AspectName()
        {
            List<string> oList = new List<string>();
            List<string> oList_Index = new List<string>();
            int oIndex = 0;
            try 
            {
                foreach (OLVColumn oOLVColumn in OLV_Objects.AllColumns)
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
            
            foreach (OLVColumn oOLVColumn in OLV_Objects.AllColumns)
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
            foreach (Utilities.PropertieColumn oOLVColumn in OLV_Mgr_Object.List_Of_PropertieColumn)
            {
                if (oOLVColumn.AspectName == comboBox_Existing_Columns.Text)
                {
                    OLV_Mgr_Object.List_Of_PropertieColumn.Remove(oOLVColumn);

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
            foreach (OLVColumn oOLVColumn in OLV_Objects.AllColumns)
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
            foreach (OLVColumn oOLVColumn in OLV_Objects.AllColumns)
            {
                try 
                {
                    if (oOLVColumn.AspectName=="Symbol") { continue;  }
                    if (oOLVColumn.AspectName == "Action") { continue; }
                    if (oOLVColumn.AspectName == "CompanyName") { continue; }
                    //"CompanyName"

                    Utilities.PropertieColumn oNewPropertieColumn = new Utilities.PropertieColumn();
                    oNewPropertieColumn.OLVColumn_To_PropertieColumn(oOLVColumn);
                    //object oSource = oOLVColumn;
                    //object oDest = oPropertieColumn;

                    //////string oReportLog = "";
                    ////Gen_Tools.Update_All_Properties_By_Object( oDest, oSource);//,out  oReportLog);
                    //oPropertieColumn.Propertie_Name = oOLVColumn.AspectName;

                    OLV_Mgr_Object.List_Of_PropertieColumn.Add(oNewPropertieColumn);
                    //Gen_Tools.Set_Propertie_By_Name_And_Value(_Object_Mgr, "OLV_Mgr_Object", _Object_Mgr);

                }
                catch (Exception ex) { string oDebug = ex.Message; }
                

            }
        }


        private void button_Save_Current_Columns2_Click(object sender, EventArgs e)
        {
            button_Save_Current_Columns_Click(sender, e);
        }
        private void button_Update_Sorting_Parameter_Click(object sender, EventArgs e)
        {
            textBox_Sorting_Parameter.Text = comboBox_Parameters_Columns.Text;
            OLV_Mgr_Object.Sorting_Parameter = textBox_Sorting_Parameter.Text;
        }

        private void tabControl_Symbols_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
            {
                if (tabControl_Symbols.SelectedTab.Name== "tabPage_Filtered_Symbols") 
                { Setup_OLV_Objects_Filtered();
                    OLV_Objects_Filtered.SetObjects(List_Of_Filtered_Objects);

                    foreach (OLVColumn oOLVColumn in OLV_Objects_Filtered.Columns)
                    {
                        if (oOLVColumn.AspectName == "Action")
                        {
                            oOLVColumn.IsButton = true;

                            // How will the button be sized? That can either be:
                            //   - FixedBounds. Each button is ButtonSize in size
                            //   - CellBounds. Each button is as wide as the cell, inset by CellPadding
                            //   - TextBounds. Each button resizes to match the width of the text plus ButtonPadding
                            oOLVColumn.ButtonSizing = OLVColumn.ButtonSizingMode.CellBounds;
                            oOLVColumn.ButtonSize = new Size(80, 26);

                            // Make the buttons clickable even if the row itself is disabled
                            oOLVColumn.EnableButtonWhenItemIsDisabled = true;
                            //oOLVColumn.AspectName = "Action";
                            oOLVColumn.TextAlign = HorizontalAlignment.Center;

                            break;
                        }
                    }
                    Refresh_Objects();
                }
                //tabPage_Filtered_Symbols
            }
            catch (Exception ex) { string oDebug = ex.Message; }
        }
        private void button_Export_Current_Columns_Click(object sender, EventArgs e)
        {
            try {
                Settings_Mgr.Add_Object_To_Manage(OLV_Mgr_Object, OLV_Mgr_Object.Name);
                File_Object.Select_Folder();//"File to Export Current Columns Lay Out");
                string oResult = "";
                if (Gen_Tools.Is_File_Exist(File_Object.FullFile_Name))
                {
                    DialogResult dialogResult = MessageBox.Show("Delete Existing file?", File_Object.Name +File_Object.Extension + "-File Exist", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Gen_Tools.Delete_File(File_Object.FullFile_Name, ref oResult);

                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;

                    }
                }
                Settings_Mgr.Updated_Properties_Of_Objects_ToParametersString();

                Settings_Mgr.Save_Settings_To_Full_File_Name(File_Object.FullFile_Name,false);
            }
            catch (Exception ex) {MessageBox.Show( ex.Message); }
            

            //Settings_Mgr.Save_Object_Properties_To_File(File_Object.FullFile_Name, OLV_Mgr_Object, true);

        }

        private void button_Import_New_Columns_Click(object sender, EventArgs e)
        {
            try 
            {
                File_Object.Open_File("File to Import New Columns");
                Settings_Mgr.Load_List_Of_Objects_Properties_Full_File_Name(File_Object.FullFile_Name);

                Utilities.OLVMgrObject oOLVMgrObject = new Utilities.OLVMgrObject();
                Settings_Mgr.Set_Properties_To_Object(oOLVMgrObject, OLV_Mgr_Object.Name);

                foreach (Utilities.PropertieColumn oPropertieColumn in oOLVMgrObject.List_Of_PropertieColumn)
                {
                    OLVColumn oNewOLVColumn = OLV_Add_Column(OLV_Objects, oPropertieColumn);
                }
             }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void button_Import_Replace_Columns_Click(object sender, EventArgs e)
        {
            File_Object.Open_File("File to Import New Columns");
            Settings_Mgr.Load_List_Of_Objects_Properties_Full_File_Name(File_Object.FullFile_Name);

            Utilities.OLVMgrObject oOLVMgrObject = new Utilities.OLVMgrObject();
            Settings_Mgr.Set_Properties_To_Object(oOLVMgrObject, OLV_Mgr_Object.Name);
           
            OLV_Mgr_Object.List_Of_PropertieColumn = oOLVMgrObject.List_Of_PropertieColumn;
            MessageBox.Show("Restart Requred");
        }

       
    }


}
