using Volo.Abp.Modularity;

namespace Ran.Analytics
{
    [DependsOn(
        typeof(AnalyticsDomainSharedModule)
        )]
    public class AnalyticsDomainModule : AbpModule
    {

    }
}
