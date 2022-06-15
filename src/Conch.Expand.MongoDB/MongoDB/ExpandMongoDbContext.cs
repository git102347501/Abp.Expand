using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Conch.Expand.MongoDB;

[ConnectionStringName(ExpandDbProperties.ConnectionStringName)]
public class ExpandMongoDbContext : AbpMongoDbContext, IExpandMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureExpand();
    }
}
