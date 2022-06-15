using Volo.Abp.Modularity;

namespace Conch.Expand;

[DependsOn(
    typeof(ExpandApplicationModule),
    typeof(ExpandDomainTestModule)
    )]
public class ExpandApplicationTestModule : AbpModule
{

}
