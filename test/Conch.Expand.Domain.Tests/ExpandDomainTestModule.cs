using Conch.Expand.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Conch.Expand;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(ExpandEntityFrameworkCoreTestModule)
    )]
public class ExpandDomainTestModule : AbpModule
{

}
