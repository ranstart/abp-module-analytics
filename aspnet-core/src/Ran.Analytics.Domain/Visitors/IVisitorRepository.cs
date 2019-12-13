using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Ran.Analytics.Visitors
{
    public interface IVisitorRepository : IBasicRepository<Visitor, Guid>
    {
        Task<bool> AnyAsync(string ip, Guid? userId, string providerName, Guid providerKey, DateTime onTime);

        /// <summary>
        /// 获取排行榜
        /// </summary>
        /// <param name="providerName"></param>
        /// <param name="providerKeys"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        Task<List<VisitorCount>> GetRanking(string providerName, Guid[] providerKeys, DateTime start, DateTime end);
    }
}