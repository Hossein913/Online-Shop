using App.Domain.AppServices;
using App.Domain.core.Datas.EfRipository;
using App.Domain.core.IAppService;
using App.Domain.core.IService;
using App.Domain.Services;
using App.Infra.Data.Repos.EF;
using App.Infra.Data.ReposEf;

namespace App.EndPoints.Apis
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInjections(this IServiceCollection services)
        {
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICategoryAppService, CategoryAppService>();

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductAppService, ProductAppService>();



            return services;
        }
    }
}
