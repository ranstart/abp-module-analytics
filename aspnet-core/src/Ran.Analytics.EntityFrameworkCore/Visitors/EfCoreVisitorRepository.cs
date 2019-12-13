using Microsoft.EntityFrameworkCore;
using Ran.Analytics.EntityFrameworkCore;
using System;
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

    }
}
