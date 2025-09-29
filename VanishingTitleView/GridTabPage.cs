using Microsoft.Maui.Controls;

namespace ToolbarTitleViewSample
{
    public class GridTabPage : ContentPage
    {
        public GridTabPage()
        {
            Title = "GridTitleView";
            var button = new Button { Text = "Go to Grid TitleView Page" };
            button.Clicked += async (s, e) =>
            {
                await Navigation.PushAsync(new TitleViewGridPage());
            };
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    new Label { Text = "This is the Grid tab. Press the button to navigate.", HorizontalOptions = LayoutOptions.Center, TextColor = Colors.DarkRed },
                    button
                }
            };
        }
    }
}
