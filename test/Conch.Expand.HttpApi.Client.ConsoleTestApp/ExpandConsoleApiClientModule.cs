using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Conch.Expand;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ExpandHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class ExpandConsoleApiClientModule : AbpModule
{

}
