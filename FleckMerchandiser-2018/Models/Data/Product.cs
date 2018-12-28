using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FleckMerchandiser2018.Models.Data
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string DefaultImageUrl { get; set; }
        public ProductStatus Status { get; set; }
    }

    public enum ProductStatus
    {
        Available = 0,
        Sold = 1,
        Other = 2
    }
}
