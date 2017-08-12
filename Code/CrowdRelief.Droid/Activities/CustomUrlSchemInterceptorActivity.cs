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

namespace CrowdRelief.Droid.Activities
{
    [Activity(Label = "CustomUrlSchemeInterceptorActivity", NoHistory = true, LaunchMode = LaunchMode.SingleTop)]
    [IntentFilter(new[] { Intent.ActionView },Categories = new[] { Intent.CategoryDefault, Intent.CategoryBrowsable },
        DataSchemes = new[] { Constants.ApiInfo.GoogleCustomUriSchema }, DataPath = Constants.ApiInfo.GoogleDataPath)]
    public class CustomUrlSchemInterceptorActivity: Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            var uri = new Uri(Intent.Data.ToString());

            App.AuthenticationState.OnPageLoading(uri);

            Finish();
        }
    }
}