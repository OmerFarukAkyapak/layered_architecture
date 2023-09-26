using Bussiness.Abstract;
using Bussiness.Concrete;
using DataAccess.Abstact;
using DataAccess.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Bussiness.DependencyResolvers
{
    public class DependencyInjection
    {
        public static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddSingleton<IAnimalService, AnimalManager>();
            services.AddSingleton<IAnimalDal, EfAnimalDal>();

            services.AddSingleton<IProductService, ProductManager>();
            services.AddSingleton<IProductDal, EfProductDal>();

            services.AddSingleton<IBarnService, BarnManager>();
            services.AddSingleton<IBarnDal, EfBarnDal>();

            services.AddSingleton<IAnimalTypesService, AnimalTypesManager>();
            services.AddSingleton<IAnimalTypeDal, EfAnimalTypesDal>();

            services.AddSingleton<IProductTypesService, ProductTypesManager>();
            services.AddSingleton<IProductTypesDal, EfProductTypesDal>();

            services.AddSingleton<IAnimalGendersService, AnimalGendersManager>();
            services.AddSingleton<IAnimalGendersDal, EfAnimalGendersDal>();

            services.AddSingleton<IAnimalViewService, AnimalViewManager>();
            services.AddSingleton<IAnimalsViewDal, EfAnimalsViewDal>();

            services.AddSingleton<IProductsViewService, ProductsViewManager>();
            services.AddSingleton<IProductsViewDal, EfProductsViewDal>();

            var serviceProvider = services.BuildServiceProvider();

            return serviceProvider;

        }
    }
}
