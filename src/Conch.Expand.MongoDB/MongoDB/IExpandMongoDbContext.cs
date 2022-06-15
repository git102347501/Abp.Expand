using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Conch.Expand.MongoDB;

[ConnectionStringName(ExpandDbProperties.ConnectionStringName)]
public interface IExpandMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
