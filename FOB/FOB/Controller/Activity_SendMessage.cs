using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace FOB.Controller
{
    [Activity(Label = "Activity_SendMessage", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class Activity_SendMessage : AppCompatActivity
    {
        /// <summary>
        /// پیام های ارسال شده
        /// </summary>
        /// <param name="savedInstanceState"></param>
        /// 
        TextView SendMessage_TxtView_Header;
        Button SendMessage_Button_Account;
        Button SendMessage_Button_Message;
        Button SendMessage_Button_Basket;
        Button SendMessage_Button_Home;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_sendmessage);
              SendMessage_TxtView_Header = FindViewById<TextView>(Resource.Id.SendMessage_TxtView_Header);
              SendMessage_Button_Account = FindViewById<Button>(Resource.Id.SendMessage_Button_Account);
            SendMessage_Button_Account.Click += delegate {
                //حساب
                Intent oi = new Intent(this, typeof(Account_Activity));
                StartActivity(oi);
            };

              SendMessage_Button_Message = FindViewById<Button>(Resource.Id.SendMessage_Button_Message);
            SendMessage_Button_Message.Click += delegate {

                //پیام
                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
              SendMessage_Button_Basket = FindViewById<Button>(Resource.Id.SendMessage_Button_Basket);
            SendMessage_Button_Basket.Click += delegate {
                //سبد
                Intent oi = new Intent(this, typeof(Basket_activity));
                StartActivity(oi);
            };
              SendMessage_Button_Home = FindViewById<Button>(Resource.Id.SendMessage_Button_Home);
            SendMessage_Button_Home.Click += delegate {

                //خانه
                Intent oi = new Intent(this, typeof(MainActivity));
                StartActivity(oi);
            };
            // Create your application here
        }
    }
}