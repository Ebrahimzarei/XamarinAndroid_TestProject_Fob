using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Threading.Tasks;
using Android.Content;
using System.Collections.Generic;
using System.Net.Http;
using System;
using Newtonsoft.Json.Linq;

namespace FOB
{
  
    [Activity(Label = "@string/app_name", Theme = "@style/Theme.AppCompat.Light.NoActionBar", MainLauncher = true)]
    public class SplashActivity : AppCompatActivity
    {
        protected  override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_splash);
           



            //string url = "https://hamrahpay.com/rest-api/pay-request";
            //using (var client = new System.Net.Http.HttpClient())

            //{

            //    var values = new Dictionary<string, string>()
            //        {
            //             {"sku","hp_5c8747e7b265a513593151"},
            //             {"device_id",System.DateTime.Now.ToString() },

            //        };
            //    var content = new FormUrlEncodedContent(values);
            //    var responseFromApi = client.PostAsync(url, content);
            //  responseFromApi.();
            // var responseJsonString = await responseFromApi.Content.ReadAsStringAsync();

            // }

        
          
            Task.Run(async () =>
            {
                await Task.Delay(800);

                RunOnUiThread(() =>
                {



                    var intent3 = new Intent(this, typeof(MainActivity));
                    StartActivity(intent3);
                    this.Finish();

                });
            });
        }
    }
}