/*
 * OLVTools2020 - A simple demo to show the ObjectListView control
 *
 * User: Phillip Piper
 * Date: 15/10/2006 11:15 AM
 *
 * Change log:
 * 2015-06-12  JPP  COMPLETE REWRITE. Goal of rewrite is to make the code much easier to follow
 * 
 * 2009-07-04  JPP  Added ExampleVirtualDataSource for virtual list demo
 * [lots of stuff]
 * 2006-10-20  JPP  Added DataSet tab page
 * 2006-10-15  JPP  Initial version
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using BrightIdeasSoftware;

namespace OLVTools2020 {

    public partial class ObjectsControllerForm
    {
        /// <summary>
        ///
        /// </summary>
        public ObjectsControllerForm() {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            Initialize_ObjectListButtonControl();
        }

        void Initialize_ObjectListButtonControl() {
            // Use different font under Vista
            if (ObjectListView.IsVistaOrLater)
                this.Font = new Font("Segoe UI", 9);
             
            //OLVMgr OLV_Mgr = new OLVMgr(this);

            //this.tabSimple.Coordinator = OLV_Mgr;
            //this.tabComplex.Coordinator = OLV_Mgr;
            //this.tabDataSet.Coordinator = OLV_Mgr;
            //this.tabFileExplorer1.Coordinator = OLV_Mgr;
            //this.tabFastList1.Coordinator = OLV_Mgr;
            //this.tabTreeListView1.Coordinator = OLV_Mgr;
            //this.tabDataTreeListView1.Coordinator = OLV_Mgr;
            //this.tabDragAndDrop1.Coordinator = OLV_Mgr;
            //this.ObjectList_W_Button_Control.OLV_Mgr = OLV_Mgr;

            // Printing tab is slightly different, since it needs to know about the ObjectListViews from the other tabs
            //this.tabPrinting1.SimpleView = this.tabSimple.ListView;
            //this.tabPrinting1.ComplexView = this.tabComplex.ListView;
            //this.tabPrinting1.DataListView = this.tabDataSet.ListView;
            //this.tabPrinting1.FileExplorerView = this.tabFileExplorer1.ListView;
            //this.tabPrinting1.TreeListView = this.tabTreeListView1.ListView;
            //this.tabPrinting1.Coordinator = coordinator;

            //this.tabControl1.SelectTab(this.tabDescribedTasks);
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            //if (tabControl1.TabPages[e.TabPageIndex].Name == "tabPagePrinting")
                //this.tabPrinting1.UpdatePrintPreview();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void tabSimple_Load(object sender, EventArgs e)
        {

        }
    }
}
