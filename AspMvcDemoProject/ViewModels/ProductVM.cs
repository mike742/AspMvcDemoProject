using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspMvcDemoProject.ViewModels
{
    public class ProductVM
    {
        public string Id { set; get; }
        public string Descript { set; get; }
        public double Price { set; get; }
        public bool IsActive { set; get; }
    }
}
