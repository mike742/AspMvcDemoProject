using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspMvcDemoProject.Models
{
    public class ProductDto
    {
        [DisplayName("Code")]
        public string P_Code { set; get; }
        
        [DisplayName("Desc")]
        public string P_descript { set; get; }
        
        [DisplayName("In Date")]
        public DateTime P_InDate { set; get; }

        [DisplayName("QOH")]
        public int P_QOH { set; get; }
        
        [DisplayName("Min")]
        public int P_Min { set; get; }

        [DisplayName("Price")]
        public double P_Price { set; get; }
        
        [DisplayName("Discount")]
        public double P_Discount { set; get; }
        
        public int? V_code { set; get; }
        public VendorDto Vendor { set; get; }
    }
}
