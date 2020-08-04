using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Application.Models
{
    public class Product
    {
        public Guid ID { get; set; }
        [MaxLength(12)]
        public string Code { get; set; }
        public string Name { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        public string Category { get; set; }
        public virtual ICollection<OrderElement> OrderElements { get; set; }
    }
}