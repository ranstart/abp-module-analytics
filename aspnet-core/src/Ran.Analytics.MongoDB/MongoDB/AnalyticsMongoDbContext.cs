using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Ran.Analytics.MongoDB
{
    [ConnectionStringName(AnalyticsDbProperties.ConnectionStringName)]
    public class AnalyticsMongoDbContext : AbpMongoDbContext, IAnalyticsMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureAnalytics();
        }
    }
}