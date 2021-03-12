using CitySpace.Core.ViewModel;
using MvvmCross.Platforms.Ios.Views;
using MvvmCross.Binding.BindingContext;

namespace CitySpace.iOS.Views
{
    public partial class HomeView:  MvxViewController<HomeViewModel>
    {
        public HomeView() : base(nameof(HomeView), null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            var set = this.CreateBindingSet<HomeView, HomeViewModel>();            
            set.Bind(CityTextField).To(vm => vm.City);
            set.Bind(BtnSubmit).To(vm => vm.SubmitCommand);
            set.Apply();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }        
    }
}

