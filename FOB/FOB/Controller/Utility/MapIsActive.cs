using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Gms.Common;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace FOB.Controller.Utility
{
  public   class MapIsActive
    {
        Context vcontext;
        public MapIsActive(Context ctx)
        {
            vcontext = ctx;
        }
   public      bool IsGooglePlayServicesInstalled()
        {
            var queryResult = GoogleApiAvailability.Instance.IsGooglePlayServicesAvailable(vcontext);
            if (queryResult == ConnectionResult.Success)
            {
                //Log.Info("MainActivity", "شما سرویس گوگل پلی را نصب کرده اید");
                return true;
            }

            if (GoogleApiAvailability.Instance.IsUserResolvableError(queryResult))
            {

                var errorString = GoogleApiAvailability.Instance.GetErrorString(queryResult);
                //Log.Error("MainActivity", "اجرای سرویس گوگل پلی به مشکل خورده است {0} - {1}",
                //          queryResult, errorString);

                // خطا را به کاربر نمایش می دهد.
            }

            return false;
        }
    }
}