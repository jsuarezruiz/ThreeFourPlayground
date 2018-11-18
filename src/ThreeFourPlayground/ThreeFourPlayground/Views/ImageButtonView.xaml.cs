using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace ThreeFourPlayground.Views
{
    public partial class ImageButtonView : ContentPage
	{
		public ImageButtonView ()
		{
			InitializeComponent ();

            ImageButton.On<Android>().SetShadowColor(Color.Green);
            ImageButton.On<Android>().SetIsShadowEnabled(true);
            ImageButton.On<Android>().SetShadowOffset(new Size(25, 25));
        }
	}
}