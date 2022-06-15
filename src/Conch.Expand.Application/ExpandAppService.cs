using Conch.Expand.Localization;
using Volo.Abp.Application.Services;

namespace Conch.Expand;

public abstract class ExpandAppService : ApplicationService
{
    protected ExpandAppService()
    {
        LocalizationResource = typeof(ExpandResource);
        ObjectMapperContext = typeof(ExpandApplicationModule);
    }
}
