using announcements_backend.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace announcements_backend.Permissions;

public class announcements_backendPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(announcements_backendPermissions.GroupName, L("Permission:announcements_backend"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<announcements_backendResource>(name);
    }
}
