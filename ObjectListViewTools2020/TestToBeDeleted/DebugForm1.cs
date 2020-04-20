using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectListViewTools2020.TestToBeDeleted
{
    public partial class DebugForm1 : Form
    {
        public List<object> Objects_List { get; } = new List<object>();
        public string Action { get; set; } = "Start";
        public string TaskName { get; set; } = "TaskName";
        public string Priority { get; set; } = "one";

        public string Status { get; set; } = "Status =TBD";

        public DebugForm1()
        {
            InitializeComponent();
            Objects_List.Add(this);
            Objects_List.Add(this);
        }

        private void DebugForm1_Load(object sender, EventArgs e)
        {

            OLVColumn oLVColumn = new OLVColumn(TaskName, TaskName);
            ColumnButtonRenderer columnButtonRenderer = new ColumnButtonRenderer();
            columnButtonRenderer.ButtonSize = new Size(40, 20);
            oLVColumn.Renderer = columnButtonRenderer;
            //oLVColumn.Renderer.Bu
            //dataListView.Columns.Add(oLVColumn);
            //oLVColumn.IsButton = true;
            //dataListView.SetObjects(Objects_List);
            //olvColumn_Status.IsButton = true;
            //olvColumn_Status.ButtonSizing = BrightIdeasSoftware.OLVColumn.ButtonSizingMode.CellBounds;
            
            //dataListView.AllColumns[1].IsButton = true;
        }
    }

}
