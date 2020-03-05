using CafeMenuApp.Data;
using CafeMenuApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CafeMenuApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuListPage : ContentPage
    {
        public MenuListPage()
        {
            InitializeComponent();

            //lstViewMenu.BindingContext = MenuFactory.MenuList;
            lstViewMenu.BindingContext = MenuFactory.MenuListGrouped;
        }

        private void lstViewMenu_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new DetailPage((Food)e.Item));
            lstViewMenu.SelectedItem = null;
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            List<Food> foods = MenuFactory.MenuListGrouped.SelectMany(g => g).Where(f => f.Checked).ToList();
            if (foods.Count == 0) DisplayAlert("", "You didn't select anything.", "Ok");
            else
            {
                Navigation.PushAsync(new OrderListPage(foods));
            }
        }

        private void lstViewMenu_Refreshing(object sender, EventArgs e)
        {
            List<Food> foods = MenuFactory.MenuListGrouped.SelectMany(g => g).Where(f => f.Checked).ToList();
            foreach (var food in foods)
            {
                food.Checked = false;
            }
            lstViewMenu.EndRefresh();
        }
    }
}