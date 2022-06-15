using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Conch.Expand.EntityFrameworkCore;

[ConnectionStringName(ExpandDbProperties.ConnectionStringName)]
public interface IExpandDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
