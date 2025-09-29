using Foundation;
using Microsoft.Extensions.Logging;
using UIKit;

namespace ToolbarTitleViewSample
{
    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            var baseResult = base.FinishedLaunching(app, options);
            return baseResult;
        }
    }
}
