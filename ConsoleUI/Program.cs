using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID
    //Open Closed Principle - yeni bir özellik eklenirken mevcut kodu değiştirmezsin
    internal class Program
    {
        static void Main(string[] args)
        {
            //InMemoryProductDal'dan EfProductDal'e gectik
            //ProductManager productManager = new ProductManager(new InMemoryProductDal());
            ProductManager productManager = new ProductManager(new EfProductDal());

            /*foreach (var product in productManager.GetAll())
            {
                Console.WriteLine("Ürün Adı:" + product.ProductName + " Ürün fiyatı: " + product.UnitPrice+ " Stok Sayısı:"+ product.UnitsInStock);
            }*/

            /*foreach (var product in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine("Ürün Adı:" + product.ProductName + " Ürün fiyatı: " + product.UnitPrice + " Stok Sayısı:" + product.UnitsInStock);
            }*/

            foreach (var product in productManager.GetAllByUnitPrice(40, 100))
            {
                Console.WriteLine("Ürün Adı:" + product.ProductName + " Ürün fiyatı: " + product.UnitPrice + " Stok Sayısı:" + product.UnitsInStock);
            }
        }
    }
}