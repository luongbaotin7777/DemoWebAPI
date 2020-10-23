﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWebAPI.Models
{
    [Table("Products")]
    public class Products
    {
        
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { set; get; }
    }
}
