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
    [Activity(Label = "Help_Activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class Help_Activity : AppCompatActivity
    {
      //  TextView Help_TxtView_Header;
        Button Help_Button_Setting;
        Button Help_Button_Message;
        Button Help_Button_Basket;
        Button Help_Button_Home;

        Button Help_Button_Question;
        Button Help_Button_Learn;
        Button Help_Button_AboutFoB;
        Button Help_Button_SocialNetwork;

         
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_help);
           
              Help_Button_Setting = FindViewById<Button>(Resource.Id.HelpLearn_Button_Account);
              Help_Button_Setting.Click += delegate {      
                //حساب

                Intent oi = new Intent(this, typeof(Account_Activity));
                StartActivity(oi);
            };
              Help_Button_Message = FindViewById<Button>(Resource.Id.Help_Button_Message);
              Help_Button_Message.Click += delegate {
                //پیام

                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
              Help_Button_Basket = FindViewById<Button>(Resource.Id.Help_Button_Basket);
              Help_Button_Basket.Click += delegate {
                //سبد

                Intent oi = new Intent(this, typeof(Basket_activity));
                StartActivity(oi);
            };
              Help_Button_Home = FindViewById<Button>(Resource.Id.Help_Button_Home);
              Help_Button_Home.Click += delegate {      //خانه

                Intent oi = new Intent(this, typeof(MainActivity));
                StartActivity(oi);
            };
              Help_Button_Question = FindViewById<Button>(Resource.Id.Help_Button_Question);
            Help_Button_Question.Click += delegate {
                //سوالات متداول
                Intent oi = new Intent(this, typeof(HelpQuestion_Activity));
                StartActivity(oi);
            };
              Help_Button_Learn = FindViewById<Button>(Resource.Id.Help_Button_Learn);
            Help_Button_Learn.Click += delegate {
                //آموزش
                Intent oi = new Intent(this, typeof(HelpLearn_Activity));
                StartActivity(oi);
            };
              Help_Button_AboutFoB = FindViewById<Button>(Resource.Id.Help_Button_AboutFoB);
            Help_Button_AboutFoB.Click += delegate {
                //درباره فوب
                Intent oi = new Intent(this, typeof(AboutFob_Activity));
                StartActivity(oi);
            };
              Help_Button_SocialNetwork = FindViewById<Button>(Resource.Id.Help_Button_SocialNetwork);
            Help_Button_SocialNetwork.Click += delegate {
                //راه های ارتباطی
                Intent oi = new Intent(this, typeof(SocialNetwork_Activity));
                StartActivity(oi);
            };

        }
    }
}