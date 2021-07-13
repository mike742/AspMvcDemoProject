using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspMvcDemoProject.Models
{
    public class Vendor
    {
        public int V_code { set; get; }
        public string V_name { set; get; }
        public string V_contact { set; get; }
        public int V_AreaCode { set; get; }
        public string V_phone { set; get; }
        public string V_state { set; get; }
        public string V_order { set; get; }
    }
}
