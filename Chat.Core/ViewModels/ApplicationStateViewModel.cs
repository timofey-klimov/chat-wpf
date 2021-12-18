using Chat.Core.ViewModels.Base;

namespace Chat.Core.ViewModels
{
    public class ApplicationStateViewModel : BaseViewModel
    {
        public bool ExpandSideMenu { get; set; }

        public ApplicationStateViewModel()
        {
            ExpandSideMenu = false;
        }
    }
}
