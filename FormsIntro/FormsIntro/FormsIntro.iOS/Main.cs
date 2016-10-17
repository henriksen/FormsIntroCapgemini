using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using Ninject;
using UIKit;
using XLabs.Ioc;
using XLabs.Ioc.Ninject;

namespace FormsIntro.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            if (!Resolver.IsSet)
            {
                var kernel = new StandardKernel(new SharedModule());
                var resolver = new NinjectResolver(kernel);
                Resolver.SetResolver(resolver);
            }
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");
        }
    }
}
