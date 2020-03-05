using CafeMenuApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CafeMenuApp.Data
{
    public class MenuFactory
    {
        public static List<Food> MenuList { get; }
        public static List<Group<string, Food>> MenuListGrouped { get; set; }

        static MenuFactory()
        {
            MenuList = new List<Food>
            {
                new Food{Name="Pizza", GroupTitle=Food.GroupName.Eatables},
                new Food{Name="Hamburger", GroupTitle=Food.GroupName.Eatables},
                new Food{Name="Sandwich", GroupTitle=Food.GroupName.Eatables},
                new Food{Name="Pancake", GroupTitle=Food.GroupName.Eatables},
                new Food{Name="Pasta", GroupTitle=Food.GroupName.Eatables},
                new Food{Name="Salad", GroupTitle=Food.GroupName.Eatables},

                new Food{Name="Coke", GroupTitle=Food.GroupName.ColdDrinks},
                new Food{Name="Milkshake", GroupTitle=Food.GroupName.ColdDrinks},
                new Food{Name="Frappe", GroupTitle=Food.GroupName.ColdDrinks},
                new Food{Name="Iced Tea", GroupTitle=Food.GroupName.ColdDrinks},

                new Food{Name="Tea", GroupTitle=Food.GroupName.HotDrinks},
                new Food{Name="Coffee", GroupTitle=Food.GroupName.HotDrinks},
                new Food{Name="Latte", GroupTitle=Food.GroupName.HotDrinks},
                new Food{Name="Hot Chocolate", GroupTitle=Food.GroupName.HotDrinks},

                new Food{Name="Cheesecake", GroupTitle=Food.GroupName.Desserts},
                new Food{Name="Ice Cream", GroupTitle=Food.GroupName.Desserts},
                new Food{Name="Cookie", GroupTitle=Food.GroupName.Desserts},
                new Food{Name="Pie", GroupTitle=Food.GroupName.Desserts},
                new Food{Name="Tiramisu", GroupTitle=Food.GroupName.Desserts},
            };

            MenuListGrouped = MenuList.GroupBy(f => f.GroupTitle.ToString()).Select(g => new Group<string, Food>(g.Key, g)).ToList();
        }
    }
}
