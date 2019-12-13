using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Ran.Analytics.Visitors
{
    public interface IVisitorRepository : IBasicRepository<Visitor, Guid>
    {
        Task<bool> AnyAsync(string ip, Guid? userId, string providerName, Guid providerKey, DateTime onTime);

    }
}