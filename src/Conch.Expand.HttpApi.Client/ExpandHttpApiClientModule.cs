using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Conch.Expand;

[DependsOn(
    typeof(ExpandApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class ExpandHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(ExpandApplicationContractsModule).Assembly,
            ExpandRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<ExpandHttpApiClientModule>();
        });

    }
}
