using Conch.Expand.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Conch.Expand.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ExpandPageModel : AbpPageModel
{
    protected ExpandPageModel()
    {
        LocalizationResourceType = typeof(ExpandResource);
        ObjectMapperContext = typeof(ExpandWebModule);
    }
}
