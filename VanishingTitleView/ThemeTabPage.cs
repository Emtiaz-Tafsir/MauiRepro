using Microsoft.Maui.Controls;

namespace ToolbarTitleViewSample
{
    public class ThemeTabPage : ContentPage
    {
        public ThemeTabPage()
        {
            Title = "Theme";
            var button = new Button { Text = "Go to Theme Settings Page" };
            button.Clicked += async (s, e) =>
            {
                await Navigation.PushAsync(new ThemeSettingsPage());
            };
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    new Label { Text = "This is the Theme tab. Press the button to navigate.", HorizontalOptions = LayoutOptions.Center, TextColor = Colors.DarkGreen },
                    button
                }
            };
        }
    }
}
