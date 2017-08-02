using Android.App;
using Xamarin.Forms.Platform.Android;
using CrowdRelief;
using Xamarin.Forms;
using CrowdRelief.Droid.PageRender;
using CrowdRelief.Pages;
using System.Threading.Tasks;
using System.Net.Http;

[assembly: ExportRenderer(typeof(ProviderLoginPage), typeof(LoginRenderer))]
namespace CrowdRelief.Droid.PageRender
{
    public class LoginRenderer : PageRenderer
    {
		public async Task GetFacebookProfileAsync(string accessToken)
		{
			var requestURL = "https://graph.facebook.com/v2.7/me/" +
				"?fields=name,email,is_verified&access_token=" + accessToken;

			var httpClient = new HttpClient();

			var userJson = await httpClient.GetStringAsync(requestURL);
		}


        bool showLogin = true;
        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged(e);
            
            //Get and Assign ProviderName from ProviderLoginPage
            var loginPage = Element as ProviderLoginPage;
            string providername = loginPage.ProviderName;

            var activity = this.Context as Activity;
            if (showLogin && OAuthConfig.User == null)
            {
                showLogin = false;
               
                //Create OauthProviderSetting class with Oauth Implementation .Refer Step 6
                OAuthProviderSetting oauth = new OAuthProviderSetting();
				
                if (providername == "Twitter")
                {
                    var auth = oauth.LoginWithTwitter();

                   // After Twitter  login completed 
                    auth.Completed += (sender, eventArgs) =>
                    {
                        if (eventArgs.IsAuthenticated)
                        {
                            OAuthConfig.User = new UserDetails();
                            // Get and Save User Details 
                            OAuthConfig.User.Token = eventArgs.Account.Properties["oauth_token"];
                            OAuthConfig.User.TokenSecret = eventArgs.Account.Properties["oauth_token_secret"];
                            OAuthConfig.User.TwitterId = eventArgs.Account.Properties["user_id"];
                            OAuthConfig.User.ScreenName = eventArgs.Account.Properties["screen_name"];

                            OAuthConfig.SuccessfulLoginAction.Invoke();
                        }
                        else
                        {
                            // The user cancelled
                        }
                    };


                    activity.StartActivity(auth.GetUI(activity));
                }
				else if (providername.ToLower() == "facebook")
				{
					var auth = oauth.LoginWithProvider(providername);

					// After facebook,google and all identity provider login completed 
					auth.Completed += (sender, eventArgs) =>
					{
						if (eventArgs.IsAuthenticated)
						{
							

							OAuthConfig.User = new UserDetails();
							// Get and Save User Details 
							OAuthConfig.User.FacebookAccessToken = eventArgs.Account.Properties["accessToken"];
							OAuthConfig.User.ScreenName = eventArgs.Account.Properties["screen_name"];

							OAuthConfig.SuccessfulLoginAction.Invoke();
						}
						else
						{
							// The user cancelled
						}
					};
				}
                else
                {
                    var auth = oauth.LoginWithProvider(providername);

                    // After facebook,google and all identity provider login completed 
                    auth.Completed += (sender, eventArgs) =>
                    {
                        if (eventArgs.IsAuthenticated)
                        {
                            OAuthConfig.User = new UserDetails();
                            // Get and Save User Details 
                            OAuthConfig.User.Token = eventArgs.Account.Properties["oauth_token"];
                            OAuthConfig.User.TokenSecret = eventArgs.Account.Properties["oauth_token_secret"];
                            OAuthConfig.User.TwitterId = eventArgs.Account.Properties["user_id"];
                            OAuthConfig.User.ScreenName = eventArgs.Account.Properties["screen_name"];

                            OAuthConfig.SuccessfulLoginAction.Invoke();
                        }
                        else
                        {
                            // The user cancelled
                        }
                    };


                    activity.StartActivity(auth.GetUI(activity));
                }
            }
        }
    }
}