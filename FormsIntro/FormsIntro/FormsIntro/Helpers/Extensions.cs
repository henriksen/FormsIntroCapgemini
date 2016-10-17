using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using XLabs.Forms.Mvvm;

namespace FormsIntro.Helpers
{
    public static class Extensions
    {
        public static async Task RunAsBusy(this ViewModel viewModel, Task task)
        {
            try
            {
                viewModel.IsBusy = true;
                await task;
            }
            finally
            {
                viewModel.IsBusy = false;
            }
        }
        public static async Task<T> RunAsBusyWitResult<T>(this ViewModel viewModel, Task<T> task)
        {
            try
            {
                viewModel.IsBusy = true;
                return await task;
            }
            finally
            {
                viewModel.IsBusy = false;
            }
        }

        public static Task<T> ShowModalPageWithResultOnDismiss<T>(this ViewModel viewModel, Page page, Func<T> result)
        {
            var tcs = new TaskCompletionSource<T>();

            Device.BeginInvokeOnMainThread(async () =>
            {
                try
                {
                    EventHandler callback = null;

                    callback = (sender, args) =>
                    {
                        page.Disappearing -= callback;
                        tcs.SetResult(result());
                    };
                    
                    page.Disappearing += callback;

                    await viewModel.Navigation.PushModalAsync(page);
                }
                catch (Exception ex)
                {
                    tcs.SetException(ex);
                }
            });

            return tcs.Task;
        }

    }
}
