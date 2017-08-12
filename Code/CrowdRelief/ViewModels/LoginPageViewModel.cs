using CrowdRelief.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CrowdRelief.ViewModels
{
    public class LoginPageViewModel:BaseViewModel
    {
        readonly ILoginService _apiService;

        public LoginPageViewModel(ILoginService apiService)
        {
            _apiService = apiService;
        }

        Command<string> loginCommand;
        public Command<string> LoginCommand => loginCommand ?? (loginCommand = new Command<string>(async (provider) => await ExecuteLoginCommand(provider).ConfigureAwait(false)));

        private async Task ExecuteLoginCommand(string provider)
        {
            try
            {
                await _apiService.LoginAsync(provider);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }
    }
}
