using BrightIdeasSoftware;
using ObjectListViewTools2020.Controllers;
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

        public ObjectsControllerForm()
        {
           

            InitializeComponent();
            dataListView1.DefaultRenderer=new  HighlightTextRenderer();
            //dataListView1.DefaultRenderer.
            List<Controllers.ServiceTask> tasks = CreateTasks();
            dataListView1.SetObjects(tasks);
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


        private void ObjectsControllerForm_Load(object sender, EventArgs e)
        {
            // Make and display a list of tasks
          
        }

        private void textBoxFilterFast_TextChanged(object sender, EventArgs e)
        {
            ObjectListView olv = dataListView1;
            TextMatchFilter filter = null;
            string txt = textBoxFilterFast.Text;
            if (!String.IsNullOrEmpty(txt))
            {
                switch (comboBoxFilterType.SelectedIndex)
                {
                    case 0:
                    default:
                        filter = TextMatchFilter.Contains(olv, txt);
                        break;
                    case 1:
                        filter = TextMatchFilter.Prefix(olv, txt);
                        break;
                    case 2:
                        filter = TextMatchFilter.Regex(olv, txt);
                        break;
                }
            }

            // Text highlighting requires at least a default renderer
            if (olv.DefaultRenderer == null)
                olv.DefaultRenderer = new HighlightTextRenderer(filter);

            olv.AdditionalFilter = filter;
        }
    }
}
