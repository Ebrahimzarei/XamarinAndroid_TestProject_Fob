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

namespace FOB.Controller.Account
{
    [Activity(Label = "Setting_Activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class Setting_Activity : AppCompatActivity
    {
        TextView Setting_TxtView_Header;
        Button Setting_Button_Account;
        Button Setting_Button_Message;
        Button Setting_Button_Basket;
        Button Setting_Button_Home;

        Button Setting_Button_Language;
        Button Setting_Button_Update;
        Button Setting_Button_BackUp;
        Button Setting_Button_Recovery;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_setting);
              Setting_TxtView_Header=FindViewById<TextView>(Resource.Id.Setting_TxtView_Header);
            Setting_Button_Account = FindViewById<Button>(Resource.Id.Setting_Button_Account);
            Setting_Button_Account.Click += delegate {
                //پیام
                Intent oi = new Intent(this, typeof(Account_Activity));
                StartActivity(oi);
            };
             Setting_Button_Message = FindViewById<Button>(Resource.Id.Setting_Button_Message);
            Setting_Button_Message.Click += delegate {
                //پیام
                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
              Setting_Button_Basket = FindViewById<Button>(Resource.Id.Setting_Button_Basket);
            Setting_Button_Basket.Click += delegate {
                //سبد
                Intent oi = new Intent(this, typeof(Basket_activity));
                StartActivity(oi);
            };
              Setting_Button_Home = FindViewById<Button>(Resource.Id.Setting_Button_Home);
            Setting_Button_Home.Click += delegate {

                //خانه
                Intent oi = new Intent(this, typeof(MainActivity));
                StartActivity(oi);
            };


              Setting_Button_Language=Setting_Button_Home = FindViewById<Button>(Resource.Id.Setting_Button_Language);
            Setting_Button_Language.Click += delegate {
//زبان

            };
              Setting_Button_Update =Setting_Button_Home = FindViewById<Button>(Resource.Id.Setting_Button_Update);
            Setting_Button_Update.Click += delegate {
                //بروز رسانی

            };
              Setting_Button_BackUp= Setting_Button_Home = FindViewById<Button>(Resource.Id.Setting_Button_BackUp);
            Setting_Button_BackUp.Click += delegate {
                //پشتیبان گیری
            };
              Setting_Button_Recovery= Setting_Button_Home = FindViewById<Button>(Resource.Id.Setting_Button_Recovery);
            Setting_Button_Recovery.Click += delegate {

                //بروز رسانی
            };

        }
    }
}