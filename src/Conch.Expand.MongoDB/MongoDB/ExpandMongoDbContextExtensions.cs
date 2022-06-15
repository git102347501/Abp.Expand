using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Conch.Expand.MongoDB;

public static class ExpandMongoDbContextExtensions
{
    public static void ConfigureExpand(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
