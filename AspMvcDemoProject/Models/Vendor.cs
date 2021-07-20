using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspMvcDemoProject.Models
{
    public class Vendor
    {
        [Key]
        [DisplayName("Code")]
        public int V_code { set; get; }
        [DisplayName("Name")]
        public string V_name { set; get; }
        [DisplayName("Contact")]
        public string V_contact { set; get; }
        [DisplayName("Area Code")]
        public int V_AreaCode { set; get; }
        [DisplayName("Phone Number")]
        public string V_phone { set; get; }
        [DisplayName("State")]
        public string V_state { set; get; }
        [DisplayName("Order ('Y'/'N')")]
        public string V_order { set; get; }
    }
}
