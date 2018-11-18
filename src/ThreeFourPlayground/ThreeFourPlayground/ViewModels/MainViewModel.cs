using System.Windows.Input;
using ThreeFourPlayground.ViewModels.Base;
using Xamarin.Forms;

namespace ThreeFourPlayground.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ICommand AutomationCommand => new Command(ExecuteAutomation);
        public ICommand ImageButtonCommand => new Command(ExecuteImageButton);
        public ICommand TabIndexCommand => new Command(ExecuteTabIndex);

        void ExecuteAutomation()
        {
            NavigationService.NavigateToAsync<AutomationIDBindableViewModel>();
        }

        void ExecuteImageButton()
        {
            NavigationService.NavigateToAsync<ImageButtonViewModel>();
        }

        void ExecuteTabIndex()
        {
            NavigationService.NavigateToAsync<TabIndexViewModel>();
        }
    }
}