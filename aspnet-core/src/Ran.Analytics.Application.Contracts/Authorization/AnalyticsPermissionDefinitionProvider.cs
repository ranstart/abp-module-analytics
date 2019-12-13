using Ran.Analytics.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Ran.Analytics.Authorization
{
    public class AnalyticsPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            //var moduleGroup = context.AddGroup(AnalyticsPermissions.GroupName, L("Permission:Analytics"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AnalyticsResource>(name);
        }
    }
}