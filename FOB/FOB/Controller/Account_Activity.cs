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
using FOB.Controller.Account;

namespace FOB.Controller
{
    [Activity(Label = "Account_Activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class Account_Activity : AppCompatActivity
    {
        TextView Account_TxtView_Header;
        Button Account_Button_Account;
        Button Account_Button_Message;
        Button Account_Button_Basket;
        Button Account_Button_Home;

        Button Account_Button_Help;
        Button Account_Button_Setting;
        Button Account_Button_MessageTwo;
        Button Account_Button_Userinformation;
        Button Account_Button_Payed;

        Button Account_Button_Exit;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_account);
            Account_Button_Payed = FindViewById<Button>(Resource.Id.Account_Button_Payed);
            Account_Button_Payed.Click += delegate {

                //پرداختی ها

                Intent oi= new Intent(this, typeof(PayedBank_Activity));
                StartActivity(oi);

            };
            Account_Button_Exit = FindViewById<Button>(Resource.Id.Account_Button_Exit);
            Account_Button_Exit.Click += delegate { Finish(); };

            Account_Button_Help = FindViewById<Button>(Resource.Id.Account_Button_Help);
            Account_Button_Help.Click += delegate {

                //راهنما

                Intent oi = new Intent(this, typeof(Help_Activity));
                StartActivity(oi);
            };
            FindViewById<Button>(Resource.Id.Account_Button_Password).Click += delegate {

                //تغییر رمز کاربری

                Intent oi = new Intent(this, typeof(Password_Activity));
                StartActivity(oi);

            };
             Account_Button_Setting = FindViewById<Button>(Resource.Id.Account_Button_Setting);
            Account_Button_Setting.Click += delegate {
                //تنظیمات

                Intent oi = new Intent(this, typeof(Setting_Activity));
                StartActivity(oi);
            };
             Account_Button_MessageTwo = FindViewById<Button>(Resource.Id.Account_Button_MessageTwo);
            Account_Button_MessageTwo.Click += delegate {
                //پیام

                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
             Account_Button_Userinformation = FindViewById<Button>(Resource.Id.Account_Button_Userinformation);
            Account_Button_Userinformation.Click += delegate {  
                //اضافه کردن کاربر

                Intent oi = new Intent(this, typeof(Add_Account));
                StartActivity(oi);
            };
            Account_TxtView_Header = FindViewById<TextView>(Resource.Id.Account_TxtView_Header);
            Account_Button_Account = FindViewById<Button>(Resource.Id.Account_Button_Account);
            Account_Button_Account.Click += delegate {
                //حساب

                Intent oi = new Intent(this, typeof(Account_Activity));
                StartActivity(oi);
            };
            Account_Button_Message = FindViewById<Button>(Resource.Id.Account_Button_Message);
            Account_Button_Message.Click += delegate {
                //پیام
                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
            Account_Button_Basket = FindViewById<Button>(Resource.Id.Account_Button_Basket);
            Account_Button_Basket.Click += delegate {
                //سبد خرید
                Intent oi = new Intent(this, typeof(Basket_activity));
                StartActivity(oi);
            };
            Account_Button_Home = FindViewById<Button>(Resource.Id.Account_Button_Home);
            Account_Button_Home.Click += delegate {

                //خانه
                Intent oi = new Intent(this, typeof(MainActivity));
                StartActivity(oi);
            };
        }
    }
}