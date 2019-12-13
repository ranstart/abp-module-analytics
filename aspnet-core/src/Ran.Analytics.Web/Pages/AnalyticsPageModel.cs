using Ran.Analytics.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Ran.Analytics.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class AnalyticsPageModel : AbpPageModel
    {
        protected AnalyticsPageModel()
        {
            LocalizationResourceType = typeof(AnalyticsResource);
        }
    }
}