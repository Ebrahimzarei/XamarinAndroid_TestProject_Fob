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
    [Activity(Label = "Password_Activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class Password_Activity : AppCompatActivity
    {
       // TextView Message_TxtView_Header;
     
        Button Password_Button_Account;
        Button Password_Button_Messages;
        Button Password_Button_Basket;
        Button Password_Button_Home;

        TextView AddActivityPassword_TextView_OldPass;
        EditText AddActivityPassword_EditText_OldPass;
        TextView AddActivityPassword_TextView_NewPass;
        EditText AddActivityPassword_EditText_NewPass;
        TextView AddActivityPassword_TextView_RetryPass;
        EditText AddActivityPassword_EditText_RetryPass;

        Button AddActivityPassword_Button_Save;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_password);

            AddActivityPassword_Button_Save = FindViewById<Button>(Resource.Id.AddActivityPassword_Button_Save);
            AddActivityPassword_Button_Save.Click += delegate {

               //ذخیره
            };
             Password_Button_Account =FindViewById<Button>(Resource.Id.Password_Button_Account);
            Password_Button_Account.Click += delegate {

                 //حساب

                Intent oi = new Intent(this, typeof(Account_Activity
                    ));
                 StartActivity(oi);
             };
              Password_Button_Messages = FindViewById<Button>(Resource.Id.Password_Button_Messages);
            Password_Button_Messages.Click += delegate {

                //پیام

                Intent oi = new Intent(this, typeof(Message_Activity));
                 StartActivity(oi);
             };
              Password_Button_Basket = FindViewById<Button>(Resource.Id.Password_Button_Basket);
            Password_Button_Basket.Click += delegate {

                //سبد

               Intent oi = new Intent(this, typeof(Basket_activity));
                 StartActivity(oi);
             };
              Password_Button_Home = FindViewById<Button>(Resource.Id.Password_Button_Home);
             Password_Button_Home.Click += delegate {

                 //خانه

                Intent oi = new Intent(this, typeof(MainActivity));
                 StartActivity(oi);
             };

             AddActivityPassword_TextView_OldPass = FindViewById<TextView>(Resource.Id.AddActivityPassword_TextView_OldPass);
             AddActivityPassword_EditText_OldPass = FindViewById<EditText>(Resource.Id.AddActivityPassword_EditText_OldPass);
             AddActivityPassword_TextView_NewPass = FindViewById<TextView>(Resource.Id.AddActivityPassword_TextView_NewPass);
             AddActivityPassword_EditText_NewPass = FindViewById<EditText > (Resource.Id.AddActivityPassword_EditText_NewPass);
             AddActivityPassword_TextView_RetryPass = FindViewById<TextView>(Resource.Id.AddActivityPassword_TextView_RetryPass);
             AddActivityPassword_EditText_RetryPass = FindViewById<EditText>(Resource.Id.AddActivityPassword_EditText_RetryPass);
            // Create your application here
        }
    }
}