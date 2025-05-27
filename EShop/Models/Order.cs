using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Models
{
    public class Order
    {
        public int OrderID { get; set; }

        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        public DateTime OrderDate { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal TotalPrice { get; set; }
    }

}
