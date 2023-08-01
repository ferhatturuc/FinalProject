using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            if (product.ProductName.Length < 2)
            {
                //magic strings
                return new ErrorResult(Messages.ProductNameInvalid);
;           }
            //business codes
            _productDal.Add(product);

            return new SuccessResult(Messages.ProductAdded);
        }

        public IDataResult<List<Product>> GetAll()
        {
            //İş kodları - Yetkisi var mı ? 
            //asağıdaki gibi yazarsak iş kodlarının tamamı bellekte çalışır
            //InMemoryProductDal inMemoryProductDal = new InMemoryProductDal();
            if (DateTime.Now.Hour == 15)
            {
                return new ErrorResult();
            }

            return new DataResult<List<Product>>(_productDal.GetAll(),true,"Ürünler listelendi");

            //Filtre işlemi
            //return _productDal.GetAll(p=>p.CategoryId==2);
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p=>p.CategoryId == id);
        }

        public List<Product> GetAllByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }

        public Product GetById(int productId)
        {
            return _productDal.Get(p=>p.ProductId == productId);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }
    }
}
