using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinLayoutsApp.Views
{
    public class AbsolutePage2 : ContentPage
    {
        public AbsolutePage2()
        {
            BoxView redBox = new BoxView { Color = Color.Red };
            AbsoluteLayout.SetLayoutFlags(redBox, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(redBox, new Rectangle(0.4, 0.3, 50, 50));

            BoxView greenBox = new BoxView { Color = Color.Green };
            AbsoluteLayout.SetLayoutFlags(greenBox, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(greenBox, new Rectangle(0.8, 0.6, 50, 50));

            AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            absoluteLayout.Children.Add(redBox);
            absoluteLayout.Children.Add(greenBox);

            Content = absoluteLayout;
        }
    }
}