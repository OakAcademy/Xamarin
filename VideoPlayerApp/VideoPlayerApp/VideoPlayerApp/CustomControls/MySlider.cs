using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace VideoPlayerApp.CustomControls
{
    public class MySlider : Slider
    {
        public static readonly BindableProperty PositionProperty =
            BindableProperty.Create(nameof(Position), typeof(TimeSpan), typeof(MySlider), defaultBindingMode: BindingMode.TwoWay,
                propertyChanged: (bindable, oldValue, newValue) =>
                {
                    (bindable as MySlider).Value = ((TimeSpan)newValue).TotalSeconds;
                });
        public TimeSpan Position
        {
            get => (TimeSpan)GetValue(PositionProperty);
            set => SetValue(PositionProperty, value);
        }


        public static readonly BindableProperty DurationProperty =
           BindableProperty.Create(nameof(Duration), typeof(TimeSpan), typeof(MySlider),
                 propertyChanged: (bindable, oldValue, newValue) =>
                 {
                     (bindable as MySlider).Maximum = ((TimeSpan)newValue).TotalSeconds;
                 });
        public TimeSpan Duration
        {
            get => (TimeSpan)GetValue(DurationProperty);
            set => SetValue(DurationProperty, value);
        }

        public MySlider()
        {
            ValueChanged += MySlider_ValueChanged;
        }

        private void MySlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            TimeSpan newPosition = TimeSpan.FromSeconds(e.NewValue);

            if (Math.Abs(newPosition.TotalSeconds - Position.TotalSeconds) > 1.0)
            {
                Position = newPosition;
            }
        }
    }
}
