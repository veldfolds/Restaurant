using MauiApp2.Models;
using System.Collections.ObjectModel;

namespace MauiApp2.Views.Templates;

public partial class CheckoutView : ContentView
{

    public static readonly BindableProperty TotalPriceProperty = BindableProperty.Create(nameof(TotalPrice), typeof(double), typeof(CheckoutView));

    public double TotalPrice
    {
        get => (double)GetValue(TotalPriceProperty);
        set => SetValue(TotalPriceProperty, value);
    }

    public ObservableCollection<RestaurantMenuItem> SourceItems { get; set; }


    public CheckoutView()
	{
		InitializeComponent();

        BindableLayout.SetItemsSource(remainingPlates, SourceItems);
	}
}