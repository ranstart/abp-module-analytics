using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Ran.Analytics.MongoDB
{
    [ConnectionStringName(AnalyticsDbProperties.ConnectionStringName)]
    public interface IAnalyticsMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
