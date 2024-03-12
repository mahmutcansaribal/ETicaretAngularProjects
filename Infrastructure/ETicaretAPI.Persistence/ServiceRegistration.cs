using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace ETicaretAPI.Persistence
{
    public static class ServiceRegistration
    {
        //Extension Metot
        public static void AddPersistanceServices(this IServiceCollection services)
        {
            services.AddDbContext<ETicaredAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
        }
    }
}
