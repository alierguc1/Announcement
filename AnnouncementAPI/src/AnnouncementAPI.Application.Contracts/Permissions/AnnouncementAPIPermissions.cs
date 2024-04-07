using Volo.Abp.Reflection;

namespace AnnouncementAPI.Permissions;

public class AnnouncementAPIPermissions
{
    public const string GroupName = "AnnouncementAPI";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(AnnouncementAPIPermissions));
    }
}
