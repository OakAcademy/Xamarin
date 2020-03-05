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
    public partial class GroupedListPage : ContentPage
    {
        List<Person> Persons;
        public GroupedListPage()
        {
            InitializeComponent();

            Persons = new List<Person>();
            Persons.Add(new Person { Name = "Tom", Age = 32, FavouriteColor = "Blue" });
            Persons.Add(new Person { Name = "Mary", Age = 25, FavouriteColor = "Purple" });
            Persons.Add(new Person { Name = "David", Age = 18, FavouriteColor = "Red" });
            Persons.Add(new Person { Name = "Paul", Age = 32, FavouriteColor = "Blue" });
            Persons.Add(new Person { Name = "Michael", Age = 25, FavouriteColor = "Purple" });
            Persons.Add(new Person { Name = "Abigail", Age = 18, FavouriteColor = "Red" });
            Persons.Add(new Person { Name = "Jack", Age = 32, FavouriteColor = "Blue" });
            Persons.Add(new Person { Name = "Tim", Age = 25, FavouriteColor = "Purple" });
            Persons.Add(new Person { Name = "Arthur", Age = 18, FavouriteColor = "Red" });

            listView.BindingContext = Persons.OrderBy(p => p.Name).GroupBy(p => p.Name[0]).ToList();

        }
    }
}