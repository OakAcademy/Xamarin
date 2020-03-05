using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinCusRendApp.CustomControls
{
    public class MyEntry : Entry
    {
        public static readonly BindableProperty BorderColorProperty = BindableProperty.Create("BorderColor", typeof(Color),
            typeof(MyEntry));

        public Color BorderColor
        {
            get => (Color)GetValue(BorderColorProperty);
            set => SetValue(BorderColorProperty, value);
        }


        public static readonly BindableProperty BorderWidthProperty = BindableProperty.Create(nameof(BorderWidth), typeof(int),
            typeof(MyEntry));

        public int BorderWidth
        {
            get => (int)GetValue(BorderWidthProperty);
            set => SetValue(BorderWidthProperty, value);
        }


        //public Color BorderColor { get; set; }
        //public int BorderWidth { get; set; }
    }
}
