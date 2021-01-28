using MvvmCross.Exceptions;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using mvvmcross_hello_world.ViewModels;
using System;
using System.Threading.Tasks;

namespace mvvmcross_hello_world
{
    public class AppStart : MvxAppStart
    {
        public AppStart(IMvxApplication application, IMvxNavigationService navigationService)
            : base(application, navigationService)
        {
        }

        protected override Task NavigateToFirstViewModel(object hint = null)
        {
            try
            {
                return NavigationService.Navigate<RootViewModel>();
            }
            catch (Exception ex)
            {
                throw ex.MvxWrap("Problem navigating to ViewModel {0}", typeof(RootViewModel).Name);
            }
        }
    }
}
