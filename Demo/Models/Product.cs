using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class Product
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        public decimal Price { get; set; }
        [StringLength(50)]
        public string ImageName { get; set; }
    }
}