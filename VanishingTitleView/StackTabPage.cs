using Microsoft.Maui.Controls;

namespace ToolbarTitleViewSample
{
    public class StackTabPage : ContentPage
    {
        public StackTabPage()
        {
            Title = "StackTitleView";
            var button = new Button { Text = "Go to Stack TitleView Page" };
            button.Clicked += async (s, e) =>
            {
                await Navigation.PushAsync(new TitleViewStackPage());
            };
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    new Label { Text = "This is the Stack tab. Press the button to navigate.", HorizontalOptions = LayoutOptions.Center, TextColor = Colors.DarkBlue },
                    button
                }
            };
        }
    }
}
