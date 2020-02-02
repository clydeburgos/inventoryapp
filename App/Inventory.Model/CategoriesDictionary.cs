using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Inventory.Model
{
    public static class CategoriesDictionary
    {
        private static readonly Dictionary<int, string> categoryDictionary = new Dictionary<int, string>() {
            { 0, "None" },
            { 1, "Computer" },
            { 2, "Power Tools" },
            { 3, "Books" },
            { 4, "Food" },
            { 5, "Drinks & Beverages" },
            { 6, "Cleaning" },
            { 7, "Phone & Accessories" },
            { 8, "Beauty Products" },
            { 9, "Furniture" },
            { 10, "Appliances" },
        };
        public static string GetCategoryById(int id) {
            return categoryDictionary.Where(k => k.Key == id).SingleOrDefault().Value;
        }
    }
}
