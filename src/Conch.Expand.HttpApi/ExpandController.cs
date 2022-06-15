using Conch.Expand.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Conch.Expand;

public abstract class ExpandController : AbpControllerBase
{
    protected ExpandController()
    {
        LocalizationResource = typeof(ExpandResource);
    }
}
