using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
   //Context : Db tabloları ile proje classlarını bağlamak
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=northwind;Trusted_Connection=true");
        }
        //DbSet<Order> veritabanında bir tabloyu temsil eder
        //<Order> ifadesi, "Order" adlı sınıfın veritabanındaki tablosunu temsil etmek için kullanıldığını belirtir.
        //Orders"  Bu, özelliğin adıdır. Özelliğe "Orders" adıyla erişilebilir olacak.
        //order nesnesini Orders ' la ilişkilendirme

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

    }
}
