using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Graphics.Drawables.Shapes;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinCusRendApp.CustomControls;
using XamarinCusRendApp.Droid.CustomRenderers;

[assembly: ExportRenderer(typeof(MyEntry), typeof(CustomEntryRenderer))]
namespace XamarinCusRendApp.Droid.CustomRenderers
{
    public class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control == null) return;

            MyEntry myEntry = (MyEntry)Element;

            var shape = new ShapeDrawable(new RectShape());
            //shape.Paint.Color = Android.Graphics.Color.Red;
            shape.Paint.Color = myEntry.BorderColor.ToAndroid();
            shape.Paint.SetStyle(Paint.Style.Stroke);
            //shape.Paint.StrokeWidth = 10;
            shape.Paint.StrokeWidth = myEntry.BorderWidth;

            Control.Background = shape;
        }
    }
}