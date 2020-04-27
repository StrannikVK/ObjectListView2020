using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using GenericTools.Controllers;
using BrightIdeasSoftware;

namespace OLVTools2020
{
    public partial class OLVForecastControl : UserControl
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
        private GenericTools.Tools Gen_Tools = new GenericTools.Tools();

        private ObjectListView listView;
        public ObjectListView ListView
        {
            get { return this.listView; }
            protected set { this.listView = value; }
        }

        public List<ObjectToControl> List_Of_ObjectToControl { get; private set; } = new List<ObjectToControl>();


        public OLVForecastControl()
        {
            InitializeComponent();
            this.ListView = this.OLV_Objects;
        }

        public void Set_List_Of_ObjectToControl (List<ObjectToControl> oList_Of_ObjectToControl)
        {
            List_Of_ObjectToControl = oList_Of_ObjectToControl;
            this.OLV_Objects.SetObjects(List_Of_ObjectToControl);
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
            if (List_Of_ObjectToControl.Count<1) { Generate_List_Of_ObjectToControl(); }
            this.OLV_Objects.SetObjects(List_Of_ObjectToControl);
            try { ObjectToControl objectToControl = List_Of_ObjectToControl[0];
                if (objectToControl!=null) { Gen_Tools.DataBindings_ChangeDataSource(this, objectToControlBindingSource, objectToControl); }
            }
            catch (Exception ex) { string oDebug = ex.Message; }
            

            

        }

