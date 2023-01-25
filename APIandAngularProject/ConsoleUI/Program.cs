// See https://aka.ms/new-console-template for more information

using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

ProductTest();
//CategoryTest();

static void ProductTest()
{
    IProductService productService = new ProductManager(new EfProductDal());
    var resultt = productService.GetAll();
    ProductManager ProductManager = new ProductManager(new EfProductDal());
    var result = ProductManager.GetProductDetails();
    if (result.Success)
    {
        foreach (var product in ProductManager.GetProductDetails().Data)
        {
            Console.WriteLine(product.ProductName + "/" + product.CategoryName);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
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