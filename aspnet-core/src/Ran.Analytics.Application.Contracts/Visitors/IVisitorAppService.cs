using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Ran.Analytics.Visitors
{
    public interface IVisitorAppService : IApplicationService
    {
        Task<bool> AddVisitorAsync(string providerName, Guid providerKey);


        /// <summary>
        /// 排行榜
        /// </summary>
        /// <param name="providerName"></param>
        /// <param name="providerKeys">可不传值</param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        Task<List<VisitorCount>> GetRanking(string providerName, Guid[] providerKeys, DateTime start, DateTime end);
    }
}
