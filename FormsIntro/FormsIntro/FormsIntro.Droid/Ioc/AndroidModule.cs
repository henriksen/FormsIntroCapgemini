using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Ninject.Modules;

namespace FormsIntro.Droid.Ioc
{
    public class AndroidModule : NinjectModule
    {
        public override void Load()
        {
            //Add android dependencies here
        }
    }
}