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
    [Activity(Label = "HelpQuestion_Activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class HelpQuestion_Activity : AppCompatActivity
    {
        TextView HelpQuestion_TxtView_Header;
        Button HelpQuestion_Button_Account;
        Button HelpQuestion_Button_Message;
        Button HelpQuestion_Button_Basket;
        Button HelpQuestion_Button_Home;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_helpquestion);
            HelpQuestion_TxtView_Header = FindViewById<TextView>(Resource.Id.HelpQuestion_TxtView_Header);
            HelpQuestion_Button_Account = FindViewById<Button>(Resource.Id.HelpQuestion_Button_Account);
            HelpQuestion_Button_Account.Click += delegate
            {
                //حساب
                Intent oi = new Intent(this, typeof(Account_Activity));
                StartActivity(oi);
            };
            HelpQuestion_Button_Message = FindViewById<Button>(Resource.Id.HelpQuestion_Button_Message);
            HelpQuestion_Button_Message.Click += delegate
            { //پیام
                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
            HelpQuestion_Button_Basket = FindViewById<Button>(Resource.Id.HelpQuestion_Button_Basket);
            HelpQuestion_Button_Basket.Click += delegate
            { //سبد
                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
            HelpQuestion_Button_Home = FindViewById<Button>(Resource.Id.HelpQuestion_Button_Home);
            HelpQuestion_Button_Home.Click += delegate
            { //خانه
                Intent oi = new Intent(this, typeof(MainActivity));
                StartActivity(oi);
            };
        }
    }
}