using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System.Threading.Tasks;

namespace mvvmcross_hello_world.ViewModels
{
    public class RootViewModel : MvxNavigationViewModel
    {
        private readonly IMvxNavigationService _NavigationService;

        public RootViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigation)
            : base(logProvider, navigation)
        {
            _NavigationService = navigation;
        }

        public override void ViewAppearing()
        {
            base.ViewAppearing();
            
            MvxNotifyTask.Create(async () => await this.GoToHome());
        }

        private async Task GoToHome()
        {
            await _NavigationService.Navigate<FirstViewModel>();
        }
    }
}
