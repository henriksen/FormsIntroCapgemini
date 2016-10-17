using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Ninject;
using XLabs.Ioc;
using XLabs.Ioc.Ninject;

namespace FormsIntro.Droid
{
    [Activity(Label = "FormsIntro", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            //if (!Resolver.IsSet)
            //{
            //    var kernel = new StandardKernel(new SharedModule());
            //    var resolver = new NinjectResolver(kernel);
            //    Resolver.SetResolver(resolver);
            //}

            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

