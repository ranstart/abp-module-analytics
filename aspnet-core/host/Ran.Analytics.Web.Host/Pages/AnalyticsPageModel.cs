using Ran.Analytics.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Ran.Analytics.Pages
{
    public abstract class AnalyticsPageModel : AbpPageModel
    {
        protected AnalyticsPageModel()
        {
            LocalizationResourceType = typeof(AnalyticsResource);
        }
    }
}