using BulberDinner.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace BulberDinner.Permissions;

public class BulberDinnerPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BulberDinnerPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(BulberDinnerPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BulberDinnerResource>(name);
    }
}
