using CreateProductRepositoryMediatr = MediatrVsBrighter.Api.Features.Mediatr.CreateProduct.CreateProductRepository;
using GetAllDatabaseQueryMediatr = MediatrVsBrighter.Api.Features.Mediatr.GetAll.GetAllDatabaseQuery;
using ICreateProductRepositoryMediatr = MediatrVsBrighter.Api.Features.Mediatr.CreateProduct.ICreateProductRepository;
using IGetAllDatabaseQueryMediatr = MediatrVsBrighter.Api.Features.Mediatr.GetAll.IGetAllDatabaseQuery;


namespace Mediatr.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMediatrServices(this IServiceCollection services)
        {
            services.AddScoped<ICreateProductRepositoryMediatr, CreateProductRepositoryMediatr>();
            services.AddScoped<IGetAllDatabaseQueryMediatr, GetAllDatabaseQueryMediatr>();

            //services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetAllDatabaseQueryMediatr).Assembly));


            return services;
        }
    }
}