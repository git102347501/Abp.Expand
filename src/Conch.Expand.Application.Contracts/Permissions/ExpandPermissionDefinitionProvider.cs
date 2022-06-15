using Conch.Expand.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Conch.Expand.Permissions;

public class ExpandPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ExpandPermissions.GroupName, L("Permission:Expand"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ExpandResource>(name);
    }
}
