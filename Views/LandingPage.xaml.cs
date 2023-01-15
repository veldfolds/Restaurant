namespace MauiApp2.Views;

public partial class LandingPage : ContentPage
{
	public LandingPage()
	{
		InitializeComponent();
	}

    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);

        
    }

    /// <summary>
    /// Navigate to the menu page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void NextButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(MenuPage));
    }
}