using Microsoft.Maui.Controls;

namespace ToolbarTitleViewSample
{
    public class TitleViewGridPage : ContentPage
    {
        public TitleViewGridPage()
        {
            Title = "Grid TitleView";

            // TitleView with Grid (mirroring PDFViewerPage)
            var grid = new Grid
            {
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(3, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(4, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(3, GridUnitType.Star) }
                }
            };

            var leftBtn = new Button { 
                Text = "Left", 
                Command = new Command(async () => await DisplayAlert("TitleView", "Left Button Pressed", "OK")),
                BackgroundColor = Colors.Azure,
                CornerRadius = 20,
            };

            var centerLabel = new Label { 
                Text = "Grid TitleView", 
                HorizontalOptions = LayoutOptions.Center, 
                VerticalOptions = LayoutOptions.Center, 
                TextColor = Application.Current.Resources["SecondaryColor"] as Color ?? Colors.Black,
                FontAttributes = FontAttributes.Bold
            };

            var rightBtn = new ImageButton { 
                Source = "setting.png", 
                Command = new Command(async () => await DisplayAlert("TitleView", "Image Button Pressed", "OK")),
            };

            grid.Add(leftBtn, 0, 0);
            grid.Add(centerLabel, 1, 0);
            grid.Add(rightBtn, 2, 0);

            NavigationPage.SetTitleView(this, grid);
            //NavigationPage.SetHasBackButton(this, true);

            Content = new StackLayout
            {
                Children =
                {
                    new Label { Text = "This page uses a Grid in the TitleView.", TextColor = Colors.DarkRed, Margin = 20 },
                    new BoxView { Color = Colors.Red, HeightRequest = 2, Margin = new Thickness(20,0) },
                    new Label { Text = "Controls below are not relevant to the issue.", TextColor = Colors.DarkRed, Margin = 20 }
                }
            };
        }
    }
}
