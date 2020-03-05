using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinElementsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ElementsPage1 : ContentPage
    {
        public ElementsPage1()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.BackgroundColor = Color.Red;
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                entry.Text = string.Empty;
                return;
            }
            char letter = e.NewTextValue[0];
            var count =editor.Text.Count(x => x == letter);
            entry.Text = "Letter Count: "+count;
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            entry.IsEnabled = e.Value;
        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value) entry.FontAttributes = FontAttributes.Bold;
            else entry.FontAttributes = FontAttributes.None;
        }

        private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            editor.FontSize = e.NewValue;
        }
    }
}