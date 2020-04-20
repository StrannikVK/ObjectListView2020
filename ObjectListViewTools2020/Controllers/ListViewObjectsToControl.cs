using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenericTools.Controllers;
using BrightIdeasSoftware;

namespace ObjectListViewTools2020.Controllers
{
    public partial class ListViewObjectsToControl : UserControl
    {
        private ControllerOfObjects _ControllerOfObjects;
        public ListViewObjectsToControl()
        {
            InitializeComponent();
        }

        private void ListViewObjectsToControl_Load(object sender, EventArgs e)
        {
           
            //this.SetupDescibedTaskColumn();
            //this.SetupColumns();
           

            // How much space do we want to give each row? Obviously, this should be at least
            // the height of the images used by the renderer
            //olv_ObjectList_View.RowHeight = 54;
            //olv_ObjectList_View.SmallImageList = new ImageList(;
            //olv_ObjectList_View.EmptyListMsg = "No tasks match the filter";
            //olv_ObjectList_View.UseAlternatingBackColors = false;
            //olv_ObjectList_View.UseHotItem = false;

            // Make and display a list of tasks
            List<ServiceTask> tasks = CreateTasks();
            FastDataListView_ObjectsToControl.SetObjects(tasks);
            this.SetupColumnWithButton();
        }

        public void Set_ControllerOfObjects(ControllerOfObjects oControllerOfObjects)
        {

        }

        private void SetupColumnWithButton()
        {

            // Tell the columns that it is going to show buttons.
            // The label that goes into the button is the Aspect that would have been
            // displayed in the cell.
            BrightIdeasSoftware.ColumnButtonRenderer oColumnButtonRenderer = new ColumnButtonRenderer();
            //oColumnButtonRenderer.col
            //olvColumn_Action.Renderer = oColumnButtonRenderer;
            //olvColumn_Action.B
            olvColumn_Action.IsButton = true;

            // How will the button be sized? That can either be:
            //   - FixedBounds. Each button is ButtonSize in size
            //   - CellBounds. Each button is as wide as the cell, inset by CellPadding
            //   - TextBounds. Each button resizes to match the width of the text plus ButtonPadding
            //this.olvColumn_Action.ButtonSizing = OLVColumn.ButtonSizingMode.CellBounds;
            //this.olvColumn_Action.ButtonSize = new Size(80, 26);

            // Make the buttons clickable even if the row itself is disabled
            //this.olvColumn_Action.EnableButtonWhenItemIsDisabled = true;
            //this.olvColumn_Action.AspectName = "NextAction";
            //this.olvColumn_Action.TextAlign = HorizontalAlignment.Center;

            // Listen for button clicks -- which for the purpose of the demo will cycle the state of the service task
            //this.olvTasks.ButtonClick += delegate(object sender, CellClickEventArgs e) {
            //    Coordinator.ToolStripStatus1 = String.Format("Button clicked: ({0}, {1}, {2})", e.RowIndex, e.SubItem, e.Model);

            //    // We only have one column with a button, but if there was more than one, you would have to check ColumnIndex to see which button was clicked
            //    ServiceTask task = (ServiceTask)e.Model;
            //    task.AdvanceToNextState();

            //    // Just to show off disabled rows, make tasks that are frozen be disabled.
            //    if (task.Status == ServiceTask.TaskStatus.Frozen)
            //        this.olvTasks.DisableObject(e.Model);
            //    else
            //        this.olvTasks.EnableObject(e.Model);

            //    this.olvTasks.RefreshObject(e.Model);
            //};
        }

        private void SetupDescibedTaskColumn()
        {
            //// Setup a described task renderer, which draws a large icon
            //// with a title, and a description under the title.
            //// Almost all of this configuration could be done through the Designer
            //// but I've done it through code that make it clear what's going on.

            //// Create and install an appropriately configured renderer 
            //this.olvColumnTask.Renderer = CreateDescribedTaskRenderer();

            //// Now let's setup the couple of other bits that the column needs

            //// Tell the column which property should be used to get the title
            //this.olvColumnTask.AspectName = "Task";

            //// Tell the column which property holds the identifier for the image for row.
            //// We could also have installed an ImageGetter
            //this.olvColumnTask.ImageAspectName = "ImageName";

            //// Put a little bit of space around the task and its description
            //this.olvColumnTask.CellPadding = new Rectangle(4, 2, 4, 2);
        }

