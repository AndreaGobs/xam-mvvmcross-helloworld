using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace mvvmcross_hello_world
{
    public class CoreApp : MvxApplication
    {
        public override void Initialize()
        {
            RegisterCustomAppStart<AppStart>();
        }
    }
}
