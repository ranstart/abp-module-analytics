using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace Ran.Analytics
{
    [DependsOn(
        typeof(AnalyticsApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class AnalyticsHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "Analytics";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(AnalyticsApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
