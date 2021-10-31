using EfEx.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfEx
{

    public interface IDataService
    {
        //IList<Category> GetCategories();
        //bool CreateCategory(Category category);

        //IList<Products> GetProducts();

    }
    public class DataService : IDataService
    {
        //public bool CreateCategory(Category category)
        //{
        //    var ctx = new NorthwindContext();
        //    category.Id = ctx.Categories.Max(x => x.Id) + 1;
        //    ctx.Add(category);
        //    return ctx.SaveChanges() > 0;
        //}

        public IList<Category> GetCategories()
        {
            var ctx = new NorthwindContext();
            return ctx.Categories.ToList();
        }

        public IList<Products> GetProducts()
        {
            var ctx = new NorthwindContext();
            return ctx.Products.ToList();
        }


        public static IList<Order> GetOrder(int a)

        {
            var ctx = new NorthwindContext();
            return ctx.Order.ToList();
        }

        public IList<OrderDetails> GetOrderDetails()
        {
            var ctx = new NorthwindContext();
            return ctx.OrderDetails.ToList();
        }

        internal object GetOrder()
        {
            throw new NotImplementedException();
        }
    }
}