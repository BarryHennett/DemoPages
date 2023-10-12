namespace MauiTask2.Pages;

public partial class DemoContentPage2 : ContentPage
{
	public DemoContentPage2()
	{
		InitializeComponent();
	}

    private async void ClosedButton_Clicked(object sender, EventArgs e)
    {
       await Navigation.PopModalAsync();
    }

    private async void ContentPage3Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new DemoContentPage3());
    }


}