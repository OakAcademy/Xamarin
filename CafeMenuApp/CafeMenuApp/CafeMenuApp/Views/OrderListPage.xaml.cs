using CafeMenuApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CafeMenuApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderListPage : ContentPage
    {
        public OrderListPage(List<Food> foods)
        {
            InitializeComponent();

            //lstViewOrder.BindingContext = foods;
            lstViewOrder.BindingContext = new ObservableCollection<Food>(foods);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Successful", "Your order has been placed.", "Ok");
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            Food food = (Food)(sender as MenuItem).CommandParameter;
            (lstViewOrder.ItemsSource as ObservableCollection<Food>).Remove(food);
        }
    }
}