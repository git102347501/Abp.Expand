using Localization.Resources.AbpUi;
using Conch.Expand.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Conch.Expand;

[DependsOn(
    typeof(ExpandApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class ExpandHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(ExpandHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<ExpandResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
