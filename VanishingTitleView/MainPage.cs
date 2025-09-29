using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace ToolbarTitleViewSample
{
    public class MainPage : TabbedPage
    {
        public MainPage()
        {
            Title = "Toolbar/TitleView Sample";

            // ToolbarItems: Text and Image
            ToolbarItems.Add(new ToolbarItem("TextBtn", null, async () => await Application.Current.MainPage.DisplayAlert("Toolbar", "Text Button Pressed", "OK")));
            ToolbarItems.Add(new ToolbarItem
            {
                IconImageSource = "setting.png",
                Command = new Command(async () => await Application.Current.MainPage.DisplayAlert("Toolbar", "Image Button Pressed", "OK")),
                Text = "ImgBtn"
            });

            // Add intermediary tab pages (ContentPages)
            Children.Add(new GridTabPage() { Title = "GridTitleView" });
            Children.Add(new StackTabPage() { Title = "StackTitleView" });
            Children.Add(new ThemeTabPage() { Title = "Theme" });
        }
    }
}
