using CrowdRelief.Interfaces;
using CrowdRelief.ViewModels;
using System;
using Xamarin.Forms;

namespace CrowdRelief.Pages
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage(ILoginService apiService)
        {
            InitializeComponent();
            BindingContext = new LoginPageViewModel(apiService);
        }
    }
}
