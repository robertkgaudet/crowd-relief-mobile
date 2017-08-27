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
            var account = new SimpleAuth.Account();
            switch (provider)
            {
                case Constants.Providers.Google:
                    var clientId = Device.RuntimePlatform == Device.iOS ? Constants.ApiInfo.GoogleInfo.GoogleiOSClientId : Constants.ApiInfo.GoogleInfo.GoogleWebClientId;
                    var clientSecret = Device.RuntimePlatform == Device.iOS ? null : Constants.ApiInfo.GoogleInfo.GoogleClientSecret;
                    var googAuthenticator = new GoogleApi("google", clientId, clientSecret) { Scopes = Constants.ApiInfo.GoogleInfo.GoogleScopes };
                    account = await googAuthenticator.Authenticate();
                    break;
                case Constants.Providers.Facebook:
                    var facebookAuthenticator = new FacebookApi("facebook", Constants.ApiInfo.FacebookInfo.FacebookAppId, Constants.ApiInfo.FacebookInfo.FacebookSecret);
                    account = await facebookAuthenticator.Authenticate();
                    break;
                case Constants.Providers.Microsoft:
                    var microsoftAuthenticator = new MicrosoftLiveConnectApi("microsoft", Constants.ApiInfo.MicrosoftInfo.MicrosoftAppId, Constants.ApiInfo.MicrosoftInfo.MicrosoftSecret)
                    { Scopes = Constants.ApiInfo.MicrosoftInfo.MicrosoftScopes };
                   account = await microsoftAuthenticator.Authenticate();
                    ;
                    break;
                case Constants.Providers.Twitter:
                    var twitterAuthenticator = new TwitterApi("twitter", Constants.ApiInfo.TwitterInfo.TwitterAppId, Constants.ApiInfo.TwitterInfo.TwitterSecret) {RedirectUrl=new Uri("https://mobile.twitter.com/home") };
                    account = await twitterAuthenticator.Authenticate();
                    ;
                    break;
                case Constants.Providers.Local:
                    break;
                default:
                    break;
            }

            return;
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
