using Android.Views;
using App3;
using App3.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using View = Android.Views.View;

[assembly: ExportRenderer(typeof(CustomLabel), typeof(CustomLabelRenderer))]
namespace App3.Droid
{
    public class CustomLabelRenderer : LabelRenderer
    {
        public override void OnViewAdded(View child)
        {
            Element.TextColor = Color.Red;
            base.OnViewAdded(child);
        }

        protected override void OnVisibilityChanged(View changedView, ViewStates visibility)
        {
            base.OnVisibilityChanged(changedView, visibility);
        }
    }
}