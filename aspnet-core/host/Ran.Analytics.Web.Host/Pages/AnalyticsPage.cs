using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Ran.Analytics.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Ran.Analytics.Pages
{
    public abstract class AnalyticsPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<AnalyticsResource> L { get; set; }
    }
}
