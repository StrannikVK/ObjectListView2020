using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLVTools2020.Utilities
{
    public partial class TestObject
    {

        [Description("Company Symbol/Ticker "), Category("INDUSTRY, SECTOR AND SYMBOL")]
        public string Symbol { get; set; } = "Not_Set";
        public string Symbol_Cleaned { get { string oNewS = Symbol.Replace(".", "_"); oNewS = oNewS.Replace(" ", "_"); oNewS = oNewS.Replace("/", "_"); return Symbol; } }

        public string Enabled { get; set; } = "true";
        public string Name { get; set; } = "SymbolObject";
        public string Status
        {
            get
            {
                //bool oIs_All_Good = false;

                //string oValue = Check_Low_Med_High(out oIs_All_Good);
                return "Testing";
            }
        }
        public string Replaced_By_Symbol { get; set; } = "N/A";

        public double Potential { get; set; } = 0;
        public double Risk { get; set; } = 0;
        public double Beta { get; set; } = 0;

        [Description("SecurityType"), Category("INDUSTRY, SECTOR AND SYMBOL")]
        public string SecurityType { get; set; } = "N/A";

        [Description("Company Ticker "), Category("INDUSTRY, SECTOR AND SYMBOL")]
        public string Ticker { get; set; } = "N/A";

        [Description("Stock Exchange "), Category("INDUSTRY, SECTOR AND SYMBOL")]
        public string Exchange { get; set; } = "N/A";

        [Description("Company Name "), Category("INDUSTRY, SECTOR AND SYMBOL")] 
        public string CompanyName { get; set; } = "N/A";

        [Description("Sub_Industry "), Category("INDUSTRY, SECTOR AND SYMBOL")]
        public string Sub_Industry { get; set; } = "N/A";

        [Description("Industry "), Category("INDUSTRY, SECTOR AND SYMBOL")]
        public string Industry { get; set; } = "N/A";

        [Description("Industry_Group "), Category("INDUSTRY, SECTOR AND SYMBOL")]
        public string Industry_Group { get; set; } = "N/A";

        [Description("Sector "), Category("INDUSTRY, SECTOR AND SYMBOL")]
        public string Sector { get; set; } = "N/A";
        public string Descriptions { get; set; } = "N/A";

        public string Notes { get; set; } = "N/A";

        [Description("Debt-to-Equity Ratio "), Category("DEBT")]
        public double Debt_to_Equity_Ratio { get; set; } = 0;

        [Description("MarketCap "), Category("Financial Summary")]
        public double MarketCap { get; set; } = 0;

        [Description("Employees "), Category("Financial Summary")]
        public double Employees { get; set; } = 0;

        [Description("Sales_Annual "), Category("Financial Summary")]
        public double Sales_Annual { get; set; } = 0;
        //public string Sales { get; set; } = "0";
        [Description("Net Income "), Category("Financial Summary")]
        public double Net_Income { get; set; } = 0;

        [Description("Earnings_Per_Share EPS "), Category("Financial Summary")]
        public string Earnings_Per_Share { get; set; } = "0";

        public double Dividend { get; set; } = 0;

        [Description("Price / Sales "), Category("Financial Summary")]
        public double Price_Sales_Ratio { get; set; } = 0;

        [Description("Cash Flow per Share"), Category("Financial Summary")]
        public double Cash_Flow { get; set; } = 0;

        [Description("Price_Earnings_Ratio "), Category("Financial Summary")]
        public double Price_Earnings_Ratio { get; set; } = 0;

        [Description("Price_Book_Ratio "), Category("Financial Summary")]
        public double Price_Book_Ratio { get; set; } = 0;

        [Description("Volume "), Category("Financial Summary")]
        public double Volume { get; set; } = 0;

        [Description("Volume_Average "), Category("Financial Summary")]
        public double Volume_Average { get; set; } = 0;

        //public string Index_Constituet { get; set; } = "N/A";

        private double _Price_Last = 0;
        public double Price_Last
        {
            get { return _Price_Last; }
            set { _Price_Last = value; }
        }

        public double Price_Last_Epoch { get; set; } = 0;

        public string Price_Last_Local_Time
        {
            get { return "Test Time"; }//EpochTo_Local(Price_Last_Epoch); }
        }

        public string Reporting_Date { get; set; } = "0";

        private double _Range_52_Weeks_Max = 0;
        public double Range_52_Weeks_Max
        {
            get
            {
                return _Range_52_Weeks_Max;
            }
            set
            {
                _Range_52_Weeks_Max = value;/* }*/
            }
        }

        private double _Range_52_Weeks_Min = 0;
        public double Range_52_Weeks_Min
        {
            get
            {
                //if (Price_Last!=0 && Price_Last < _Range_52_Weeks_Min) { _Range_52_Weeks_Min = Price_Last; }
                return _Range_52_Weeks_Min;
            }
            set
            {
                _Range_52_Weeks_Min = value;
            }
        }

        public double Elevation_52_Weeks
        {
            get { return 0; }
        }


        public TestObject()
        {
          

        }



    }
}
