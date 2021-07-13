using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspMvcDemoProject.Models
{
    public class Product
    {
        public string P_Code { set; get; }
        public string P_descript { set; get; }
        public DateTime P_InDate { set; get; }
        public int P_QOH { set; get; }
        public int P_Min { set; get; }
        public double P_Price { set; get; }
        public double P_Discount { set; get; }
        public int? V_code { set; get; }
    }
}
