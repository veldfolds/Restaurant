using MauiApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Services
{
    internal static class MenuItemsService
    {
        public static List<RestaurantMenuItem> MenuItems => new()
        {
           new() 
           { 
               CommonName = "White Chicken",
               Name = "Spicy Chicken",
               Ratings = 4.8,
               Discount = 2.1,
               Kcal = 510,
               Proteins = "16,2",
               Carbohydrate = "13,9",
               Fibre = "8,6",
               Price = 18.99
           },
           new()
           {
               CommonName = "Original Italian",
               Name = "Buffalo mozzarella",
               Ratings = 3.9,
               Discount = 0,
               Kcal = 436,
               Proteins = "11.8",
               Carbohydrate = "21,3",
               Fibre = "6,4",
               Price = 12.58
           },new()
           {
               CommonName = "Meat Mexican",
               Name = "Ground Beef Tacos",
               Ratings = 4.2,
               Discount = 0,
               Kcal = 312,
               Proteins = "10,8",
               Carbohydrate = "18,9",
               Fibre = "7,2",
               Price = 10.99
           },
        };
    }
}