        private void Generate_List_Of_ObjectToControl()
        {

            ObjectToControl oNewObjectToControl = new ObjectToControl(null);
            oNewObjectToControl.FullName = "C:\\Windows\\System32\\notepad.exe";
            oNewObjectToControl.Name = "Notepad";
            oNewObjectToControl.Name_Application = "Notepad";
            oNewObjectToControl.Name_EXE = "notepad.exe";
            oNewObjectToControl.Description = "Notepad";
            List_Of_ObjectToControl.Add(oNewObjectToControl);

            for (int i = 0; i < 10; i++)
            {
                oNewObjectToControl = new ObjectToControl(null);
                oNewObjectToControl.Name = "Object#" + i;
                List_Of_ObjectToControl.Add(oNewObjectToControl);
            }
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
            this.olvColumnAction.ButtonSizing = OLVColumn.ButtonSizingMode.FixedBounds;
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

        //private void SetupDescibedTaskColumn() {
        //    // Setup a described task renderer, which draws a large icon
        //    // with a title, and a description under the title.
        //    // Almost all of this configuration could be done through the Designer
        //    // but I've done it through code that make it clear what's going on.

        //    // Create and install an appropriately configured renderer 
        //    this.olvColumn_Name.Renderer = CreateDescribedTaskRenderer();

        //    // Now let's setup the couple of other bits that the column needs

        //    // Tell the column which property should be used to get the title
        //    this.olvColumn_Name.AspectName = "Task";

        //    // Tell the column which property holds the identifier for the image for row.
        //    // We could also have installed an ImageGetter
        //    this.olvColumn_Name.ImageAspectName = "ImageName";

        //    // Put a little bit of space around the task and its description
        //    this.olvColumn_Name.CellPadding = new Rectangle(4, 2, 4, 2);
        //}

        //private void SetupColumns()
        //{
        //    // Draw the priority column as a collection of coins (first parameter).
        //    // We want the renderer to draw at most 4 stars (second parameter).
        //    // Priority has a value range from 0-5 (the last two parameters).
        //    this.olvColumnPriority.TextAlign = HorizontalAlignment.Center;
        //    MultiImageRenderer multiImageRenderer = new MultiImageRenderer("Lamp", 4, 0, 5);
        //    multiImageRenderer.Spacing = -12; // We want the coins to overlap
        //    this.olvColumnPriority.Renderer = multiImageRenderer;

        //    //this.olvColumnStatus.AspectToStringConverter = delegate(object model) {
        //    //    TestObject.TaskStatus status = (TestObject.TaskStatus)model;
        //    //    switch (status) {
        //    //        case TestObject.TaskStatus.InProgress:
        //    //            return "In progress";
        //    //        case TestObject.TaskStatus.NotStarted:
        //    //            return "Not started";
        //    //        case TestObject.TaskStatus.Complete:
        //    //            return "Complete";
        //    //        case TestObject.TaskStatus.Frozen:
        //    //            return "Frozen";
        //    //        default:
        //    //            return "";
        //    //    }
        //    //};
        //    //this.olvColumnStatus.ImageGetter = delegate(object model) {
        //    //    TestObject task = (TestObject)model;
        //    //    switch (task.Status) {
        //    //        case TestObject.TaskStatus.InProgress:
        //    //            return "Heart";
        //    //        case TestObject.TaskStatus.NotStarted:
        //    //            return "Add";
        //    //        case TestObject.TaskStatus.Complete:
        //    //            return "Tick";
        //    //        case TestObject.TaskStatus.Frozen:
        //    //            return "Cancel";
        //    //        default:
        //    //            return "";
        //    //    }
        //    //};
        //}

//        private DescribedTaskRenderer CreateDescribedTaskRenderer() {

//            // Let's create an appropriately configured renderer.
//            DescribedTaskRenderer renderer = new DescribedTaskRenderer();

//            // Give the renderer its own collection of images.
//            // If this isn't set, the renderer will use the SmallImageList from the ObjectListView.
//            // (this is standard Renderer behaviour, not specific to DescribedTaskRenderer).
//            renderer.ImageList = this.imageListTasks;

//            // Tell the renderer which property holds the text to be used as a description
//            renderer.DescriptionAspectName = "Description";

//            // Change the formatting slightly
//            renderer.TitleFont = new Font("Tahoma", 11, FontStyle.Bold);
//            renderer.DescriptionFont = new Font("Tahoma", 9);
//            renderer.ImageTextSpace = 8;
//            renderer.TitleDescriptionSpace = 1;

//            // Use older Gdi renderering, since most people think the text looks clearer
//            renderer.UseGdiTextRendering = true;

//            // If you like colours other than black and grey, you could uncomment these
////            renderer.TitleColor = Color.DarkBlue;
////            renderer.DescriptionColor = Color.CornflowerBlue;

//            return renderer;
//        }

        //private static List<gene> CreateTasks() {
        //    List<TestObject> tasks = new List<TestObject>();

        //    tasks.Add(new TestObject("Setup spy cameras", "Install spy cameras in several locations to collect interesting footage", "film", TestObject.TaskStatus.NotStarted, 5));
        //    tasks.Add(new TestObject("Check printer status", "Ensure that the printer is turned on and has toner", "printer", TestObject.TaskStatus.NotStarted, 2));
        //    tasks.Add(new TestObject("Check circuit boards", "Ensure that the circuit boards are properly seated and have not be stolen ", "electronics", TestObject.TaskStatus.Complete, 4));
        //    tasks.Add(new TestObject("Swap local gossip", "Spent some time in rec room to pick up any juicy gossip that could be useful", "backandforth", TestObject.TaskStatus.InProgress, 3));
        //    tasks.Add(new TestObject("Answer any questions", "Politely and informatively respond to all tech questions the employees may have", "faq", TestObject.TaskStatus.InProgress, 1));
        //    tasks.Add(new TestObject("Check Windows licenses", "Make sure that each Windows machine is running an authorized copy of Windows", "windows", TestObject.TaskStatus.NotStarted, 5));
        //    tasks.Add(new TestObject("Download new games", "Check to see if anyone has installed an good new games and copy them onto the portable hard drive", "download", TestObject.TaskStatus.NotStarted, 1));

        //    return tasks;
        //}

        private void RebuildFilters() {
            // Build a composite filter that unify the three possible filtering criteria

            try
            {
                List<IModelFilter> filters = new List<IModelFilter>();

                if (this.checkBox_HighPotential.Checked)
                    filters.Add(new ModelFilter(delegate (object model) { return ((ObjectToControl)model).Potential > 3; }));

                if (this.checkBox_LowPotential.Checked)
                    filters.Add(new ModelFilter(delegate (object model) { return ((ObjectToControl)model).Potential <= 3; }));

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
                oObjectToControl.Action_Execute();

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
            ObjectToControl oObjectToControl = (ObjectToControl)objectToControlBindingSource.DataSource;
            oObjectToControl.Check_Status();
            
            this.RebuildFilters();

        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            this.RebuildFilters();
            OLV_Objects.RefreshObjects(List_Of_ObjectToControl);
        }

        private void button_Action_Click(object sender, EventArgs e)
        {
            try 
            {
                ObjectToControl oObjectToControl = (ObjectToControl)objectToControlBindingSource.DataSource;
                oObjectToControl.Action_Execute();
                Gen_Tools.DataBindings_Refresh(this, objectToControlBindingSource);
            }
            catch (Exception ex) { string oDebug = ex.Message; }
            
        }
    }

    ///// <summary>
    ///// Dumb model class
    ///// </summary>
    //public class TestObject {
    //    private string task;
    //    private TaskStatus status;
    //    private string description;
    //    private string imageName;
    //    private int priority;

    //    #region Life and death

    //    public TestObject(string task, string description, string imageName, TaskStatus status, int priority)
    //    {
    //        this.Task = task;
    //        this.ImageName = imageName;
    //        this.Description = description;
    //        this.Status = status;
    //        this.Priority = priority;
    //    }

    //    #endregion

    //    #region Properties

    //    public string Task
    //    {
    //        get { return this.task; }
    //        set { this.task = value; }
    //    }

    //    public string ImageName
    //    {
    //        get { return this.imageName; }
    //        set { this.imageName = value; }
    //    }

    //    public string Description
    //    {
    //        get { return this.description; }
    //        set { this.description = value; }
    //    }

    //    public TaskStatus Status
    //    {
    //        get { return this.status; }
    //        set { this.status = value; }
    //    }

    //    public int Priority {
    //        get { return this.priority; }
    //        set { this.priority = value; }
    //    }

    //    public string NextAction {
    //        get {
    //            switch (Status) {
    //                case TestObject.TaskStatus.InProgress:
    //                    return "Complete";
    //                case TestObject.TaskStatus.NotStarted:
    //                    return "Start";
    //                case TestObject.TaskStatus.Complete:
    //                    return "Freeze";
    //                case TestObject.TaskStatus.Frozen:
    //                    return "Restart";
    //                default:
    //                    return "[unknown]";
    //            }
    //        }
    //    }

    //    #endregion

    //    public enum TaskStatus {
    //        NotStarted,
    //        InProgress,
    //        Complete,
    //        Frozen
    //    }

    //    public void AdvanceToNextState() {
    //        switch (Status)
    //        {
    //            case TestObject.TaskStatus.NotStarted:
    //                Status = TestObject.TaskStatus.InProgress;
    //                break;
    //            case TestObject.TaskStatus.InProgress:
    //                Status = TestObject.TaskStatus.Complete;
    //                break;
    //            case TestObject.TaskStatus.Complete:
    //                Status = TestObject.TaskStatus.Frozen;
    //                break;
    //            case TestObject.TaskStatus.Frozen:
    //                Status = TestObject.TaskStatus.NotStarted;
    //                break;
    //            default:
    //                throw new ArgumentOutOfRangeException();
    //        }
    //    }
    //}

}
