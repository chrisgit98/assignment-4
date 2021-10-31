using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfEx.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public int OrderDate { get; set; }
        public int RequiredDate { get; set; }
        public int ShippedDate { get; set; }
        public int Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipCity { get; set; }

        public override string ToString()
        {
            return $"Id = {Id}, OrderDate = {OrderDate}, RequiredDate = {RequiredDate}, ShoppedDate = {ShippedDate}, Freight = {Freight}, ShipName = {ShipName}, ShipCity = {ShipCity}";
        }



    }
}
