using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Conch.Expand.EntityFrameworkCore;

public class ExpandHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<ExpandHttpApiHostMigrationsDbContext>
{
    public ExpandHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<ExpandHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Expand"));

        return new ExpandHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
