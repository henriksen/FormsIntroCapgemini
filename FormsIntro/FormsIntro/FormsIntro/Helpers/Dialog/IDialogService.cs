using System.Threading.Tasks;

namespace FormsIntro.Helpers.Dialog
{
    public interface IDialogService
    {
        Task DisplayAlert(string title, string message, string actionText = "Close");

    }
}