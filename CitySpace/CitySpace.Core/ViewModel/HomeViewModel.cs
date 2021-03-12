using Acr.UserDialogs;
using MvvmCross;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CitySpace.Core.ViewModel
{
    public class HomeViewModel : MvxViewModel
    {
        public override async Task Initialize()
        {
            await base.Initialize();            
        }

        private string _city;
        public string City
        {
            get => _city;
            set
            {
                _city = value;
                RaisePropertyChanged(() => City);
            }
        }

        public ICommand SubmitCommand
        {
            get 
            { 
                return new MvxCommand(() => {                    
                    if (string.IsNullOrEmpty(City))
                    {
                        Mvx.IoCProvider.Resolve<IUserDialogs>().Alert("Please Enter City Name", "Error", "ok");
                    }
                    else
                    {
                        City = "My City Name is: " + City;
                        Mvx.IoCProvider.Resolve<IUserDialogs>().Alert(City, "Alert!!", "ok");
                        //Reset the City Property after displaying alert
                        City = string.Empty;
                    }
                }); 
            }
        }
    }
}
