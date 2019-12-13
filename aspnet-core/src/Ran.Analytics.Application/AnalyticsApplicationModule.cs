using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace Ran.Analytics
{
    [DependsOn(
        typeof(AnalyticsDomainModule),
        typeof(AnalyticsApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule)
        )]
    public class AnalyticsApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<AnalyticsApplicationModule>(validate: true);
            });
        }
    }
}
