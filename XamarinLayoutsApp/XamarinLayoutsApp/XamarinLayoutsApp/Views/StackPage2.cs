using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinLayoutsApp.Views
{
    public class StackPage2 : ContentPage
    {
        public StackPage2()
        {
            StackLayout stackHeader = new StackLayout
            {
                Children =
                {
                    new Label{ Text="Label 1", TextColor=Color.White, FontSize=Device.GetNamedSize(NamedSize.Large, typeof(Label)) },
                    new Label{ Text="Label 2", TextColor=Color.White, FontSize=Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                    HorizontalOptions=LayoutOptions.EndAndExpand},
                },
                BackgroundColor=Color.Red,
                Padding=10,
                Orientation=StackOrientation.Horizontal,
            };

            StackLayout stackCenter = new StackLayout
            {
                BackgroundColor = Color.Blue,
                VerticalOptions=LayoutOptions.FillAndExpand,
            };

            StackLayout stackFooter = new StackLayout
            {
                BackgroundColor = Color.Green,
                Padding = new Thickness(10, 20),      
                Orientation=StackOrientation.Horizontal
            };

            stackFooter.Children.Add(new Button { Text="Button 1" });
            stackFooter.Children.Add(new Button { Text = "Button 2" });


            Content = new StackLayout
            {
                Children =
                {
                    stackHeader, stackCenter, stackFooter
                },
                Padding = new Thickness(20),
                Spacing= 10,
            };
        }
    }
}