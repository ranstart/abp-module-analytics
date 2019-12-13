using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Ran.Analytics.EntityFrameworkCore
{
    [ConnectionStringName(AnalyticsDbProperties.ConnectionStringName)]
    public interface IAnalyticsDbContext : IEfCoreDbContext
    {
        DbSet<Visitors.Visitor> Visitors { get; }
         
    }
}