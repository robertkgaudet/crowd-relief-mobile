using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Content.PM;

namespace CrowdRelief.Droid.Xamarin.Auth
{
    [Activity(Label = "CustomUrlSchemeInterceptorActivity")]
    [IntentFilter(new[] { Intent.ActionView },Categories = new[] { Intent.CategoryDefault, Intent.CategoryBrowsable },
        DataSchemes = new[] {Constants.ApiInfo.GoogleInfo.GoogleCustomUriSchema}, DataHost =Constants.ApiInfo.GoogleInfo.GoogleDataPath)]
    public class CustomUrlSchemInterceptorActivity: Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            global::Android.Net.Uri uri_android = Intent.Data;

#if DEBUG
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine("ActivityCustomUrlSchemeInterceptor.OnCreate()");
            sb.Append("     uri_android = ").AppendLine(uri_android.ToString());
            System.Diagnostics.Debug.WriteLine(sb.ToString());
#endif

            // Convert iOS NSUrl to C#/netxf/BCL System.Uri - common API
            Uri uri_netfx = new Uri(uri_android.ToString());

            // load redirect_url Page
           App.AuthenticationState.OnPageLoading(uri_netfx);

            this.Finish();

            return;
            //base.OnCreate(savedInstanceState);
            //var uri = new Uri(Intent.Data.ToString());

            ////App.AuthenticationState.OnPageLoading(uri);

            //Finish();
        }
    }
}