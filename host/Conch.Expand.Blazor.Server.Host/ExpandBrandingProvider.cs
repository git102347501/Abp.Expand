using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Conch.Expand.Blazor.Server.Host;

[Dependency(ReplaceServices = true)]
public class ExpandBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Expand";
}
