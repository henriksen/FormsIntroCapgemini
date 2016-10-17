using System.Threading.Tasks;
using FormsIntro.Helpers.Navigation;

namespace FormsIntro.Helpers.Dialog
{
    public class DialogService : IDialogService
    {
        private readonly INavigationHelper _navigationHelper;

        public DialogService(INavigationHelper navigationHelper)
        {
            _navigationHelper = navigationHelper;
        }

        private bool _displayingDialog;

        public async Task DisplayAlert(string title, string message, string actionText = "Close")
        {
            await DisplayAlertFor(_navigationHelper.CurrentPage.DisplayAlert(title, message, actionText));
        }

        private async Task DisplayAlertFor(Task task)
        {
            if (_displayingDialog)
            {
                return;
            }

            try
            {
                _displayingDialog = true;
                await task;
            }
            finally
            {
                _displayingDialog = false;
            }
        }
    }

    
}