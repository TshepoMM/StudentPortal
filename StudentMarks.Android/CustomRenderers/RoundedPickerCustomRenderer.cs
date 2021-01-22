using Android.Content;
using StudentMarks.CustomControls;
using StudentMarks.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(RoundedPicker), typeof(RoundedPickerCustomRenderer))]
namespace StudentMarks.Droid.CustomRenderers
{
    public class RoundedPickerCustomRenderer : PickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.Background = Android.App.Application.Context.GetDrawable(Resource.Drawable.RoundedPicker);
            }
        }

        public RoundedPickerCustomRenderer(Context context) : base(context)
        {
        }
    }
}