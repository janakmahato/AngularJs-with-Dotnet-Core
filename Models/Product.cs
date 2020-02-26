﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Web.Models
{
    public class Product
    {
        public long ProductId { get; set; }
        public string Name { get; set; }
        public string  Category { get; set; }
        public string  Description { get; set; }
        [Column(TypeName="decimal(8,2)")]
        public decimal Price { get; set; }
        public Supplier Supplier  { get; set; }
        public List<Rating> Ratings { get; set; }
    }
}
