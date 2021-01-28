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
using MvvmCross.Forms.Platforms.Android.Core;

namespace mvvmcross_hello_world.Droid
{
    public class Setup : MvxFormsAndroidSetup<mvvmcross_hello_world.CoreApp, mvvmcross_hello_world.App>
    {
        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();
        }
    }
}