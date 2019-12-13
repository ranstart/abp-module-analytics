using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace Ran.Analytics.MongoDB
{
    public class AnalyticsMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public AnalyticsMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}