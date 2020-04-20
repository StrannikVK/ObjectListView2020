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

namespace ObjectListViewTools2020
{
    public partial class ObjectsControllerForm : Form
    {
        //public List<ObjectToControl> Objects_List { get; } = new List<ObjectToControl>();
        //public string Action { get; set; } = "Start";
        //public string TaskName { get; set; } = "TaskName";
        //public string Priority { get; set; } = "one";

        //public string Status { get; set; } = "Status =TBD";

        public ObjectsControllerForm()
        {
           

            InitializeComponent();


            //ObjectToControl objectToControl = new ObjectToControl(this);
            //Objects_List.Add(objectToControl);
            //Objects_List.Add(objectToControl);

            
        }

        private void ObjectsControllerForm_Load(object sender, EventArgs e)
        {
            //olv_ObjectList_View.SetObjects(Objects_List);
        }
    }
}
