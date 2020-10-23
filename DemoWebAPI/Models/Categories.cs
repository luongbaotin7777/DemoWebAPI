using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWebAPI.Models
{
    [Table("Categories")]
    public class Categories
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<ProductInCategory> ProductInCategories { get; set; }
    }
}
