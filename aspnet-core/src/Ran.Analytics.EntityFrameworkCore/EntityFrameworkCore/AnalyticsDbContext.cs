using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Ran.Analytics.EntityFrameworkCore
{
    [ConnectionStringName(AnalyticsDbProperties.ConnectionStringName)]
    public class AnalyticsDbContext : AbpDbContext<AnalyticsDbContext>, IAnalyticsDbContext
    {
        public DbSet<Visitors.Visitor> Visitors { get; set; }

        public AnalyticsDbContext(DbContextOptions<AnalyticsDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureAnalytics();
        }
    }
}