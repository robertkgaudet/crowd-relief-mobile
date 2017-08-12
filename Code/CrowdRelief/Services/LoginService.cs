using CrowdRelief.Interfaces;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Auth;
using Xamarin.Auth.Presenters;

namespace CrowdRelief.Services
{
    public class LoginService : ILoginService
    {
        public Task CheckToken()
        {
            throw new NotImplementedException();
        }

        public Task GetToken()
        {
            throw new NotImplementedException();
        }

        public async Task LoginAsync(string provider)
        {
            OAuth2Authenticator authenticator = null;
            var presenter = new OAuthLoginPresenter();

            switch (provider)
            {
                case Constants.Providers.Google:
                    authenticator = new OAuth2Authenticator(Constants.ApiInfo.GoogleDroidClientId,
                        Constants.ApiInfo.GoogleScopes, new Uri(Constants.ApiInfo.GoogleAuthUrl),
                        new Uri(Constants.ApiInfo.GoogleRedirectUrl), null, true);
                    authenticator.Completed += OnAuthCompleted;
                    authenticator.Error += OnAuthError;
                    App.AuthenticationState = authenticator;
                    presenter.Login(authenticator);
                    break;
                case Constants.Providers.Facebook:
                    break;
                case Constants.Providers.Microsoft:
                    break;
                case Constants.Providers.Twitter:
                    break;
                case Constants.Providers.Local:
                    break;
                default:
                    break;
            }
        }

        private void OnAuthError(object sender, AuthenticatorErrorEventArgs e)
        {
            Debug.WriteLine($"Login failed {e.Message}");
        }

        private void OnAuthCompleted(object sender, AuthenticatorCompletedEventArgs e)
        {
            if (e.IsAuthenticated)
                Debug.WriteLine(e.Account);
        }

        public Task LogOut()
        {
            throw new NotImplementedException();
        }

        public Task StoreToken()
        {
            throw new NotImplementedException();
        }
    }
}
