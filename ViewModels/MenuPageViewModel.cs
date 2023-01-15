using MauiApp2.Models;
using System.Collections.ObjectModel;

namespace MauiApp2.ViewModels;

class MenuPageViewModel
{
    public ObservableCollection<RestaurantMenuItem> MenuItems { get; set; }

	public double TotalAmount { get; set; }

	public MenuPageViewModel()
	{

	}
}
