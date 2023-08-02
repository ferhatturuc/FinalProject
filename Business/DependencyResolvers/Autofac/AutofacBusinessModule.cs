using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //birisi IProductService isterse ProductManager ver
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            //birisi IProductDal isterse EfProductDal ver
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();

        }
    }
}
