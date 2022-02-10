using AndroidX.Core.Content;
using SG2022.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("SG2022")]
[assembly: ExportEffect(typeof(SG2022.Droid.CoverEffect), nameof(CoverEffect))]
namespace SG2022.Droid
{
	public class CoverEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            UpdateBackground();
        }

        protected override void OnDetached()
        {
        }

        private void UpdateBackground()
        {
            Android.Views.View mView = Container as Android.Views.View;

            if (mView == null)
            {
                return;
            }
            mView.Background = ContextCompat.GetDrawable(mView.Context, Resource.Drawable.carbon_fibre);
        }
    }
}
