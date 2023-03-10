using MauiApp2.Models;
using MauiApp2.Services;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System.Collections.ObjectModel;


namespace MauiApp2.ViewModels;

class MenuPageViewModel : ReactiveObject
{
	public ObservableCollection<RestaurantMenuItem> MenuItems { get; set; }

	public ObservableCollection<string> CourseMenuImages { get; set; } 
		

	[Reactive] public RestaurantMenuItem SelectedItem { get; set; }

	[Reactive] public double TotalAmount { get; set; }


	public MenuPageViewModel()
	{
		CourseMenuImages = new ObservableCollection<string>()
        {
            "iconpngpizza.png",
            "iconpngfish.png",
            "iconpngsoup.png",
            "iconpngsteak.png",
            "iconpngsushi.png",
			"iconpngicecream.png"
        };

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
