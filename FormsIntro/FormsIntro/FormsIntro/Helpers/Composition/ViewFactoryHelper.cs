using Xamarin.Forms;
using XLabs.Forms.Mvvm;

namespace FormsIntro.Helpers.Composition
{
    public interface IViewFactoryHelper
    {
        Composition<T> ComposePage<T>() where T : ViewModel;
    }

    public class ViewFactoryHelper : IViewFactoryHelper
    {
        public Composition<T> ComposePage<T>() where T : ViewModel
        {
            T viewModel = null;
            var page = (Page)ViewFactory.CreatePage(typeof(T), (vm, view) => { viewModel = (T)vm; });
            return new Composition<T>(viewModel, page);
        }
    }

    public class Composition<T>
    {
        public Composition(T viewModel, Page view)
        {
            ViewModel = viewModel;
            View = view;
        }

        public T ViewModel { get; }
        public Page View { get; }
    }
}
