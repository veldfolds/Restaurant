namespace MauiApp2.Models;

public class RestaurantMenuItem
{
    public string CommonName { get; set; }

    public string Name { get; set; }

    public string ImageUrl { get; set; }

    public double Ratings { get; set; }
    
    public int Kcal { get; set; }

    public string Proteins { get; set; }

    public string Carbohydrate { get; set; }

    public string Fibre { get; set; }

    public double Discount { get; set; }

    public double Price { get; set; }

    public int RequestCount { get; set; } = 0;

    public int ItemIndex { get; set; }

}
