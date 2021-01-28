using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System.Collections.Generic;
using Xamarin.Forms;

namespace mvvmcross_hello_world.ViewModels
{
    public class InnerItem
    {
        public string Name { get; set; }
        public Color Color { get; set; }
    }

    public class TestItem
    {
        public string Name { get; set; }
        public Color Color { get; set; } 
        public List<InnerItem> Items { get; set; }
    }

    public class CarouselViewModel : MvxNavigationViewModel
    {
        private readonly IMvxNavigationService _NavigationService;

        public CarouselViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigation)
            : base(logProvider, navigation)
        {
            _NavigationService = navigation;

            var collectionItems = new List<InnerItem>
            {
                new InnerItem { Name = "White", Color = Color.White },
                new InnerItem { Name = "LightBlue", Color = Color.LightBlue },
                new InnerItem { Name = "LightGreen", Color = Color.LightGreen },
                new InnerItem { Name = "Pink", Color = Color.Pink },
                new InnerItem { Name = "LightYellow", Color = Color.LightYellow },
                new InnerItem { Name = "Purple", Color = Color.Purple },
                new InnerItem { Name = "Brown", Color = Color.Brown },
            };

            CarouselItems = new List<TestItem>
            {
                new TestItem { Name = "Gray", Color = Color.Gray, Items = collectionItems },
                new TestItem { Name = "Blue", Color = Color.Blue, Items = collectionItems},
                new TestItem { Name = "Red", Color = Color.Red, Items = collectionItems },
                new TestItem { Name = "Green", Color = Color.Green, Items = collectionItems },
                new TestItem { Name = "Yellow", Color = Color.Yellow, Items = collectionItems },
            };
        }

        #region Properties
        public List<TestItem> CarouselItems { get; private set; }
        #endregion
    }
}
