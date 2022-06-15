using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Conch.Expand;

[DependsOn(
    typeof(ExpandDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class ExpandApplicationContractsModule : AbpModule
{

}
