using System;
using CrowdRelief.Interfaces;
using CrowdRelief.Ioc;
using CrowdRelief.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CrowdRelief.Services;
using CrowdRelief.Pages;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace CrowdRelief
{
    public partial class App : Application
    {
        public App()
        {
            Container.Initialize();
            Pages();
            Container.Resolve<INavigationService>().NavigateToRoot<LoginPageViewModel>(false);         
        }

        private void Pages()
        {
            Container.Register<INavigationService>(new NavigationService
            {
                Registrations =
                {
                    { typeof(LoginPage), typeof(LoginPageViewModel) },
                }
            });
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
