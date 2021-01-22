using Android.Content;
using StudentMarks.CustomControls;
using StudentMarks.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(IconFrame), typeof(EntryFrameCustomRenderer))]
namespace StudentMarks.Droid.CustomRenderers
{
    public class EntryFrameCustomRenderer : FrameRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Frame> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                ViewGroup.SetBackgroundResource(Resource.Drawable.blue_resct);
            }
        }

        public EntryFrameCustomRenderer(Context context) : base(context)
        {
        }
    }
}