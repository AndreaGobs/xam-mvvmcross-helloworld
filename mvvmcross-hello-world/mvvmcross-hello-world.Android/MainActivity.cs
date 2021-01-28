using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using MvvmCross.Forms.Platforms.Android.Views;

namespace mvvmcross_hello_world.Droid
{
    [Activity(Label = "mvvmcross_hello_world", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, NoHistory = true, ScreenOrientation = ScreenOrientation.Portrait)]
    public partial class MainActivity : MvxFormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }
    }
}