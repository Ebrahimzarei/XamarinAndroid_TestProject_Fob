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
    [Activity(Label = "AboutFob_Activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class AboutFob_Activity : AppCompatActivity
    {
        TextView AboutFob_TxtView_Header;
        Button AboutFob_Button_Account;
        Button AboutFob_Button_Message;
        Button AboutFob_Button_Basket;
        Button AboutFob_Button_Home;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_aboutfob);
            AboutFob_TxtView_Header = FindViewById<TextView>(Resource.Id.AboutFob_TxtView_Header);

            AboutFob_Button_Account = FindViewById<Button>(Resource.Id.AboutFob_Button_Account);
            AboutFob_Button_Account.Click += delegate
            {
                //حساب
                Intent oi = new Intent(this, typeof(Account_Activity));
                StartActivity(oi);
            };
            AboutFob_Button_Message = FindViewById<Button>(Resource.Id.AboutFob_Button_Message);
            AboutFob_Button_Message.Click += delegate
            {
                //پیام
                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
            AboutFob_Button_Basket = FindViewById<Button>(Resource.Id.AboutFob_Button_Basket);
            AboutFob_Button_Basket.Click += delegate
            {
                //سبد
                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
            AboutFob_Button_Home = FindViewById<Button>(Resource.Id.AboutFob_Button_Home);
            AboutFob_Button_Home.Click += delegate
            {
                //پیام
                Intent oi = new Intent(this, typeof(MainActivity));
                StartActivity(oi);

            };




        }
    }
}