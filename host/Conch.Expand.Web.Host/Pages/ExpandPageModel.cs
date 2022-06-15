using Conch.Expand.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Conch.Expand.Pages;

public abstract class ExpandPageModel : AbpPageModel
{
    protected ExpandPageModel()
    {
        LocalizationResourceType = typeof(ExpandResource);
    }
}
