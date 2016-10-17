using FormsIntro.Helpers.Dialog;
using FormsIntro.Helpers.Events;
using FormsIntro.Helpers.Navigation;
using Ninject.Modules;

namespace FormsIntro.Helpers.Composition
{
    public class SharedModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IEventAggregator>().To<EventAggregator>().InSingletonScope();
            Bind<IDialogService>().To<DialogService>().InSingletonScope();
            Bind<INavigationHelper>().To<NavigationHelper>().InSingletonScope();
        }
    }
}