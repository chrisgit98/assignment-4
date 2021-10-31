using System;
using System.Linq;
using Xunit;
using Microsoft.Extensions.DependencyInjection;
using EfEx.Domain;
using EfEx;

namespace Assignment4.Tests
{
    public class DataServiceTest
    {
        //public void Category_Object_HasIdNameAndDescription()
        //{
        //    var category = new Category();
        //    Assert.Equal(0, category.Id);
        //    Assert.Null(category.Name);
        //    Assert.Null(category.Description);
        //}

        //public void GetAllCategories_NoArgument_ReturnsAllCategories()
        //{
        //    var service = new DataService();
        //    var categories = service.GetCategories();
        //    Assert.Equal(8, categories.Count);
        //    Assert.Equal("Beverages", categories.First().Name);
        //}

        //public void GetCategory_ValidId_ReturnsCategoryObject()
        //{
        //    var service = new DataService();
        //    var category = service.GetCategory(1);
        //    Assert.Equal("Beverages", category.Name);
        //}

        //public void GetOrder_ValidId_ReturnsCompleteOrder()
        //{
        //    var service = new DataService();
        //    var order = service.GetOrder(10248);
        //    Assert.Equal(3, order.OrderDetails.Count);
        //    Assert.Equal("Queso Cabrales", order.OrderDetails.First().Product.Name);
        //    Assert.Equal("Dairy Products", order.OrderDetails.First().Product.Category.Name);
        //}

        //public void GetOrder()
        //{
        //    var service = new DataService();
        //    var orders = service.GetOrder();
        //    Assert.Equal(830, orders.Count);
        //}
    }
}