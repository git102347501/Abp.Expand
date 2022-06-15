using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Conch.Expand;

[Dependency(ReplaceServices = true)]
public class ExpandBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Expand";
}
