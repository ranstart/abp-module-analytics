using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Ran.Analytics.Visitors;
using Volo.Abp;

namespace Ran.Analytics.Visitors
{
    [RemoteService]
    [Area("analytics")]
    [ControllerName("Analytics")]
    [Route("api/analytics/visitors")]
    public class VisitorController : AnalyticsController, IVisitorAppService
    {
        private readonly IVisitorAppService _visitorAppService;

        public VisitorController(IVisitorAppService sampleAppService)
        {
            _visitorAppService = sampleAppService;
        }

        [HttpPost]
        public async Task<bool> AddVisitorAsync(string providerName, Guid providerKey)
        {
            return await _visitorAppService.AddVisitorAsync(providerName, providerKey);
        }
    }
}
