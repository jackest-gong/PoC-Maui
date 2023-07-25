namespace maui;

public partial class NewScreen : ContentPage
{
	public NewScreen()
	{
		InitializeComponent();
	}
    private async void OnButtonClick(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}
