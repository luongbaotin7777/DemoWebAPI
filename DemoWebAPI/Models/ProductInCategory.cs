using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWebAPI.Models
{
    [Table("ProductInCategory")]
    public class ProductInCategory
    {
        public long ProductId { get; set; }
        public Products Product { get; set; }
        public long CategoryId { get; set; }
        public Categories Category { get; set; }
    }
}
