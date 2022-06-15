using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Conch.Expand.EntityFrameworkCore;

[ConnectionStringName(ExpandDbProperties.ConnectionStringName)]
public class ExpandDbContext : AbpDbContext<ExpandDbContext>, IExpandDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public ExpandDbContext(DbContextOptions<ExpandDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureExpand();
    }
}
