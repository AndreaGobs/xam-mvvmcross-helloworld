using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;

namespace mvvmcross_hello_world.Pages
{
    [MvxMasterDetailPagePresentation(MasterDetailPosition.Root, WrapInNavigationPage = false)]
    public partial class RootPage : MvxMasterDetailPage
    {
		public RootPage ()
		{
			InitializeComponent ();
		}
	}
}