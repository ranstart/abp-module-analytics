using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using Ran.Analytics.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Localization.Resources.AbpValidation;
using Volo.Abp.VirtualFileSystem;

namespace Ran.Analytics
{
    [DependsOn(
        typeof(AbpLocalizationModule)
    )]
    public class AnalyticsDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<AnalyticsDomainSharedModule>("Ran.Analytics");
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<AnalyticsResource>("en")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Localization/Analytics");
            });

            Configure<AbpExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("Analytics", typeof(AnalyticsResource));
            });
        }
    }
}
