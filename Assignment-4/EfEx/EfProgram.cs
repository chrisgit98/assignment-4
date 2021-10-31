using EfEx.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Npgsql;
using Microsoft.Extensions.DependencyInjection;


namespace EfEx
{

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<NorthwindContext>();
        }
    }

    internal class EfProgram
    {
        static void Main(string[] args)
        {
            var dataservice = new DataService();

            foreach (var category in dataservice.GetCategories())
            {
                Console.WriteLine(category);
            }
        }
    }
}
//        static void FirstTake()
//        {
//        var ctx = new NorthwindContext();

//        var categories = ctx.Categories;

//        foreach (var category in categories)
//        {
//            Console.WriteLine(category);
//        }

//var cat = new Category
//{
//    Id = 101,
//    Name = "fdfjslfdjfk",
//    Description = "blah blah"
//};

//ctx.Categories.Add(cat);
//ctx.SaveChanges();

//var cat = ctx.Categories.Find(101);

//cat.Name = "New name";
//ctx.SaveChanges();

//ctx.Categories.Remove(ctx.Categories.Find(101));
//ctx.SaveChanges();

//        var products = ctx.Products.Include(x => x.CategoryId);

//        foreach (var product in products)
//        {
//        Console.WriteLine(product);
//        }
//        }



//    }
//}
