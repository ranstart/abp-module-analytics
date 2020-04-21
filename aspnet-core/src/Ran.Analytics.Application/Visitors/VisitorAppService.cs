using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ran.Analytics.Visitors
{
    public class VisitorAppService : AnalyticsAppService, IVisitorAppService
    {
        private readonly IVisitorRepository _visitorRepository;

        public VisitorAppService(IVisitorRepository visitorRepository)
        {
            _visitorRepository = visitorRepository;
        }

        public async Task<bool> AddVisitorAsync(string providerName, Guid providerKey)
        {
            var httpContext = this.ServiceProvider.GetRequiredService<IHttpContextAccessor>().HttpContext;
            if (httpContext == null)
            {
                return false;
            }

            var clientIp = GetClientIpAddress(httpContext);
            var referer = GetReferer(httpContext);
            var onTime = DateTime.Now;
            if (!await _visitorRepository.AnyAsync(clientIp, CurrentUser.Id, providerName, providerKey, onTime))
            {
                var visitor = new Visitor(GuidGenerator.Create(), clientIp, CurrentUser.Id, onTime, referer, providerName, providerKey,CurrentTenant.Id);

                await _visitorRepository.InsertAsync(visitor);
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<List<VisitorCount>> GetRanking(string providerName, Guid[] providerKeys, DateTime start, DateTime end)
        {
            return await _visitorRepository.GetRanking(providerName, providerKeys, start, end);
        }

        protected virtual string GetClientIpAddress(HttpContext httpContext)
        {
            try
            {
                return httpContext.Connection?.RemoteIpAddress?.ToString();
            }
            catch (Exception ex)
            {
                Logger.LogException(ex, LogLevel.Warning);
                return null;
            }
        }

        protected virtual string GetReferer(HttpContext httpContext)
        {
            try
            {
                return httpContext.Request.Headers["Referer"].ToString();
            }
            catch (Exception ex)
            {
                Logger.LogException(ex, LogLevel.Warning);
                return null;
            }
        }
    }
}