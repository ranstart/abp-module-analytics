using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace Ran.Analytics
{
    [Dependency(ReplaceServices = true)]
    public class AnalyticsBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Analytics";
    }
}
