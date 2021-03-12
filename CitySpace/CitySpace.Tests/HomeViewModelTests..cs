using Acr.UserDialogs;
using CitySpace.Core.ViewModel;
using Moq;
using MvvmCross.Tests;
using NUnit.Framework;
using System;

namespace CitySpace.Tests
{
    [TestFixture]
    public class HomeViewModelTests : MvxIoCSupportingTest
    {
        protected override void AdditionalSetup()
        {
            // an automatically Mocked service:
            var userDialogService = new Mock<IUserDialogs>();
            Ioc.RegisterSingleton<IUserDialogs>(userDialogService.Object);
        }


        [Test]
        public void TestHomeViewModel()
        {
            base.Setup(); // from MvxIoCSupportingTest

            // your test code

            var vm = Ioc.IoCConstruct<HomeViewModel>();
            var city = "Hyderabad";
            vm.City = city;

            //Check for City Property Not Null
            Assert.IsNotNull(vm.City);

            vm.SubmitCommand.Execute(null);

            //Check City Property Value Reset or not
            Assert.AreEqual(string.Empty, vm.City);
        }
    }
}
