using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspMvcDemoProject.Models
{
    public class OrderProducs
    {
        [Key]
        public int Id { set; get; }

        [ForeignKey("Product")]
        public string P_Code { set; get; }
        public Product Product { set; get; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
