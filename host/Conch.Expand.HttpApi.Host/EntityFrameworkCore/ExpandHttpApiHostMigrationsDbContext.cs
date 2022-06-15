using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Conch.Expand.EntityFrameworkCore;

public class ExpandHttpApiHostMigrationsDbContext : AbpDbContext<ExpandHttpApiHostMigrationsDbContext>
{
    public ExpandHttpApiHostMigrationsDbContext(DbContextOptions<ExpandHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureExpand();
    }
}
