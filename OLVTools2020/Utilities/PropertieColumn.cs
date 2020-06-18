using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLVTools2020.Utilities
{
    public class PropertieColumn
    {
        public string Propertie_Name { get; set; } = "Propertie_Name";

        public string Name { get; set; } = "Name";

        public string AspectName { get; set; } = "DebugingValue";

        public string AspectToStringFormat { get; set; } = "";
        
        public int Width { get; set; } = 40;
        public bool IsVisible { get; set; } = true;

        public bool IsNumber { get; set; } = false;

        public int DisplayIndex { get; set; } = 0;

        public string Text { get; set; } = "Header_Text";

        public string ToolTipText { get; set; } = "ToolTipText";

        public void OLVColumn_To_PropertieColumn(BrightIdeasSoftware.OLVColumn oOLVColumn)
        {
            try
            {
                this.Propertie_Name = oOLVColumn.AspectName;
                this.Name = "OLVColumn_" + oOLVColumn.AspectName;
                this.AspectName = oOLVColumn.AspectName;
                this.AspectToStringFormat = oOLVColumn.AspectToStringFormat;
                this.Width = oOLVColumn.Width;
                this.DisplayIndex = oOLVColumn.DisplayIndex;
                this.Text = oOLVColumn.Text;
                this.ToolTipText = oOLVColumn.ToolTipText;
                this.IsVisible = oOLVColumn.IsVisible;
            }
            catch (Exception ex) { string oDebug = ex.Message; }


        }

        public void PropertieColumn_To_OLVColumn(BrightIdeasSoftware.OLVColumn oOLVColumn)
        {
            try
            {
                oOLVColumn.AspectName = this.Propertie_Name;
                oOLVColumn.Name = this.Name;
                oOLVColumn.AspectName = this.AspectName;
                oOLVColumn.AspectToStringFormat = this.AspectToStringFormat;
                oOLVColumn.Width = this.Width;
                //oOLVColumn.DisplayIndex=this.DisplayIndex ; // apply after all clolumns loaded
                oOLVColumn.Text = this.Text;
                oOLVColumn.ToolTipText = this.ToolTipText;
                oOLVColumn.IsVisible = this.IsVisible;// apply after all clolumns loaded
            }
            catch (Exception ex) { string oDebug = ex.Message; }


        }
    }
}
