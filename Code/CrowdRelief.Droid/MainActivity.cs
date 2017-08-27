using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content;

[assembly: MetaData("com.facebook.sdk.ApplicationId", Value = "@string/facebook_app_id")]
namespace CrowdRelief.Droid {
	[Activity(
		Label = "CrowdRelief", 
		Icon = "@drawable/icon", 
		MainLauncher = false, 
		ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity {
		protected override void OnCreate(Bundle bundle)
        {
			base.OnCreate(bundle);
            SimpleAuth.Providers.Google.Init(this.Application);
            SimpleAuth.Providers.Facebook.Init(this.Application,false);
            global::Xamarin.Forms.Forms.Init(this, bundle);
			LoadApplication(new App());

        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            SimpleAuth.Native.OnActivityResult(requestCode, resultCode, data);
        }
    }
}

