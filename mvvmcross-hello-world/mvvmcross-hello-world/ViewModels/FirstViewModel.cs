using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace mvvmcross_hello_world.ViewModels
{
    public class FirstViewModel : MvxNavigationViewModel
    {
        private readonly IMvxNavigationService _NavigationService;

        public FirstViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigation)
            : base(logProvider, navigation)
        {
            _NavigationService = navigation;
        }

        #region Properties
        public string HelloMessage => "Hello MvvmCross project!";
        #endregion

        #region Commands
        public IMvxCommand GoToCarousel => new MvxCommand(() =>
        {
            _NavigationService.Navigate<CarouselViewModel>();
        });
        #endregion
    }
}
