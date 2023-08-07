using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers.Autofac;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //Autofac, Ninject,CastleWindsor,StructureMap, LightInject, DryInject --> IoC Container
            //Autofac bize AOP imkaný sunuyor. -- Postsharp ücretli hali
            // Add services to the container.
            builder.Services.AddControllers();
            //Business.DependencyResolvers.Autofac yazdýðýmýzý kullanýyoruz o yuzden commentde
            //builder.Services.AddSingleton<IProductService, ProductManager>();
            //builder.Services.AddSingleton<IProductDal,EfProductDal>();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //aþaðýdaki kodla autofac i kullanýyoruz
            builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
            builder.Host.ConfigureContainer<ContainerBuilder>(options =>
            {
                options.RegisterModule(new AutofacBusinessModule());
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}