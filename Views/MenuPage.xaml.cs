using MauiApp2.ViewModels;

namespace MauiApp2.Views;

public partial class MenuPage : ContentPage
{
	public MenuPage()
	{
		BindingContext = new MenuPageViewModel();

		InitializeComponent();

	}
}