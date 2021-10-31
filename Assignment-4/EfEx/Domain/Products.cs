using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfEx.Domain
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SupplierId { get; set; }
        public int CategoryId { get; set; }
        public int QuantityPerUnit { get; set; }
        public int UnitPrice { get; set; }
        public int UnitIsInStock { get; set; }
        //public Category Category { get; set; }

        public override string ToString()
        {
            return $"Id = {Id}, Name = {Name}, SupplierId = {SupplierId}, CategoryID = {CategoryId}, QuantityPerUnit = {QuantityPerUnit}, UnitPrice = {UnitPrice}, UnitIsInStock = {UnitIsInStock}";
        }
    }
}
