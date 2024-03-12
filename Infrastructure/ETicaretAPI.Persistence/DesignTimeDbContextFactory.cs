using ETicaretAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ETicaredAPIDbContext>
    {
        public ETicaredAPIDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<ETicaredAPIDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);
            return new ETicaredAPIDbContext(dbContextOptionsBuilder.Options);
        }
    }
}
