using Xamarin.Forms;

namespace FormsIntro.Helpers.Navigation
{
    public interface INavigationHelper
    {
        INavigation CurrentNavigation { get; }
        Page CurrentPage { get; }
    }
}