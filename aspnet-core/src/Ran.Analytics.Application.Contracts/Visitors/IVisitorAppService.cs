using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Ran.Analytics.Visitors
{
    public interface IVisitorAppService : IApplicationService
    {
        Task<bool> AddVisitorAsync(string providerName, Guid providerKey);
    }
}
