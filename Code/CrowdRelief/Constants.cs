using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdRelief
{
    public class Constants
    {
        public struct ApiInfo
        {
            public struct GoogleInfo
            {
                public const string GoogleDroidClientId = "1052811891786-urod3ma4p4hs6slefuukmt3t48hm56js.apps.googleusercontent.com";
                public const string GoogleWebClientId = "1052811891786-l34a5va898dbobm4ht86md843dl79un2.apps.googleusercontent.com";
                public const string GoogleiOSClientId = "1052811891786-iuui5rc9fmhksm61kedm2dlu9lhs50vg.apps.googleusercontent.com";
                public const string GoogleClientSecret = "T7h6Xz_ieh0vMTLrd2S4jxe2";
                public const string GoogleAuthUrl = "https://accounts.google.com/o/oauth2/auth";
                public const string GoogleRedirectUrl = "com.googleusercontent.apps.1052811891786-urod3ma4p4hs6slefuukmt3t48hm56js:/oauth2redirect";
                public const string GoogleWebReidirectUrl = "apps.googleusercontent.com.1052811891786-l34a5va898dbobm4ht86md843dl79un2:/oauth2redirect";
                public const string GoogleTokenUrl = "https://accounts.google.com/o/oauth2/token";
                public static readonly string[] GoogleScopes = { "https://www.googleapis.com/auth/userinfo.profile", "https://www.googleapis.com/auth/userinfo.email"};
                public const string GoogleCustomUriSchema = "com.googleusercontent.apps.1052811891786-urod3ma4p4hs6slefuukmt3t48hm56js";
                //public const string GoogleCustomUriSchema = "com.crowdrelief.droid";
                public const string GoogleDataPath = "/oauth2redirect";
            }
           

        }
        public struct Providers
        {
            public const string Google = "google";
            public const string Facebook = "facebook";
            public const string Twitter = "twitter";
            public const string Microsoft = "microsoft";
            public const string Local = "local";

        }
    }
}
