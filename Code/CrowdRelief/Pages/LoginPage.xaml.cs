using System;
using Xamarin.Forms;

namespace CrowdRelief.Pages
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

		//User clicked provider login button.
        void LoginClick(object sender, EventArgs args)
        {
            Button btncontrol = (Button)sender;
            string providername = btncontrol.Text;
            if (OAuthConfig.User == null)
            {
                Navigation.PushModalAsync(new ProviderLoginPage(providername));
            }
        }
    }
}
