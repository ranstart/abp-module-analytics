using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Ran.Analytics.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Ran.Analytics.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits Ran.Analytics.Web.Pages.AnalyticsPage
     */
    public abstract class AnalyticsPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<AnalyticsResource> L { get; set; }
    }
}
