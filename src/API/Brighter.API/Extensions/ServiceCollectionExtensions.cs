using FluentValidation;
using MediatrVsBrighter.Api.Features.Brighter.CreateProduct;
using MediatrVsBrighter.Api.Features.Brighter.GetAll;
using Paramore.Brighter.Extensions.DependencyInjection;


namespace Brighter.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBrighterServices(this IServiceCollection services)
        {
            services.AddScoped<ICreateProductRepository, CreateProductRepository>();
            services.AddScoped<IGetAllDatabaseQuery, GetAllDatabaseQuery>();

            services.AddBrighter()
                .AutoFromAssemblies(typeof(CreateProductCommand).Assembly);

            services.AddValidatorsFromAssembly(typeof(Program).Assembly);

            return services;
        }
    }
}