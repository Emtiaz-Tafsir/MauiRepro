using Microsoft.Maui.Controls;

namespace ToolbarTitleViewSample
{
    public class LandingPage : ContentPage
    {
        public LandingPage()
        {
            var button = new Button { Text = "Go to Grid TitleView Page" };
            button.Clicked += async (s, e) =>
            {
                await Navigation.PushAsync(new TitleViewGridPage());
            };
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Margin = 20,
                Children =
                {
                    new Label { Text = "Press the button to navigate.", HorizontalOptions = LayoutOptions.Center, TextColor = Colors.DarkRed },
                    button
                }
            };
        }
    }
}
