using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using GenericTools.Controllers;
using BrightIdeasSoftware;

namespace OLVTools2020
{
    public partial class OLVWalletInvestorControl : UserControl
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
        //private BindingSource Objects_BindingSource = new BindingSource();


        public OLVWalletInvestorControl()
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
            SetupColumnWithButton();
        }

        public void Refresh_Objects()
        {
            OLV_Objects.RefreshObjects(List_Of_Objects);

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

        private void checkBoxHighPriority_CheckedChanged(object sender, EventArgs e) {
            this.RebuildFilters();
        }

        private void checkBoxIncomplete_CheckedChanged(object sender, EventArgs e) {
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

        private void OLV_Objects_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                object oModel = OLV_Objects.SelectedObject;
                

            }
            catch (Exception ex) { string oDebug = ex.Message; }
        }
       

        private void checkBoxGroups_CheckedChanged(object sender, EventArgs e)
        {
           
                OLV_Mgr.ShowGroupsChecked(this.ListView, (CheckBox)sender);
            
        }

        private void checkBoxCheckboxes_CheckedChanged(object sender, EventArgs e)
        {
            try 
            {
                this.ListView.CheckBoxes = ((CheckBox)sender).Checked;
            }
            catch (Exception ex) { string oDebug = ex.Message; }
            
        }
        private void button_Refresh_Click(object sender, EventArgs e)
        {
            this.RebuildFilters();
            OLV_Objects.RefreshObjects(List_Of_Objects);
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
            object oobject = (object)oModel;
            string oSymbol = Gen_Tools.Get_Properie_String_By_Name(oobject, "Symbol");
            string oAction = "Get_ForecastsObject_Properties";

            object[] oArg = { oAction + oSymbol };
            object oResult = null;
            Gen_Tools.Start_Generic_Methods(_Object_Mgr, "Action_Execute", oArg, out oResult);
        }
    }


}
