using Bussiness.Abstract;
using Bussiness.Concrete;
using DataAccess.Abstact;
using DataAccess.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.DependencyResolvers
{
    public class DI
    {
        public static IServiceProvider ServiceProvider { get;  set; }
        public static void RegisterServices()
        {
            var services = new ServiceCollection();


            services.AddSingleton<IAnimalService, AnimalManager>();
            services.AddSingleton<IAnimalDal, EfAnimalDal>();
            services.AddSingleton<IProductService, ProductManager>();
            services.AddSingleton<IProductDal, EfProductDal>();
            services.AddSingleton<IBarnService, BarnManager>();
            services.AddSingleton<IBarnDal, EfBarnDal>();

            ServiceProvider = services.BuildServiceProvider();

        }
        

        
    }
}
