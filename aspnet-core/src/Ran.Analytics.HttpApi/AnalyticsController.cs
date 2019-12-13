using Ran.Analytics.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Ran.Analytics
{
    public abstract class AnalyticsController : AbpController
    {
        protected AnalyticsController()
        {
            LocalizationResource = typeof(AnalyticsResource);
        }
    }
}
