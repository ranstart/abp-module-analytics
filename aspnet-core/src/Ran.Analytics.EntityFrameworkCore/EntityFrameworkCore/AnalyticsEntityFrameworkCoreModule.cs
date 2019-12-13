using Microsoft.Extensions.DependencyInjection;
using Ran.Analytics.Visitors;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Ran.Analytics.EntityFrameworkCore
{
    [DependsOn(
        typeof(AnalyticsDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class AnalyticsEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AnalyticsDbContext>(options =>
            {
                options.AddRepository<Visitors.Visitor, EfCoreVisitorRepository>();                 
            });
        }
    }
}