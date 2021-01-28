using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using MvvmCross.Forms.Platforms.Ios.Core;
using UIKit;

namespace mvvmcross_hello_world.iOS
{
    public class Setup : MvxFormsIosSetup<mvvmcross_hello_world.CoreApp, mvvmcross_hello_world.App>
    {
        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();
        }
    }
}