        private void SetupColumns()
        {
            //// Draw the priority column as a collection of coins (first parameter).
            //// We want the renderer to draw at most 4 stars (second parameter).
            //// Priority has a value range from 0-5 (the last two parameters).
            //this.olvColumnPriority.TextAlign = HorizontalAlignment.Center;
            //MultiImageRenderer multiImageRenderer = new MultiImageRenderer("Lamp", 4, 0, 5);
            //multiImageRenderer.Spacing = -12; // We want the coins to overlap
            //this.olvColumnPriority.Renderer = multiImageRenderer;

            //this.olvColumnStatus.AspectToStringConverter = delegate (object model) {
            //    ServiceTask.TaskStatus status = (ServiceTask.TaskStatus)model;
            //    switch (status)
            //    {
            //        case ServiceTask.TaskStatus.InProgress:
            //            return "In progress";
            //        case ServiceTask.TaskStatus.NotStarted:
            //            return "Not started";
            //        case ServiceTask.TaskStatus.Complete:
            //            return "Complete";
            //        case ServiceTask.TaskStatus.Frozen:
            //            return "Frozen";
            //        default:
            //            return "";
            //    }
            //};
            //this.olvColumnStatus.ImageGetter = delegate (object model) {
            //    ServiceTask task = (ServiceTask)model;
            //    switch (task.Status)
            //    {
            //        case ServiceTask.TaskStatus.InProgress:
            //            return "Heart";
            //        case ServiceTask.TaskStatus.NotStarted:
            //            return "Add";
            //        case ServiceTask.TaskStatus.Complete:
            //            return "Tick";
            //        case ServiceTask.TaskStatus.Frozen:
            //            return "Cancel";
            //        default:
            //            return "";
            //    }
            //};
        }

        private BrightIdeasSoftware.DescribedTaskRenderer CreateDescribedTaskRenderer()
        {

            // Let's create an appropriately configured renderer.
            DescribedTaskRenderer renderer = new DescribedTaskRenderer();

            // Give the renderer its own collection of images.
            // If this isn't set, the renderer will use the SmallImageList from the ObjectListView.
            // (this is standard Renderer behaviour, not specific to DescribedTaskRenderer).
            //renderer.ImageList = this.imageListTasks;

            // Tell the renderer which property holds the text to be used as a description
            renderer.DescriptionAspectName = "Description";

            // Change the formatting slightly
            renderer.TitleFont = new Font("Tahoma", 11, FontStyle.Bold);
            renderer.DescriptionFont = new Font("Tahoma", 9);
            renderer.ImageTextSpace = 8;
            renderer.TitleDescriptionSpace = 1;

            // Use older Gdi renderering, since most people think the text looks clearer
            renderer.UseGdiTextRendering = true;

            // If you like colours other than black and grey, you could uncomment these
            //            renderer.TitleColor = Color.DarkBlue;
            //            renderer.DescriptionColor = Color.CornflowerBlue;

            return renderer;
        }

        private static List<ServiceTask> CreateTasks()
        {
            List<ServiceTask> tasks = new List<ServiceTask>();

            tasks.Add(new ServiceTask("Setup spy cameras", "Install spy cameras in several locations to collect interesting footage", "film", ServiceTask.TaskStatus.NotStarted, 5));
            tasks.Add(new ServiceTask("Check printer status", "Ensure that the printer is turned on and has toner", "printer", ServiceTask.TaskStatus.NotStarted, 2));
            tasks.Add(new ServiceTask("Check circuit boards", "Ensure that the circuit boards are properly seated and have not be stolen ", "electronics", ServiceTask.TaskStatus.Complete, 4));
            tasks.Add(new ServiceTask("Swap local gossip", "Spent some time in rec room to pick up any juicy gossip that could be useful", "backandforth", ServiceTask.TaskStatus.InProgress, 3));
            tasks.Add(new ServiceTask("Answer any questions", "Politely and informatively respond to all tech questions the employees may have", "faq", ServiceTask.TaskStatus.InProgress, 1));
            tasks.Add(new ServiceTask("Check Windows licenses", "Make sure that each Windows machine is running an authorized copy of Windows", "windows", ServiceTask.TaskStatus.NotStarted, 5));
            tasks.Add(new ServiceTask("Download new games", "Check to see if anyone has installed an good new games and copy them onto the portable hard drive", "download", ServiceTask.TaskStatus.NotStarted, 1));

            return tasks;
        }

