using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CitySpace.Core.ViewModel;
using MvvmCross.Platforms.Android.Views;

namespace CitySpace.Droid.Views
{
    [Activity(Label = "Home", Theme = "@style/AppTheme")]
    public class HomeView : MvxActivity<HomeViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.homeview);
        }
    }
}