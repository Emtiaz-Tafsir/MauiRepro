using Microsoft.Maui;
using Microsoft.Maui.Controls;
using System.Diagnostics;
using Application = Microsoft.Maui.Controls.Application;

namespace ToolbarTitleViewSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
            => new Window(new NavigationPage(new LandingPage() { Title = "Landing Page" }));
    }
}
