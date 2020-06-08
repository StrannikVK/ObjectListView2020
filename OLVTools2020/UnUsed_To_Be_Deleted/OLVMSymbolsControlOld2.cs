using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using GenericTools.Controllers;
using BrightIdeasSoftware;
using System.Data;

namespace OLVTools2020
{
    public partial class OLVMSymbolsControl2 : UserControl
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
                    //this.InitializeTab();
                    //this.SetupGeneralListViewEvents();
                }
            }
        }
        private OLVMgr _OLVMgr;
        private GenericTools.Tools Gen_Tools = new GenericTools.Tools();
        private System.Data.DataSet DS = new System.Data.DataSet("TestDS");
        private System.Data.DataTable Source_Table = new System.Data.DataTable("TestDT");

        private ObjectListView listView;
        public ObjectListView ListView
        {
            get { return this.listView; }
            protected set { this.listView = value; }
        }

        //public List<ObjectToControl> List_Of_ObjectToControl { get; private set; } = new List<ObjectToControl>();
        public OLVMSymbolsControl2()
        {
            InitializeComponent();
            DS.Tables.Add(Source_Table);
            Generate_DatTable();
            this.ListView = this.OLV_Objects;
        }

        private void Generate_DatTable()
        {

            DataTable table = new DataTable("TestDT");
            table.Columns.Add("Dosage", typeof(int));
            table.Columns.Add("Drug", typeof(string));
            table.Columns.Add("Patient", typeof(string));
            table.Columns.Add("Date", typeof(DateTime));

            // Here we add five DataRows.
            table.Rows.Add(25, "Indocin", "David", DateTime.Now);
            table.Rows.Add(50, "Enebrel", "Sam", DateTime.Now);
            table.Rows.Add(10, "Hydralazine", "Christoff", DateTime.Now);
            table.Rows.Add(21, "Combivent", "Janet", DateTime.Now);
            table.Rows.Add(100, "Dilantin", "Melanie", DateTime.Now);
            Source_Table = table;

        }


        public void Set_Datatable(System.Data.DataTable oTable)
        {
            if (oTable==null) { return; }
            Source_Table = oTable;
            if (oTable.DataSet==null) { DS.Tables.Add(Source_Table);  }
            else
            {
                DS = oTable.DataSet;
            }
          
            InitializeTab();
        }


        protected void InitializeTab() {

            try 
            {
                if (Source_Table == null) { Generate_DatTable(); }
                if (Source_Table.Rows.Count < 1) { Generate_DatTable(); }

                if (DS.Tables.Count <= 0)
                {
                    OLV_Mgr.ShowMessage(@"Failed to load data set");
                    return;
                }
                // The DataTreeListView needs to know the key that identifies root level objects.
                // DataTreeListView can handle that key being any data type, but the Designer only deals in strings.
                // Since we want a non-string value to identify keys, we have to set it explicitly here.
                this.olvDataTree.RootKeyValue = 0u;

                this.dataGridView_Symbols.DataSource = DS;
                this.dataGridView_Symbols.DataMember = Source_Table.TableName;

                // Like DataListView, the DataTreeListView can handle binding to a variety of sources
                // And again, you could create a BindingSource in the designer, and assign that BindingSource
                // to DataSource, removing the need to even write these few lines of code.

                //this.olvDataTree.DataSource = new BindingSource(ds, "Person");
                //this.olvDataTree.DataSource = ds.Tables["Person"];
                //this.olvDataTree.DataSource = new DataView(ds.Tables["Person"]);
                //this.olvDataTree.DataMember = "Person"; this.olvDataTree.DataSource = ds;
                this.olvDataTree.DataMember = Source_Table.TableName;
                this.olvDataTree.DataSource = new System.Data.DataViewManager(DS);
                // This does a better job of auto sizing the columns
                this.olvDataTree.AutoResizeColumns();
            }
            catch (Exception ex) { string oDebug = ex.Message; }
            


        }


        //private void SetupColumnWithButton() {

        //    // Tell the columns that it is going to show buttons.
        //    // The label that goes into the button is the Aspect that would have been
        //    // displayed in the cell.
        //    this.olvColumnAction.IsButton = true;

        //    // How will the button be sized? That can either be:
        //    //   - FixedBounds. Each button is ButtonSize in size
        //    //   - CellBounds. Each button is as wide as the cell, inset by CellPadding
        //    //   - TextBounds. Each button resizes to match the width of the text plus ButtonPadding
        //    this.olvColumnAction.ButtonSizing = OLVColumn.ButtonSizingMode.FixedBounds;
        //    this.olvColumnAction.ButtonSize = new Size(80, 26);

        //    // Make the buttons clickable even if the row itself is disabled
        //    this.olvColumnAction.EnableButtonWhenItemIsDisabled = true;
        //    this.olvColumnAction.AspectName = "Action";
        //    this.olvColumnAction.TextAlign = HorizontalAlignment.Center;

        //    //// Listen for button clicks -- which for the purpose of the demo will cycle the state of the service task
        //    //this.OLV_Objects.ButtonClick += delegate(object sender, CellClickEventArgs e) {
        //    //    OLV_Mgr.ToolStripStatus1 = String.Format("Button clicked: ({0}, {1}, {2})", e.RowIndex, e.SubItem, e.Model);

        //    //    // We only have one column with a button, but if there was more than one, you would have to check ColumnIndex to see which button was clicked
        //    //    TestObject task = (TestObject)e.Model;
        //    //    task.AdvanceToNextState();

        //    //    // Just to show off disabled rows, make tasks that are frozen be disabled.
        //    //    if (task.Status == TestObject.TaskStatus.Frozen)
        //    //        this.OLV_Objects.DisableObject(e.Model);
        //    //    else
        //    //        this.OLV_Objects.EnableObject(e.Model);

        //    //    this.OLV_Objects.RefreshObject(e.Model);
        //    //};
        //}


        private void RebuildFilters() {
            // Build a composite filter that unify the three possible filtering criteria

            try
            {
                List<IModelFilter> filters = new List<IModelFilter>();

                if (this.checkBox_HighPotential.Checked)
                    filters.Add(new ModelFilter(delegate (object model) { return ((ObjectToControl)model).Filter_Value > ((ObjectToControl)model).Filter_Level; }));

                if (this.checkBox_LowPotential.Checked)
                    filters.Add(new ModelFilter(delegate (object model) { return ((ObjectToControl)model).Filter_Value <= ((ObjectToControl)model).Filter_Level; }));

                if (!String.IsNullOrEmpty(this.textBoxFilter.Text))
                    filters.Add(new TextMatchFilter(this.OLV_Objects, this.textBoxFilter.Text));

                // Use AdditionalFilter (instead of ModelFilter) since AdditionalFilter plays well with any
                // extra filtering the user might specify via the column header
                this.OLV_Objects.AdditionalFilter = filters.Count == 0 ? null : new CompositeAllFilter(filters);
                Gen_Tools.DataBindings_Refresh(this, objectToControlBindingSource);

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
                //toolStrip_StatusLabel.Text = String.Format("Button clicked: ({0}, {1}, {2})", e.RowIndex, e.SubItem, e.Model);
                ObjectToControl oObjectToControl = (ObjectToControl)e.Model;
                oObjectToControl.Action_Execute(oObjectToControl.Action);

                //// Just to show off disabled rows, make tasks that are frozen be disabled.
                //if (oObjectToControl.Status == ObjectToControl.Action_Disabled)
                //    this.OLV_Objects.DisableObject(e.Model);
                //else
                //    this.OLV_Objects.EnableObject(e.Model);

                this.OLV_Objects.RefreshObject(e.Model);
                

            }
            catch (Exception ex) { string oDebug = ex.Message; }

            try { Gen_Tools.DataBindings_Refresh(this, objectToControlBindingSource); }
            catch (Exception ex) { string oDebug = ex.Message; }
        }

        private void OLV_Objects_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                object oModel = OLV_Objects.SelectedObject;
                Gen_Tools.DataBindings_ChangeDataSource(this, objectToControlBindingSource, oModel);
                try { propertyGrid_Selected_Object.SelectedObject = oModel; }
                catch (Exception ex) { string oDebug = ex.Message; }
                



            }
            catch (Exception ex) { string oDebug = ex.Message; }
        }
       

        private void checkBoxGroups_CheckedChanged(object sender, EventArgs e)
        {
           
                OLV_Mgr.ShowGroupsChecked(this.ListView, (CheckBox)sender);
            
        }

        private void checkBoxCheckboxes_CheckedChanged(object sender, EventArgs e)
        {
            this.ListView.CheckBoxes = ((CheckBox)sender).Checked;
        }

        private void button_Status_Refresh_Click(object sender, EventArgs e)
        {
            try 
            {
                if (objectToControlBindingSource.DataSource==null) { return; }
                ObjectToControl oObjectToControl = (ObjectToControl)objectToControlBindingSource.DataSource;
                oObjectToControl.Check_Status();
            }
            catch (Exception ex) { string oDebug = ex.Message; }
            
            
            this.RebuildFilters();

        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            this.RebuildFilters();
            //OLV_Objects.RefreshObjects(List_Of_ObjectToControl);
        }

        private void button_Action_Click(object sender, EventArgs e)
        {
            try 
            {
                ObjectToControl oObjectToControl = (ObjectToControl)objectToControlBindingSource.DataSource;
                oObjectToControl.Action_Execute(oObjectToControl.Action);
                Gen_Tools.DataBindings_Refresh(this, objectToControlBindingSource);
            }
            catch (Exception ex) { string oDebug = ex.Message; }
            
        }

        private void button_Enable_Edit_Click(object sender, EventArgs e)
        {
            if (!propertyGrid_Selected_Object.Enabled) { propertyGrid_Selected_Object.Enabled = true; button_Enable_Edit.Text = "Disable Edit"; }
            else { propertyGrid_Selected_Object.Enabled = false; button_Enable_Edit.Text = "Enable Edit"; }
        }

        private void tabPage_DataGridView_Validated(object sender, EventArgs e)
        {

        }
    }


}
