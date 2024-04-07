using AnnouncementAPI.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AnnouncementAPI.Permissions;

public class AnnouncementAPIPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AnnouncementAPIPermissions.GroupName, L("Permission:AnnouncementAPI"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AnnouncementAPIResource>(name);
    }
}
