using Localization.Resources.AbpUi;
using Ran.Analytics.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Ran.Analytics
{
    [DependsOn(
        typeof(AnalyticsApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class AnalyticsHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(AnalyticsHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<AnalyticsResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
