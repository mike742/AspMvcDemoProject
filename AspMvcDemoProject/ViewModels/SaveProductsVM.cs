using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspMvcDemoProject.ViewModels
{
    public class SaveProductsVM
    {
        public List<ProductVM> Products { set; get; }
        public int OrderId { set; get; }
    }
}
