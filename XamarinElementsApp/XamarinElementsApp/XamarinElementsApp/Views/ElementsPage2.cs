using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinElementsApp.Views
{
    public class ElementsPage2 : ContentPage
    {
        public ElementsPage2()
        {
            Button button = new Button { Text="Paint to Blue", BackgroundColor=Color.Green, FontSize=20 };
            button.Clicked += (s, e) => 
            {
                this.BackgroundColor = Color.Blue;
            };

            Label label = new Label { Text="Welcome to OAK Academy", TextColor=Color.Navy,
                FontSize =Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };

            Entry entry = new Entry { Placeholder = "Password", IsPassword = true, TextColor = Color.Red };

            Editor editor = new Editor { Placeholder="About", BackgroundColor=Color.Black, TextColor=Color.White,
            FontFamily="Calibri", FontAttributes=FontAttributes.Bold, HeightRequest=150};

            Slider slider = new Slider { Maximum = 48, Minimum = 12, Value=24, MinimumTrackColor=Color.Fuchsia };
            slider.ValueChanged += (s, e) => 
            {
                entry.FontSize = e.NewValue;
            };

            ProgressBar progressBar = new ProgressBar { ProgressColor = Color.DarkBlue };
            Stepper stepper = new Stepper {Maximum=10, Minimum=0 };
            stepper.ValueChanged += (s, e) =>
              {
                  progressBar.ProgressTo(e.NewValue / 10, 1000, Easing.SpringIn);
              };

            Content = new StackLayout
            {
                Children =
                {
                    button, label, entry, editor, slider, progressBar, stepper
                }
            };
        }
    }
}