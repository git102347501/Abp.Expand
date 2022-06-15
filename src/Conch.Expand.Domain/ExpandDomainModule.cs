using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Conch.Expand;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(ExpandDomainSharedModule)
)]
public class ExpandDomainModule : AbpModule
{

}
