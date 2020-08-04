using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Application.Models
{
    public class OrderElement
    {
        public Guid ID { get; set; }
        public Guid OrderID { get; set; }
        public Guid ItemID { get; set; }
        public int ItemsCount { get; set; }

        [Column(TypeName = "money")]
        public decimal ItemPrice { get; set; }
    }
}