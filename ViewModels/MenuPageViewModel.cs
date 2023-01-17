using MauiApp2.Models;
using MauiApp2.Services;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System.Collections.ObjectModel;


namespace MauiApp2.ViewModels;

class MenuPageViewModel : ReactiveObject
{
	public ObservableCollection<RestaurantMenuItem> MenuItems { get; set; }

	[Reactive] public RestaurantMenuItem SelectedItem { get; set; }

	[Reactive] public double TotalAmount { get; set; }

	public MenuPageViewModel()
	{
		MenuItems = new();

	    MenuItemsService.MenuItems
			            .Select(x =>
						{
							x.ItemIndex = MenuItemsService.MenuItems.IndexOf(x);
							return x;
						})
						.ToList()
						.ForEach(x => MenuItems.Add(x));
	}
}
