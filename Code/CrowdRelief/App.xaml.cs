using Xamarin.Forms;

namespace CrowdRelief
{
    public partial class App : Application
    {
        public App()
        {
            //Make sure the user is logged in, then send to the tabbed page
            //MainPage = new CrowdRelief.Pages.CrowdReliefTabbedPage();
			//MainPage = new FacebookLogin.Views.LoginPage();
			MainPage = new CrowdRelief.Pages.LoginPage();

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