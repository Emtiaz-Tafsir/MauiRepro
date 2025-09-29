using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace ToolbarTitleViewSample
{
    public class ThemeSettingsPage : ContentPage
    {
        public ThemeSettingsPage()
        {
            Title = "Theme Settings";
            
            var curPrimaryColor = Application.Current.Resources["PrimaryColor"] as Color ?? Colors.Blue;
            var curSecondaryColor = Application.Current.Resources["SecondaryColor"] as Color ?? Colors.Green;

            var primaryColorPicker = new Entry { Placeholder = "Enter Hex Color (e.g. #FF6200EE)" };
            var secondaryColorPicker = new Entry { Placeholder = "Enter Hex Color (e.g. #FF03DAC5)" };
            var applyButton = new Button { Text = "Apply Theme Color" };
            applyButton.Clicked += (s, e) =>
            {
                if (Color.TryParse(primaryColorPicker.Text, out var color))
                {
                    Application.Current.Resources["PrimaryColor"] = color;
                }
                if (Color.TryParse(secondaryColorPicker.Text, out color))
                {
                    Application.Current.Resources["SecondaryColor"] = color;
                }
            };
            Content = new StackLayout
            {
                Padding = 20,
                Children =
                {
                    new Label { Text = "Change the primary theme color:", TextColor = curPrimaryColor },
                    primaryColorPicker,
                    new Label { Text = "Change the secondary theme color:", TextColor = curSecondaryColor },
                    secondaryColorPicker,
                    applyButton
                }
            };
        }
    }
}
