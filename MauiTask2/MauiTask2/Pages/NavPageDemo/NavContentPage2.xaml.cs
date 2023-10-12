namespace MauiTask2.Pages.NavPageDemo;

public partial class NavContentPage2 : ContentPage
{
	public NavContentPage2()
	{
		InitializeComponent();
	}

    private async void NavContentPage3Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new NavContentPage3());
    }
    private async void ClosedButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}