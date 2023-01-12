namespace MauiApp2.Views.Templates;

public partial class MenuItemView : ContentView
{

    public static readonly BindableProperty MenuItemTitleProperty = BindableProperty.Create(nameof(MenuItemTitle), typeof(string), typeof(MenuItemView));

    public string MenuItemTitle
    {
        get => (string)GetValue(MenuItemTitleProperty);
        set => SetValue(MenuItemTitleProperty, value);
    }


    public static readonly BindableProperty MenuItemSubtitleProperty = BindableProperty.Create(nameof(MenuItemSubtitle), typeof(string), typeof(MenuItemView));

    public string MenuItemSubtitle
    {
        get => (string)GetValue(MenuItemSubtitleProperty);
        set => SetValue(MenuItemSubtitleProperty, value);
    }


    public static readonly BindableProperty MenuItemRatingProperty = BindableProperty.Create(nameof(MenuItemRating), typeof(double), typeof(MenuItemView));

    public double MenuItemRating
    {
        get => (double)GetValue(MenuItemRatingProperty);
        set => SetValue(MenuItemRatingProperty, value);
    }


    public static readonly BindableProperty MenuItemPriceProperty = BindableProperty.Create(nameof(MenuItemPrice), typeof(double), typeof(MenuItemView));

    public double MenuItemPrice
    {
        get => (double)GetValue(MenuItemPriceProperty);
        set => SetValue(MenuItemPriceProperty, value);
    }


    public static readonly BindableProperty MenuItemProteinContentProperty = BindableProperty.Create(nameof(MenuItemProteinContent), typeof(double), typeof(MenuItemView));

    public double MenuItemProteinContent
    {
        get => (double)GetValue(MenuItemProteinContentProperty);
        set => SetValue(MenuItemProteinContentProperty, value);
    }


    public static readonly BindableProperty MenuItemCarbohydratesContentProperty = BindableProperty.Create(nameof(MenuItemCarbohydratesContent), typeof(double), typeof(MenuItemView));

    public double MenuItemCarbohydratesContent
    {
        get => (double)GetValue(MenuItemCarbohydratesContentProperty);
        set => SetValue(MenuItemCarbohydratesContentProperty, value);
    }


    public static readonly BindableProperty MenuItemFibreContentProperty = BindableProperty.Create(nameof(MenuItemFibreContent), typeof(double), typeof(MenuItemView));

    public double MenuItemFibreContent
    {
        get => (double)GetValue(MenuItemFibreContentProperty);
        set => SetValue(MenuItemFibreContentProperty, value);
    }



    public static readonly BindableProperty MenuItemKcalProperty = BindableProperty.Create(nameof(MenuItemKcal), typeof(double), typeof(MenuItemView));

    public double MenuItemKcal
    {
        get => (double)GetValue(MenuItemKcalProperty);
        set => SetValue(MenuItemKcalProperty, value);
    }
    public static readonly BindableProperty OrderedItemCountProperty = BindableProperty.Create(nameof(OrderedItemCount), typeof(int), typeof(MenuItemView));

    public int OrderedItemCount
    {
        get => (int)GetValue(OrderedItemCountProperty);
        set => SetValue(OrderedItemCountProperty, value);
    }


    public static readonly BindableProperty DiscountProperty = BindableProperty.Create(nameof(Discount), typeof(double), typeof(MenuItemView));

    public double Discount
    {
        get => (double)GetValue(DiscountProperty);
        set => SetValue(DiscountProperty, value);
    }
    public MenuItemView()
	{
		InitializeComponent();
	}
}