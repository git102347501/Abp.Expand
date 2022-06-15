using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace Conch.Expand.Blazor.Server;

[DependsOn(
    typeof(AbpAspNetCoreComponentsServerThemingModule),
    typeof(ExpandBlazorModule)
    )]
public class ExpandBlazorServerModule : AbpModule
{

}
