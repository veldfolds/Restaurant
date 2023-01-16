﻿using MauiApp2.Models;
using MauiApp2.Services;
using System.Collections.ObjectModel;


namespace MauiApp2.ViewModels;

class MenuPageViewModel 
{
	public ObservableCollection<RestaurantMenuItem> MenuItems { get; set; }

	public RestaurantMenuItem SelectedItem { get; set; }

	
	[Reactive] public double TotalAmount { get; set; }

	public MenuPageViewModel()
	{
		MenuItems = new(MenuItemsService.MenuItems);

	}
}