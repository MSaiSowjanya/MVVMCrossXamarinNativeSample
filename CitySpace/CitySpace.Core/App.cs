using Acr.UserDialogs;
using CitySpace.Core.ViewModel;
using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.ViewModels;


namespace CitySpace.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
            .EndingWith("Service")
           .AsInterfaces()
           .RegisterAsLazySingleton();

            Mvx.IoCProvider.RegisterSingleton<IUserDialogs>(() => UserDialogs.Instance);

            RegisterAppStart<HomeViewModel>();
        }
    }
}
