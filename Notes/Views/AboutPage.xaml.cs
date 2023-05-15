using Notes.Models;

namespace Notes.Views;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}
    /*
    private async void LearnMore_Clicked(object sender, EventArgs e)
    {
        // Navigate to the specified URL in the system browser.

        //await Launcher.Default.OpenAsync("https://aka.ms/maui");

        if (BindingContext is Models.About about)//检查绑定的内容是否为Models.About类型，是,则分配给about变量
        {
            await Launcher.Default.OpenAsync(about.MoreInfoUrl);
        }
    }*/
}