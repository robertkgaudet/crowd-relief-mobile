using CrowdRelief.Ioc;
using Xamarin.Auth;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace CrowdRelief
{
    public partial class App : Application
    {
        public static OAuth2Authenticator AuthenticationState { get; set; }
        public App()
        {
            Container.Initialize();
            //Make sure the user is logged in, then send to the tabbed page
            //MainPage = new CrowdRelief.Pages.CrowdReliefTabbedPage();
            //MainPage = new FacebookLogin.Views.LoginPage();
            MainPage = new Pages.LoginPage(Container.Get<Interfaces.ILoginService>());
            //MainPage = Container.Get<Pages.LoginPage>();
            //If the user is no t logged in, send to the SignIn page.


            //NavigationPage navigationPage = new NavigationPage(MainPage);
            //navigationPage.BarBackgroundColor = Color.Red;
            //navigationPage.BarTextColor = Color.Red;

            //navigationPage = new CrowdRelief.Pages.CrowdReliefNavigationPage(new CrowdRelief.Pages.Stream());

            //MainPage = navigationPage;// new NavigationPage(new CrowdRelief.Pages.Master());

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
