using Android.Content;
using Android.Content.Res;
using Android.Graphics.Drawables;
using Android.Text;
using StudentMarks.CustomControls;
using StudentMarks.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryCustomRenderer))]
namespace StudentMarks.Droid.CustomRenderers
{
    public class MyEntryCustomRenderer : EntryRenderer
    {
        [System.Obsolete]
#pragma warning disable CS0809 // Obsolete member overrides non-obsolete member
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
#pragma warning restore CS0809 // Obsolete member overrides non-obsolete member
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                GradientDrawable gd = new GradientDrawable();
                gd.SetColor(global::Android.Graphics.Color.Transparent);
                this.Control.SetBackgroundDrawable(gd);
                this.Control.SetRawInputType(InputTypes.TextFlagNoSuggestions);
                Control.SetHintTextColor(ColorStateList.ValueOf(global::Android.Graphics.Color.Black));
            }
        }

        public MyEntryCustomRenderer(Context context) : base(context)
        {
        }
    }
}