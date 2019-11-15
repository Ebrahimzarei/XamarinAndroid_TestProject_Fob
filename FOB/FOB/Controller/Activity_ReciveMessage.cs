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
    [Activity(Label = "Activity_ReciveMessage", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class Activity_ReciveMessage : AppCompatActivity
    {
        /// <summary>
        /// پیام های دریافت شده
        /// </summary>
        /// <param name="savedInstanceState"></param>
        /// 
        TextView ReciveMessage_TxtView_Header;
        Button ReciveMessage_Button_Account;
        Button ReciveMessage_Button_Message;
        Button ReciveMessage_Button_Basket;
        Button ReciveMessage_Button_Home;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_reciveMessage);
              ReciveMessage_TxtView_Header = FindViewById<TextView>(Resource.Id.ReciveMessage_TxtView_Header);
              ReciveMessage_Button_Account = FindViewById<Button>(Resource.Id.ReciveMessage_Button_Account);
            ReciveMessage_Button_Account.Click += delegate {   
                //حساب
                Intent oi = new Intent(this, typeof(Account_Activity));
                StartActivity(oi);
            };
              ReciveMessage_Button_Message = FindViewById<Button>(Resource.Id.ReciveMessage_Button_Message);
            ReciveMessage_Button_Message.Click += delegate {
                //پیام
                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
              ReciveMessage_Button_Basket = FindViewById<Button>(Resource.Id.ReciveMessage_Button_Basket);
            ReciveMessage_Button_Basket.Click += delegate {
                //سبد
                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
              ReciveMessage_Button_Home = FindViewById<Button>(Resource.Id.ReciveMessage_Button_Home);
            ReciveMessage_Button_Home.Click += delegate {
                //خانه
                Intent oi = new Intent(this, typeof(MainActivity));
                StartActivity(oi);

            };
        }
    }
}