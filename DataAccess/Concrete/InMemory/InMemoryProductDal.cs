using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        public void Add(Product product)
        {
            Console.WriteLine("Eklendi.");
        }

        public void Delete(Product product)
        {
            Console.WriteLine("Silindi.");
        }

        public List<Product> GetAll()
        {
            Console.WriteLine("Listelendi");
        }

        public void Update(Product product)
        {
            Console.WriteLine("Güncellendi.");
        }
    }
}
