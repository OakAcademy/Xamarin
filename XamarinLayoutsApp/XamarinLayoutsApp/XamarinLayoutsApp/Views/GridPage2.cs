using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinLayoutsApp.Views
{
    public class GridPage2 : ContentPage
    {
        public GridPage2()
        {
            Grid grid = new Grid { ColumnSpacing=10, RowSpacing=3 };
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(50) });

            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Auto) });

            grid.Children.Add(new BoxView { Color = Color.Red }, 0, 0);
            grid.Children.Add(new BoxView { Color = Color.Blue }, 1, 0);

            grid.Children.Add(new BoxView { Color = Color.Yellow }, 0, 1);
            grid.Children.Add(new BoxView { Color = Color.Blue }, 1, 1);

            grid.Children.Add(new BoxView { Color = Color.Green }, 0, 2);
            grid.Children.Add(new BoxView { Color = Color.Maroon }, 1, 2);

            Content = grid;
        }
    }
}