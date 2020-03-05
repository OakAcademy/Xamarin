using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinLayoutsApp.Views
{
    public class RelativePage2 : ContentPage
    {
        public RelativePage2()
        {
            RelativeLayout relativeLayout = new RelativeLayout();

            BoxView blueBox = new BoxView { Color = Color.Blue };
            relativeLayout.Children.Add(blueBox, Constraint.Constant(50), 
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Height / 2;
                }));

            BoxView purpleBox = new BoxView { Color = Color.Purple };
            relativeLayout.Children.Add(purpleBox, Constraint.Constant(150),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Height / 3;
                }),
                Constraint.RelativeToView(blueBox, (parent, sibling) =>
                {
                    return sibling.Width * 2;

                }),
                Constraint.Constant(200));

            Content = relativeLayout;
        }
    }
}