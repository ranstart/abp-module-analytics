using Microsoft.EntityFrameworkCore;
using Ran.Analytics.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Ran.Analytics.Visitors
{
    public class EfCoreVisitorRepository : EfCoreRepository<IAnalyticsDbContext, Visitor, Guid>, IVisitorRepository
    {
        public EfCoreVisitorRepository(
            IDbContextProvider<IAnalyticsDbContext> dbContextProvider
            )
            : base(dbContextProvider)
        {
        }

        public async Task<bool> AnyAsync(string clientIpAddress, Guid? userId, string providerName, Guid providerKey, DateTime onTime)
        {
            var minTime = onTime.AddHours(-24);

            return await DbSet.AnyAsync(m => 
                m.ClientIpAddress == clientIpAddress && m.UserId == userId && m.ProviderName == providerName && m.ProviderKey == providerKey && m.OnTime>minTime && m.OnTime<onTime
            );
        }


        public async Task<List<VisitorCount>> GetRanking(string providerName, Guid[] providerKeys, DateTime start, DateTime end)
        {
            return await DbSet.Where(m => m.ProviderName == providerName && m.OnTime > start && m.OnTime < end)
                .WhereIf(providerKeys!=null && providerKeys.Any(), m=> providerKeys.Contains(m.ProviderKey))
                .GroupBy(m => new { m.ProviderName, m.ProviderKey })
                .Select(m => new VisitorCount
                {
                    ProviderKey = m.Key.ProviderKey,
                    Count = m.Count()
                }).ToListAsync();
        }
    }
}
