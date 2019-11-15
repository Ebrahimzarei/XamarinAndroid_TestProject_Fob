using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using FOB.Model.Bank;
using Newtonsoft.Json.Linq;

namespace FOB.Controller
{
    [Activity(Label = "Payed_Activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class Payed_Activity : AppCompatActivity
    {
        TextView Payed_TxtView_Header;
        Button Payed_Button_Account;
        Button Payed_Button_Message;
        Button Payed_Button_Basket;
        Button Payed_Button_Home;
        HttpClient client;
        statuse st;
        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Activity_Payed);
            Payed_TxtView_Header = FindViewById<TextView>(Resource.Id.Payed_TxtView_Header); ;
            Payed_Button_Account = FindViewById<Button>(Resource.Id.Payed_Button_Account);
            Payed_Button_Account.Click += delegate
            {
                //حساب
                Intent oi = new Intent(this, typeof(Account_Activity));
                StartActivity(oi);

            };
            Payed_Button_Message = FindViewById<Button>(Resource.Id.Payed_Button_Message);
            Payed_Button_Message.Click += delegate
            {
                //پیام
                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
            Payed_Button_Basket = FindViewById<Button>(Resource.Id.Payed_Button_Basket);
            Payed_Button_Basket.Click += delegate
            {
                //سبد
                Intent oi = new Intent(this, typeof(Basket_activity));
                StartActivity(oi);
            };
            Payed_Button_Home = FindViewById<Button>(Resource.Id.Payed_Button_Home);
            Payed_Button_Home.Click += delegate
            {

                //خانه
                Intent oi = new Intent(this, typeof(MainActivity));
                StartActivity(oi);
            };


              client = new HttpClient();
              client.BaseAddress = new Uri("https://hamrahpay.com");
              var values = new Dictionary<string, string>()
                    {
                         {"sku","hp_5c8747e7b265a513593151"},
                         //
                         {"device_id",System.DateTime.Now.ToString() },

                    };
            var content = new FormUrlEncodedContent(values);

            var responsemessage = await client.PostAsync("/rest-api/pay-request", content);
            var x = responsemessage.Content.ReadAsStringAsync().Result;
              st = new statuse(x);
            
            ActivePayedCode str = new ActivePayedCode
            {
             Payed_Code=st.pay_code,
             Date=Utils.Utils.PersianDate(DateTime.Now)
            };
            DbFob db = new DbFob();
           int id= db.ActivePayedInsert(str);


            string url2 = $"https://hamrahpay.com/cart/app/pay/{st.pay_code}";
            var uri = Android.Net.Uri.Parse(url2);
            var intent = new Intent(Intent.ActionView, uri);
          StartActivity(intent);
         //   StartActivityForResult(intent, 50);

         
        }
      
     
    }
    public class statuse
    {
        public statuse(string json)
        {
            JObject jObject = JObject.Parse(json);
            //JToken jUser = jObject["statuse"];
            error = (bool)jObject["error"];
            status = (string)jObject["status"];
            date = (string)jObject["date"];
            prd_status = (string)jObject["prd_status"];
            pay_code = (string)jObject["pay_code"];
            prd_type = (string)jObject["prd_type"];

        }

        public bool? error { get; set; }
        public string status { get; set; }
        public string pay_code { get; set; }
        public string date { get; set; }
        public string prd_status { get; set; }
        public string prd_type { get; set; }



    }
}