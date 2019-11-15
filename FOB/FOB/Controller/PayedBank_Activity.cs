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
using FOB.Controller.Colllection.Adapter;
using FOB.Model.Bank;

namespace FOB.Controller
{
    [Activity(Label = "PayedBank_Activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class PayedBank_Activity : AppCompatActivity
    {
        ListView PayedBank_Listview_LstPayedBank;
        Button PayedBank_Button_Home;
        Button PayedBank_Button_Basket;
        Button PayedBank_Button_Message;
        Button PayedBank_Button_Account;

        protected  async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_payedbank);

              PayedBank_Listview_LstPayedBank = FindViewById<ListView>(Resource.Id.PayedBank_Listview_LstPayedBank);
            Json_StatuseVerify Jsonverify;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://hamrahpay.com");
            DbFob dfob = new DbFob();
            StatuseVerify VerifyObj;
            dfob.ActivePayedGetAll().ToList().ForEach(async p =>
            {
              //var   values = new Dictionary<string, string>()
              //      {
              //           {"pay_code",p.Payed_Code.ToString()},


              //      };
              //  var content = new FormUrlEncodedContent(values);
              //  var responsemessage = await client.PostAsync("/rest-api/verify-payment", content);

              //  var x = responsemessage.Content.ReadAsStringAsync().Result;
              //  Jsonverify = new Json_StatuseVerify(x);
             
              //  VerifyObj = new StatuseVerify {

              //      DateTransaction = p.Date,
              //      MessagError = Jsonverify.message,
              //      StatusePayed= Jsonverify.status?? "SUCCESSFUL_PAYMENT"


              //  };
              //  dfob.StatuseVerifyInsert(VerifyObj);


            });








            var ListVeriFy = dfob.StatuseVerifyGetAll();
           


            PayedBank_Listview_LstPayedBank.Adapter = new PayedBank_Adapter(this, ListVeriFy);
              PayedBank_Button_Home = FindViewById<Button>(Resource.Id.PayedBank_Button_Home);
            PayedBank_Button_Home.Click += delegate {
                //خانه

                Intent oi = new Intent(this, typeof(MainActivity));
                StartActivity(oi);
            };
              PayedBank_Button_Basket = FindViewById<Button>(Resource.Id.PayedBank_Button_Basket);
            PayedBank_Button_Basket.Click += delegate {
                //سبد

                Intent oi = new Intent(this, typeof(Basket_activity));
                StartActivity(oi);
            };
            PayedBank_Button_Message = FindViewById<Button>(Resource.Id.PayedBank_Button_Message);
            PayedBank_Button_Message.Click += delegate {
                //پیام ها

                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
            PayedBank_Button_Account = FindViewById<Button>(Resource.Id.PayedBank_Button_Account);
            PayedBank_Button_Account.Click += delegate {

                //حساب

                Intent oi = new Intent(this, typeof(Account_Activity));
                StartActivity(oi);
            };



        }
    }
}