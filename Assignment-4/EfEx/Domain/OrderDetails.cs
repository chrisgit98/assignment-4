using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfEx.Domain
{
    [Keyless]
    public class OrderDetails
    {
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }
       

        public override string ToString()
        {
            return $"UnitPrice = {UnitPrice}, Quantity = {Quantity}, Discount = {Discount}";
        }
    }
}
