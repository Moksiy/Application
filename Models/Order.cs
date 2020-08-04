using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application.Models
{
    public class Order
    {
        public Guid ID { get; set; }
        public Guid CustomerID { get; set; }
        //[DisplayFormat(DataFormatString ="{0:d}", ApplyFormatInEditMode =true)]
        public DateTime OrderDate { get; set; }
        public DateTime ShipmentDate { get; set; }
        public int OrderNumber { get; set; }
        public string Status { get; set; }
        public virtual ICollection<OrderElement> OrderElements { get; set; }
    }
}