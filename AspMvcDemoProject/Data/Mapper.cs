using AspMvcDemoProject.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspMvcDemoProject.Data
{
    public class Mapper
    {
        public Vendor Map(VendorDto obj)
        {
            return new Vendor { 
                V_code = obj.V_code,
                V_name = obj.V_name,
                V_contact = null,
                V_AreaCode = obj.V_AreaCode,
                V_phone= obj.V_phone,
                V_state = obj.V_state,
                V_order = obj.V_order
            };
        }

        public VendorDto Map(Vendor obj)
        {
            return new VendorDto {

                V_code = obj.V_code,
                V_name = obj.V_name,
                V_AreaCode = obj.V_AreaCode,
                V_phone = obj.V_phone,
                V_state = obj.V_state,
                V_order = obj.V_order
            };
        }
    }
}
