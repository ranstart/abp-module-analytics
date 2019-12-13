using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Ran.Analytics.EntityFrameworkCore
{
    public class AnalyticsModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public AnalyticsModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}