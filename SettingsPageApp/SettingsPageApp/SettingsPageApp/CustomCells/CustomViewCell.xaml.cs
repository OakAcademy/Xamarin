using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SettingsPageApp.CustomCells
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomViewCell : ViewCell
    {
        public string Text { get=>lblText.Text; set=>lblText.Text=value; }
        public string Detail { get=>lblDetail.Text; set=>lblDetail.Text=value; }


        public CustomViewCell()
        {
            InitializeComponent();
        }
    }
}