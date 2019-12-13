using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Ran.Analytics
{
    [DependsOn(
        typeof(AnalyticsHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class AnalyticsConsoleApiClientModule : AbpModule
    {
        
    }
}
