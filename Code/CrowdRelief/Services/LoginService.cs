using CrowdRelief.Interfaces;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Auth;
using Xamarin.Auth.Presenters;
using Xamarin.Forms;

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

        public Task LoginAsync(string provider)
        {
            OAuth2Authenticator authenticator = null;

            switch (provider)
            {
                case Constants.Providers.Google:
                    var clientId = Device.RuntimePlatform == Device.iOS ? Constants.ApiInfo.GoogleInfo.GoolgeiOSClientId : Constants.ApiInfo.GoogleInfo.GoogleDroidClientId;
                    authenticator = CreateAuthenticator(clientId,Constants.ApiInfo.GoogleInfo.GoogleScopes,Constants.ApiInfo.GoogleInfo.GoogleAuthUrl,Constants.ApiInfo.GoogleInfo.GoogleTokenUrl,Constants.ApiInfo.GoogleInfo.GoogleRedirectUrl);
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

            return Task.FromResult(0);
        }

        private OAuth2Authenticator CreateAuthenticator(string clientId, string scopes, string authUrl, string tokenUrl, string redirect)
        {
            var presenter = new OAuthLoginPresenter();
            OAuth2Authenticator authenticator = new OAuth2Authenticator(clientId,null,
                scopes, new Uri(authUrl),
                new Uri(redirect), new Uri(tokenUrl), null, true);
            authenticator.Completed += OnAuthCompleted;
            authenticator.Error += OnAuthError;
            App.AuthenticationState = authenticator;
            presenter.Login(authenticator);
            return authenticator;
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
