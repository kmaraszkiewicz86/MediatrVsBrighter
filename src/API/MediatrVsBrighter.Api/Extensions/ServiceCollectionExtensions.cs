using MediatrVsBrighter.Api.Database;
using CreateProductRepositoryBrighter = MediatrVsBrighter.Api.Features.Brighter.CreateProduct.CreateProductRepository;
using CreateProductRepositoryMediatr = MediatrVsBrighter.Api.Features.Mediatr.CreateProduct.CreateProductRepository;
using GetAllDatabaseQueryBrighter = MediatrVsBrighter.Api.Features.Brighter.GetAll.GetAllDatabaseQuery;
using GetAllDatabaseQueryMediatr = MediatrVsBrighter.Api.Features.Mediatr.GetAll.GetAllDatabaseQuery;
using ICreateProductRepositoryBrighter = MediatrVsBrighter.Api.Features.Brighter.CreateProduct.ICreateProductRepository;
using ICreateProductRepositoryMediatr = MediatrVsBrighter.Api.Features.Mediatr.CreateProduct.ICreateProductRepository;
using IGetAllDatabaseQueryBrighter = MediatrVsBrighter.Api.Features.Brighter.GetAll.IGetAllDatabaseQuery;
using IGetAllDatabaseQueryMediatr = MediatrVsBrighter.Api.Features.Mediatr.GetAll.IGetAllDatabaseQuery;


namespace MediatrVsBrighter.Api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDatabaseClasses(this IServiceCollection services)
        {
            services.AddScoped<ICreateProductRepositoryMediatr, CreateProductRepositoryMediatr>();
            services.AddScoped<ICreateProductRepositoryBrighter, CreateProductRepositoryBrighter>();
            services.AddScoped<IGetAllDatabaseQueryMediatr, GetAllDatabaseQueryMediatr>();
            services.AddScoped<IGetAllDatabaseQueryBrighter, GetAllDatabaseQueryBrighter>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}