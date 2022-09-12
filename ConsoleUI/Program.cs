// See https://aka.ms/new-console-template for more information
using Business.Concreate;
using DataAccess.Concreate.InMemory;

ProductManager productManager = new ProductManager(new InMemoryProductDal());
foreach (var item in productManager.GetAll())
{
    Console.WriteLine(item.ProductName);
}

