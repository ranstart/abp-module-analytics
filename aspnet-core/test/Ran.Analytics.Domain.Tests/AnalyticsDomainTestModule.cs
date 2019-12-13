using Ran.Analytics.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Ran.Analytics
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(AnalyticsEntityFrameworkCoreTestModule)
        )]
    public class AnalyticsDomainTestModule : AbpModule
    {
        
    }
}
