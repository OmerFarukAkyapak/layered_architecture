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
    public class DependencyInjection
    {
        //public static IServiceProvider ServiceProvider { get;  set; }
        public static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddSingleton<IAnimalService, AnimalManager>();
            services.AddSingleton<IAnimalDal, EfAnimalDal>();
            services.AddSingleton<IProductService, ProductManager>();
            services.AddSingleton<IProductDal, EfProductDal>();
            services.AddSingleton<IBarnService, BarnManager>();
            services.AddSingleton<IBarnDal, EfBarnDal>();

            var serviceProvider = services.BuildServiceProvider();
            
            return serviceProvider;

        }
        

        
    }
}
