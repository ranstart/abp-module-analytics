using Volo.Abp.Modularity;

namespace Ran.Analytics
{
    [DependsOn(
        typeof(AnalyticsApplicationModule),
        typeof(AnalyticsDomainTestModule)
        )]
    public class AnalyticsApplicationTestModule : AbpModule
    {

    }
}
