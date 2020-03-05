using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinCusRendApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            List<MyModel> list = new List<MyModel>();
            list.Add(new MyModel { Placeholder = "MyEntry1", BorderColor = Color.Red, BorderWidth = 10 });
            list.Add(new MyModel { Placeholder = "MyEntry2", BorderColor = Color.Blue, BorderWidth = 15 });
            list.Add(new MyModel { Placeholder = "MyEntry3", BorderColor = Color.Green, BorderWidth = 20 });
            list.Add(new MyModel { Placeholder = "MyEntry4", BorderColor = Color.Yellow, BorderWidth = 21 });
            list.Add(new MyModel { Placeholder = "MyEntry5", BorderColor = Color.Orange, BorderWidth = 25 });

            BindingContext = list;
        }
    }
}
