namespace MauiTask2.Pages;

public partial class DemoContentPage1 : ContentPage
{
	public DemoContentPage1()
	{
		InitializeComponent();
	}

	private async void ContentPage2Button_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushModalAsync(new DemoContentPage2());
	}
}