using MvvmCross.Forms.Views;
using Xamarin.Forms.Xaml;

namespace mvvmcross_hello_world.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FirstPage : MvxContentPage
    {
		public FirstPage ()
		{
			InitializeComponent ();
		}
	}
}