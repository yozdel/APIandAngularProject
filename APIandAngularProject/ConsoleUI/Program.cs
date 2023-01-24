// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

ProductTest();
//CategoryTest();

static void ProductTest()
{
    ProductManager ProductManager = new ProductManager(new EfProductDal());
    foreach (var product in ProductManager.GetProductDetails())
    {
        Console.WriteLine(product.ProductName + "/"+ product.CategoryName);
    }
}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine(category.CategoryName);
    }
}