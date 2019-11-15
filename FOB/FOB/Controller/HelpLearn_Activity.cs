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
    [Activity(Label = "HelpLearn_Activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class HelpLearn_Activity : AppCompatActivity
    {
        TextView HelpLearn_TxtView_Header;
        Button HelpLearn_Button_Account;
        Button HelpLearn_Button_Message;
        Button HelpLearn_Button_Basket;
        Button HelpLearn_Button_Home;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_helplearn);
            HelpLearn_TxtView_Header = FindViewById<TextView>(Resource.Id.HelpLearn_TxtView_Header);
            HelpLearn_Button_Account = FindViewById<Button>(Resource.Id.HelpLearn_Button_Account);
            HelpLearn_Button_Account.Click += delegate
            {
                //حساب
                Intent oi = new Intent(this, typeof(Account_Activity));
                StartActivity(oi);
            };
            HelpLearn_Button_Message = FindViewById<Button>(Resource.Id.HelpLearn_Button_Message);
            HelpLearn_Button_Message.Click += delegate
            { //پیام
                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
            HelpLearn_Button_Basket = FindViewById<Button>(Resource.Id.HelpLearn_Button_Basket);
            HelpLearn_Button_Basket.Click += delegate
            { //سبد
                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
            HelpLearn_Button_Home = FindViewById<Button>(Resource.Id.HelpLearn_Button_Home);
            HelpLearn_Button_Home.Click += delegate
            { //خانه
                Intent oi = new Intent(this, typeof(MainActivity));
                StartActivity(oi);
            };
            // Create your application here
        }
    }
}