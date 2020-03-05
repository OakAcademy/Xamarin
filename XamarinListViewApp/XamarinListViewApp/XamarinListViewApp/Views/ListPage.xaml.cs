using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinListViewApp.Models;

namespace XamarinListViewApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        List<Person> Persons;
        public ListPage()
        {
            InitializeComponent();

            Persons = new List<Person>();
            Persons.Add(new Person { Name = "Tom", Age = 32, FavouriteColor = "Blue" });
            Persons.Add(new Person { Name = "Mary", Age = 25, FavouriteColor = "Purple" });
            Persons.Add(new Person { Name = "David", Age = 18, FavouriteColor = "Red" });

            //listView.ItemsSource = Persons;
            //listView.Footer = Persons;

            listView.BindingContext = Persons;
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (listView.SelectedItem == null) return;

            var person = (Person)listView.SelectedItem;
            DisplayAlert("Selected Person", $"{person.Name}'s favourite color is {person.FavouriteColor}", "Ok");
            listView.SelectedItem = null;
        }

        private void listView_Refreshing(object sender, EventArgs e)
        {
            DisplayAlert("ListView", "Refreshing", "Ok");
            listView.EndRefresh();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            listView.BindingContext = Persons.Where(p => p.Name.ToLower().Contains(e.NewTextValue.ToLower())).ToList();
        }
    }
}