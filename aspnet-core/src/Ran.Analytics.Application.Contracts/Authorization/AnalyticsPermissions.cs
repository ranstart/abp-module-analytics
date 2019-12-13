using Volo.Abp.Reflection;

namespace Ran.Analytics.Authorization
{
    public class AnalyticsPermissions
    {
        public const string GroupName = "Analytics";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(AnalyticsPermissions));
        }
    }
}