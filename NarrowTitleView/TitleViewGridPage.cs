using Microsoft.Maui.Controls;

namespace ToolbarTitleViewSample
{
    public class TitleViewGridPage : ContentPage
    {
        private Label wndWidthLbl = null;
        private Label titleViewWidthLbl = null;
        private Entry titleViewWidthEntry = null;

        public TitleViewGridPage()
        {
            Title = "Grid TitleView";

            Grid titleView = new Grid
            {
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(3, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(4, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(3, GridUnitType.Star) }
                }
            };

            var leftBtn = new Button 
            { 
                Text = "Left", 
                Command = new Command(async () => await DisplayAlert("TitleView", "Left Button Pressed", "OK")),
                BackgroundColor = Colors.Purple,
                CornerRadius = 20,
            };

            var centerLabel = new Label { 
                Text = "Grid TitleView", 
                HorizontalOptions = LayoutOptions.CenterAndExpand, 
                VerticalOptions = LayoutOptions.Center, 
                TextColor = Application.Current.Resources["Primary"] as Color ?? Colors.Black,
                FontAttributes = FontAttributes.Bold
            };

            var rightBtn = new ImageButton { 
                Source = "setting.png", 
                Command = new Command(async () => await DisplayAlert("TitleView", "Image Button Pressed", "OK")),
            };

            titleView.Add(leftBtn, 0, 0);
            titleView.Add(centerLabel, 1, 0);
            titleView.Add(rightBtn, 2, 0);

            NavigationPage.SetTitleView(this, titleView);
            //NavigationPage.SetHasBackButton(this, true);

            wndWidthLbl = new Label { Text = $"Window Width: {Application.Current.Windows[0].Width}" };
            titleViewWidthLbl = new Label { Text = $"TitleView Width: {titleView.Width}" };
            titleViewWidthEntry = new Entry { Keyboard = Keyboard.Numeric };

            Content = new StackLayout
            {
                Margin = 20,
                Children =
                {
                    new Label { Text = "This page uses a Grid in the TitleView.", TextColor = Colors.DarkRed },
                    new Label { Text = "Try rotating the device or changing the window size to see how the TitleView layout adapts.", TextColor = Colors.Black },
                    new BoxView { Color = Colors.Red, HeightRequest = 2, Margin = new Thickness(20,0,20,50) },
                    new Label { Text = "Use the controls below to try set the size manually.", TextColor = Colors.DarkBlue, FontSize = 20 },
                    wndWidthLbl,
                    titleViewWidthLbl,
                    new StackLayout
                    {
                        Margin = 20,
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            new Label { Text = "New TitleView Width: ", VerticalOptions = LayoutOptions.Center },
                            titleViewWidthEntry,
                            new Button
                            {
                                Text = "Set Width",
                                Command = new Command(SetTitleViewWidth)
                            }
                        }
                    }
                }
            };

            titleView.SizeChanged += TitleView_SizeChanged;
            SizeChanged += Page_SizeChanged;
        }

        private void Page_SizeChanged(object sender, EventArgs e)
        {
            wndWidthLbl.Text = $"Window Width: {Application.Current.Windows[0].Width}";
        }

        private void TitleView_SizeChanged(object sender, EventArgs e)
        {
            var titleView = NavigationPage.GetTitleView(this);
            titleViewWidthLbl.Text = $"TitleView Width: {titleView.Width}";
        }

        private void SetTitleViewWidth(object obj)
        {
            var titleView = NavigationPage.GetTitleView(this);

            if (double.TryParse(titleViewWidthEntry.Text, out double newWidth))
            {
                titleView.Measure(newWidth, 44);
                titleView.Arrange(new Rect(titleView.X, titleView.Y, newWidth, 44));
            }
            else
            {
                DisplayAlert("Invalid Input", "Please enter a valid number for the width.", "OK");
            }
        }
    }
}
