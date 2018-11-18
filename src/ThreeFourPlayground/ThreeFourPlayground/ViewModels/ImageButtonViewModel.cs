using System.Diagnostics;
using System.Windows.Input;
using ThreeFourPlayground.ViewModels.Base;
using Xamarin.Forms;

namespace ThreeFourPlayground.ViewModels
{
    public class ImageButtonViewModel : ViewModelBase
    {
        public ICommand ImageButtonCommand => new Command<string>(ExecuteImageButton);

        void ExecuteImageButton(string parameter)
        {
            Debug.Write(parameter);
        }
    }
}