using Microsoft.Maui.Controls;

namespace ToolbarTitleViewSample
{
    public class TitleViewStackPage : ContentPage
    {
        public TitleViewStackPage()
        {
            Title = "Stack TitleView";

            // TitleView with StackLayout (standard practice alternative)

            var leftBtn = new Button
            {
                Text = "Left",
                Command = new Command(async () => await DisplayAlert("TitleView", "Left Button Pressed", "OK")),
                BackgroundColor = Colors.Azure,
                CornerRadius = 20,
            };

            var centerLabel = new Label
            {
                Text = "Stack TitleView",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.Center,
                TextColor = Application.Current.Resources["SecondaryColor"] as Color ?? Colors.Black,
                FontAttributes = FontAttributes.Bold
            };

            var rightBtn = new ImageButton
            {
                Source = "setting.png",
                Command = new Command(async () => await DisplayAlert("TitleView", "Image Button Pressed", "OK")),
            };

            var stack = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    leftBtn,
                    centerLabel,
                    rightBtn
                }
            };

            NavigationPage.SetTitleView(this, stack);

            Content = new StackLayout
            {
                Children =
                {
                    new Label { Text = "This page uses a StackLayout in the TitleView.", TextColor = Colors.DarkBlue, Margin = 20 },
                    new BoxView { Color = Colors.Blue, HeightRequest = 2, Margin = new Thickness(20,0) },
                    new Label { Text = "Controls below are not relevant to the issue.", TextColor = Colors.DarkBlue, Margin = 20 }
                }
            };
        }
    }
}
