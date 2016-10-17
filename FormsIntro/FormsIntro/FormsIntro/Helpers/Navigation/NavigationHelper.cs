using Xamarin.Forms;

namespace FormsIntro.Helpers.Navigation
{
    public class NavigationHelper
    {
        private NavigationPage CurrentNavigationPage => (Application.Current.MainPage as NavigationPage);

        public Page CurrentPage => CurrentNavigationPage?.CurrentPage;

        public INavigation CurrentNavigation => CurrentPage?.Navigation;
    }
}