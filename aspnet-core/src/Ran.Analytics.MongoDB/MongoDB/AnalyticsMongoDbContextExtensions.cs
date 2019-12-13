using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Ran.Analytics.MongoDB
{
    public static class AnalyticsMongoDbContextExtensions
    {
        public static void ConfigureAnalytics(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new AnalyticsMongoModelBuilderConfigurationOptions(
                AnalyticsDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}