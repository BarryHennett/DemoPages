namespace MauiTask2.Pages.NavPageDemo;

public partial class NavContentPage3 : ContentPage
{
	public NavContentPage3()
	{
		InitializeComponent();
	}

    private async void ClosedButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}