using Android.Content;
using StudentMarks.CustomControls;
using StudentMarks.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(MyFrame), typeof(MyFrameCustomRenderer))]
namespace StudentMarks.Droid.CustomRenderers
{
    public class MyFrameCustomRenderer : FrameRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Frame> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                ViewGroup.SetBackgroundResource(Resource.Drawable.CustomFrame);
            }
        }

        public MyFrameCustomRenderer(Context context) : base(context)
        {
        }
    }
}