﻿using Business.Concrete;
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
            //ProductTest1();
            //ProductTest2();
            //ProductTest3();
            
            //IoC Container gelecek
            //InMemoryProductDal'dan EfProductDal'e gectik
            //ProductManager productManager = new ProductManager(new InMemoryProductDal());
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine("Kategori Adı:" + category.CategoryName);
            }
        }

        private static void ProductTest1()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAllByUnitPrice(40, 100))
            {
                Console.WriteLine("Ürün Adı:" + product.ProductName + " Ürün fiyatı: " + product.UnitPrice + " Stok Sayısı:" + product.UnitsInStock);
            }
        }

        private static void ProductTest2()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAll())
           {
               Console.WriteLine("Ürün Adı:" + product.ProductName + " Ürün fiyatı: " + product.UnitPrice+ " Stok Sayısı:"+ product.UnitsInStock);
           }
        }

        private static void ProductTest3()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine("Ürün Adı:" + product.ProductName + " Ürün fiyatı: " + product.UnitPrice + " Stok Sayısı:" + product.UnitsInStock);
            }
        }
    }
}