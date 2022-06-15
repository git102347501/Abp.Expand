using Volo.Abp.Bundling;

namespace Conch.Expand.Blazor.Host;

public class ExpandBlazorHostBundleContributor : IBundleContributor
{
    public void AddScripts(BundleContext context)
    {

    }

    public void AddStyles(BundleContext context)
    {
        context.Add("main.css", true);
    }
}
