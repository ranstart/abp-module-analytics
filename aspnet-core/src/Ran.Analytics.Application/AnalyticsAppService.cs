using Ran.Analytics.Localization;
using Volo.Abp.Application.Services;

namespace Ran.Analytics
{
    public abstract class AnalyticsAppService : ApplicationService
    {
        protected AnalyticsAppService()
        {
            LocalizationResource = typeof(AnalyticsResource);
        }
    }
}
