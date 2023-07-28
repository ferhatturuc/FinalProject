using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine("Ürün Adı:" + product.ProductName + " Ürün fiyatı: " + product.UnitPrice+ " Stok Sayısı:"+ product.UnitsInStock);
            }
        }
    }
}