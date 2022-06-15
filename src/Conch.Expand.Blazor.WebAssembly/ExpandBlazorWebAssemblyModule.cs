using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace Conch.Expand.Blazor.WebAssembly;

[DependsOn(
    typeof(ExpandBlazorModule),
    typeof(ExpandHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class ExpandBlazorWebAssemblyModule : AbpModule
{

}
