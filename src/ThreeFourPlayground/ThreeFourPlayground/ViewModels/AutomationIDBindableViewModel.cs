using ThreeFourPlayground.ViewModels.Base;

namespace ThreeFourPlayground.ViewModels
{
    public class AutomationIDBindableViewModel : ViewModelBase
    {
        string _automationId;

        public AutomationIDBindableViewModel()
        {
            AutomationId = "AutomationBtn";
        }

        public string AutomationId
        {
            get { return _automationId; }
            set
            {
                _automationId = value;
                OnPropertyChanged();
            }
        }
    }
}