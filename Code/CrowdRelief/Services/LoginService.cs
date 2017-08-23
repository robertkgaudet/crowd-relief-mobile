using CrowdRelief.Interfaces;
using SimpleAuth.Providers;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
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

        public async Task LoginAsync(string provider)
        {
            switch (provider)
            {
                case Constants.Providers.Google:
                    var clientId = Device.RuntimePlatform == Device.iOS ? Constants.ApiInfo.GoogleInfo.GoogleiOSClientId : Constants.ApiInfo.GoogleInfo.GoogleWebClientId;
                    var clientSecret = Device.RuntimePlatform == Device.iOS ? null : Constants.ApiInfo.GoogleInfo.GoogleClientSecret;
                    await CreateAuthenticator(clientId, Constants.ApiInfo.GoogleInfo.GoogleScopes, clientSecret,
                        Constants.ApiInfo.GoogleInfo.GoogleTokenUrl, Constants.ApiInfo.GoogleInfo.GoogleRedirectUrl);
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

            return;
        }

        private async Task CreateAuthenticator(string clientId, string[] scopes, string clientSecret, string tokenUrl, string redirect)
        {
            var authenticator =
                 new GoogleApi("google", clientId, clientSecret) { Scopes = scopes};
            try
            {
                var account = await authenticator.Authenticate();               
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }

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
