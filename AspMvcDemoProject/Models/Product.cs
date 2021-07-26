using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspMvcDemoProject.Models
{
    public class Product
    {
        [Key]
        [DisplayName("Code")]
        public string P_Code { set; get; }
        
        [DisplayName("Desc")]
        [Required]
        [MaxLength(255, ErrorMessage ="Length of Product desc must be less than 255")]
        public string P_descript { set; get; }
        
        [DisplayName("In Date")]
        [Required]
        public DateTime P_InDate { set; get; }

        [DisplayName("QOH")]
        [Required]
        public int P_QOH { set; get; }
        
        [DisplayName("Min")]
        [Required]
        public int P_Min { set; get; }

        [DisplayName("Price")]
        [Required]
        [Range(0.01, double.MaxValue,
            ErrorMessage = "Price value must be greater than 0")]
        public double P_Price { set; get; }
        
        [DisplayName("Discount")]
        [Required]
        public double P_Discount { set; get; }
        
        [ForeignKey("Vendor")]
        public int? V_code { set; get; }
        public Vendor Vendor { set; get; }
    }
}
