using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLVTools2020.Utilities
{
    public class OLVMgrObject
    {
        public string Name { get; set; } = "OLVMgrObject";
        public string Filter_Name { get; set; } = "Name";
        public string Filter_Condition { get; set; } = "=";
        public string Filter_Level { get; set; } = "0";
        public string Filter_Value { get; set; } = "0";
        public int Total_Symbols { get; set; } = 0;
        public int In_Q { get; set; } = 0;
        public int Symbols_Processed { get; set; } = 0;
        public double Updating_Seconds { get; set; } = 0;
        public double Updating_Minutess { get { return Updating_Seconds / 60; } }
        public string Last_Symbol { get; set; } = "N/A";
        public double Elevation_Average { get; set; } = 0;
        public string Sorting_Parameter { get; set; } = "Low_Percentage";
        public List<PropertieColumn> List_Of_PropertieColumn { get; set; } = new List<PropertieColumn>();

    }

}
