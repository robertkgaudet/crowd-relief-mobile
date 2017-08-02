using System;
using Xamarin.Forms;

namespace CrowdRelief.Pages
{
   public class OAuthConfig
    {
        public static HomePage _HomePage;
        static NavigationPage _NavigationPage;
        public static UserDetails User;
		public TabbedPage _TabbedPage;

		public static Action SuccessfulLoginAction
        {
            get
            {
                return new Action(() =>
				{
					//_NavigationPage.Navigation.PushModalAsync(_HomePage);
					_NavigationPage.Navigation.PushModalAsync(new TabbedPage());
                });
            }
        }

    }
}