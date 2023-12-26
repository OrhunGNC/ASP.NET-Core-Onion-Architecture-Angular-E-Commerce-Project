using eCommerceAPI.Application.Abstractions;
using eCommerceAPI.Persistence.Concretes;
using Microsoft.EntityFrameworkCore;
using eCommerceAPI.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            //services.AddSingleton<IProductService, ProductService>();
            services.AddDbContext<eCommerceAPIDbContext>(opt => opt.UseNpgsql(Configuration.ConnectionString));
        }
    }
}
