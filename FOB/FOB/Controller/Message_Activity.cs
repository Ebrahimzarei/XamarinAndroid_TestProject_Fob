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
    [Activity(Label = "MessageActivity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class Message_Activity : AppCompatActivity
    {
        TextView Message_TxtView_Header;
        Button Message_Button_Account;
        Button Message_Button_Message;
        Button Message_Button_Basket;
        Button Message_Button_Home;
        Button Message_Button_ReciveMessage;
        Button Message_Button_SendMessage;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_message);
            Message_Button_ReciveMessage= FindViewById<Button>(Resource.Id.Message_Button_ReciveMessage);
            Message_Button_ReciveMessage.Click += delegate {
                //دریافتی
                Intent oi = new Intent(this, typeof(Activity_ReciveMessage));
                StartActivity(oi);
            };
            Message_Button_SendMessage = FindViewById<Button>(Resource.Id.Message_Button_SendMessage);
            Message_Button_SendMessage.Click += delegate {
                //ارسالی
                Intent oi = new Intent(this, typeof(Activity_SendMessage));
                StartActivity(oi);
            };

            Message_TxtView_Header =FindViewById<TextView>(Resource.Id.Message_TxtView_Header);
           Message_Button_Account = FindViewById<Button>(Resource.Id.Message_Button_Account);
            Message_Button_Account.Click += delegate {
                //حساب
                
                Intent oi = new Intent(this, typeof(Account_Activity));
                StartActivity(oi);
            };
            Message_Button_Message = FindViewById<Button>(Resource.Id.Message_Button_Message);
            Message_Button_Message.Click += delegate {
                //پیام
                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
            Message_Button_Basket = FindViewById<Button>(Resource.Id.Message_Button_Basket);
            Message_Button_Basket.Click += delegate {
                //سبد خرید
                Intent oi = new Intent(this, typeof(Basket_activity));
                StartActivity(oi);
            };
            Message_Button_Home = FindViewById<Button>(Resource.Id.Message_Button_Home);
            Message_Button_Home.Click += delegate {

                //خانه
                Intent oi = new Intent(this, typeof(MainActivity));
                StartActivity(oi);
            };
        }
    }
}