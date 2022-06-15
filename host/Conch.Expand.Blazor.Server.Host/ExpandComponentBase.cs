using Conch.Expand.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Conch.Expand.Blazor.Server.Host;

public abstract class ExpandComponentBase : AbpComponentBase
{
    protected ExpandComponentBase()
    {
        LocalizationResource = typeof(ExpandResource);
    }
}
