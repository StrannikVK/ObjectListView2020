namespace ObjectListViewTools2020.TestToBeDeleted
{
    partial class DebugForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebugForm1));
            this.imageListTasks = new System.Windows.Forms.ImageList(this.components);
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.tabDescribedTask1 = new ObjectListViewTools2020.TabDescribedTask();
            this.SuspendLayout();
            // 
            // imageListTasks
            // 
            this.imageListTasks.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTasks.ImageStream")));
            this.imageListTasks.TransparentColor = System.Drawing.Color.Fuchsia;
            this.imageListTasks.Images.SetKeyName(0, "download");
            this.imageListTasks.Images.SetKeyName(1, "backandforth");
            this.imageListTasks.Images.SetKeyName(2, "faq");
            this.imageListTasks.Images.SetKeyName(3, "windows");
            this.imageListTasks.Images.SetKeyName(4, "filter");
            this.imageListTasks.Images.SetKeyName(5, "printer");
            this.imageListTasks.Images.SetKeyName(6, "electronics");
            this.imageListTasks.Images.SetKeyName(7, "film");
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "Add");
            this.imageListSmall.Images.SetKeyName(1, "Cancel");
            this.imageListSmall.Images.SetKeyName(2, "Heart");
            this.imageListSmall.Images.SetKeyName(3, "Tick");
            this.imageListSmall.Images.SetKeyName(4, "Coin");
            this.imageListSmall.Images.SetKeyName(5, "Lamp");
            // 
            // tabDescribedTask1
            // 
            this.tabDescribedTask1.Location = new System.Drawing.Point(22, 35);
            this.tabDescribedTask1.Name = "tabDescribedTask1";
            this.tabDescribedTask1.Size = new System.Drawing.Size(737, 499);
            this.tabDescribedTask1.TabIndex = 0;
            // 
            // DebugForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 592);
            this.Controls.Add(this.tabDescribedTask1);
            this.Name = "DebugForm1";
            this.Text = "DebugForm1";
            this.Load += new System.EventHandler(this.DebugForm1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageListTasks;
        private System.Windows.Forms.ImageList imageListSmall;
        private TabDescribedTask tabDescribedTask1;
    }
}