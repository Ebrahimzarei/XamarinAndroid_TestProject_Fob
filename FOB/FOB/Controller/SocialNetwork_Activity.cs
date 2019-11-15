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
    [Activity(Label = "SocialNetwork_Activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class SocialNetwork_Activity : AppCompatActivity
    {
        TextView SocialNetwork_TxtView_Header;
        Button SocialNetwork_Button_Account;
        Button SocialNetwork_Button_Message;
        Button SocialNetwork_Button_Basket;
        Button SocialNetwork_Button_Home;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_socialnetwork);
            SocialNetwork_TxtView_Header = FindViewById<TextView>(Resource.Id.SocialNetwork_TxtView_Header);
            SocialNetwork_Button_Account = FindViewById<Button>(Resource.Id.SocialNetwork_Button_Account);
            SocialNetwork_Button_Account.Click += delegate
            {
                //حساب
                Intent oi = new Intent(this, typeof(Account_Activity));
                StartActivity(oi);
            };
            SocialNetwork_Button_Message = FindViewById<Button>(Resource.Id.SocialNetwork_Button_Message);
            SocialNetwork_Button_Message.Click += delegate
            { //پیام
                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
            SocialNetwork_Button_Basket = FindViewById<Button>(Resource.Id.SocialNetwork_Button_Basket);
            SocialNetwork_Button_Basket.Click += delegate
            { //سبد
                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
            SocialNetwork_Button_Home = FindViewById<Button>(Resource.Id.SocialNetwork_Button_Home);
            SocialNetwork_Button_Home.Click += delegate
            { //خانه
                Intent oi = new Intent(this, typeof(MainActivity));
                StartActivity(oi);
            };
        }
    }
}