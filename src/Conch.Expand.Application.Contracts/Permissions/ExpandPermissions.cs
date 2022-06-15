using Volo.Abp.Reflection;

namespace Conch.Expand.Permissions;

public class ExpandPermissions
{
    public const string GroupName = "Expand";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(ExpandPermissions));
    }
}
