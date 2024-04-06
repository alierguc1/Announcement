using Volo.Abp.Reflection;

namespace announcements_backend.Permissions;

public class announcements_backendPermissions
{
    public const string GroupName = "announcements_backend";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(announcements_backendPermissions));
    }
}