        private void checkBoxCheckboxes_CheckedChanged(object sender, EventArgs e)
        {
            FastDataListView_ObjectsToControl.CheckBoxes = ((CheckBox)sender).Checked;
        }

        private void checkBoxGroups_CheckedChanged(object sender, EventArgs e)
        {
            FastDataListView_ObjectsToControl.ShowGroups = ((CheckBox)sender).Checked;
            FastDataListView_ObjectsToControl.BuildList();
        }

        private void comboBoxEditable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEditable.Text == "No")
                FastDataListView_ObjectsToControl.CellEditActivation = ObjectListView.CellEditActivateMode.None;
            else if (comboBoxEditable.Text == "Single Click")
                FastDataListView_ObjectsToControl.CellEditActivation = ObjectListView.CellEditActivateMode.SingleClick;
            else if (comboBoxEditable.Text == "Double Click")
                FastDataListView_ObjectsToControl.CellEditActivation = ObjectListView.CellEditActivateMode.DoubleClick;
            else
                FastDataListView_ObjectsToControl.CellEditActivation = ObjectListView.CellEditActivateMode.F2Only;
        }

        private void comboBoxView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle restrictions on Tile view
            if (comboBoxView.SelectedIndex == 3)
            {
                if (FastDataListView_ObjectsToControl.VirtualMode)
                {
                    MessageBox.Show("Sorry, Microsoft says that virtual lists can't use Tile view.");
                    return;
                }
                if (FastDataListView_ObjectsToControl.CheckBoxes)
                {
                    MessageBox.Show("Microsoft says that Tile view can't have checkboxes, so CheckBoxes have been turned off on this list.");
                    FastDataListView_ObjectsToControl.CheckBoxes = false;
                }
            }

            switch (comboBoxView.SelectedIndex)
            {
                case 0:
                    FastDataListView_ObjectsToControl.View = View.SmallIcon;
                    break;
                case 1:
                    FastDataListView_ObjectsToControl.View = View.LargeIcon;
                    break;
                case 2:
                    FastDataListView_ObjectsToControl.View = View.List;
                    break;
                case 3:
                    FastDataListView_ObjectsToControl.View = View.Tile;
                    break;
                case 4:
                    FastDataListView_ObjectsToControl.View = View.Details;
                    break;
            }
        }

        private void FastDataListView_ObjectsToControl_ButtonClick(object sender, CellClickEventArgs e)
        {
            try 
            {
                int oRowindes = e.RowIndex;
                object oSubitem = e.SubItem;
                object oModel = e.Model;
            }
            catch (Exception ex) { string oDebug = ex.Message; }
        }
    }

    /// <summary>
    /// Dumb model class
    /// </summary>
    public class ServiceTask
    {
        private string task;
        private TaskStatus status;
        private string description;
        private string imageName;
        private int priority;

        #region Life and death

        public ServiceTask(string task, string description, string imageName, TaskStatus status, int priority)
        {
            this.Name = task;
            this.ImageName = imageName;
            this.Description = description;
            this.Status = status;
            this.Priority = priority;
        }

        #endregion

        #region Properties

        public string Name
        {
            get { return this.task; }
            set { this.task = value; }
        }

        public string ImageName
        {
            get { return this.imageName; }
            set { this.imageName = value; }
        }

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        public TaskStatus Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        public int Priority
        {
            get { return this.priority; }
            set { this.priority = value; }
        }

        public string Action
        {
            get
            {
                switch (Status)
                {
                    case ServiceTask.TaskStatus.InProgress:
                        return "Complete";
                    case ServiceTask.TaskStatus.NotStarted:
                        return "Start";
                    case ServiceTask.TaskStatus.Complete:
                        return "Freeze";
                    case ServiceTask.TaskStatus.Frozen:
                        return "Restart";
                    default:
                        return "[unknown]";
                }
            }
        }

        #endregion

        public enum TaskStatus
        {
            NotStarted,
            InProgress,
            Complete,
            Frozen
        }

        public void AdvanceToNextState()
        {
            switch (Status)
            {
                case ServiceTask.TaskStatus.NotStarted:
                    Status = ServiceTask.TaskStatus.InProgress;
                    break;
                case ServiceTask.TaskStatus.InProgress:
                    Status = ServiceTask.TaskStatus.Complete;
                    break;
                case ServiceTask.TaskStatus.Complete:
                    Status = ServiceTask.TaskStatus.Frozen;
                    break;
                case ServiceTask.TaskStatus.Frozen:
                    Status = ServiceTask.TaskStatus.NotStarted;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
