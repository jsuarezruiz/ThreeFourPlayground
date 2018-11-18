namespace ThreeFourPlayground.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new ThreeFourPlayground.App());
        }
    }
}
