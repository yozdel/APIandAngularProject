// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

ProductManager ProductManager = new ProductManager(new EfProductDal());
foreach (var product in ProductManager.GetAllByUnitPrice(40,100))
{
    Console.WriteLine(product.ProductName);
}


