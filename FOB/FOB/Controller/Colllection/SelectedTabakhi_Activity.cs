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

namespace FOB.Controller.Colllection
{
    [Activity(Label = "SelectedTabakhi_Activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class SelectedTabakhi_Activity : AppCompatActivity
    {
        TextView SelectedTabakhi_TxtView_Header;

        Button SelectedTabakhi_Button_Account;
        Button SelectedTabakhi_Button_Message;
        Button SelectedTabakhi_Button_Basket;
        Button SelectedTabakhi_Button_Home;

        Button SelectedTabakhi_Button_TabakhiOne;
        Button SelectedTabakhi_Button_TabakhiTwo;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_selectedtabakhi);
              SelectedTabakhi_TxtView_Header = FindViewById<TextView>(Resource.Id.SelectedTabakhi_TxtView_Header);

              SelectedTabakhi_Button_Account = FindViewById<Button>(Resource.Id.SelectedTabakhi_Button_Account);
            SelectedTabakhi_Button_Account.Click += delegate {

                 //حساب
                 Intent oi = new Intent(this, typeof(Account_Activity));
                 StartActivity(oi);

             };
            SelectedTabakhi_Button_Message = FindViewById<Button>(Resource.Id.SelectedTabakhi_Button_Message);
            SelectedTabakhi_Button_Message.Click += delegate {
                 //پیام
                 Intent oi = new Intent(this, typeof(Message_Activity));
                 StartActivity(oi);
             };
            SelectedTabakhi_Button_Basket = FindViewById<Button>(Resource.Id.SelectedTabakhi_Button_Basket);
            SelectedTabakhi_Button_Basket.Click += delegate {

                 //سبد خرید
                 Intent oi = new Intent(this, typeof(Basket_activity));
                 StartActivity(oi);
             };
            SelectedTabakhi_Button_Home = FindViewById<Button>(Resource.Id.SelectedTabakhi_Button_Home);
            SelectedTabakhi_Button_Home.Click += delegate {
                 //خانه
                 Intent oi = new Intent(this, typeof(MainActivity));
                 StartActivity(oi);
             };
            SelectedTabakhi_Button_TabakhiOne = FindViewById<Button>(Resource.Id.SelectedTabakhi_Button_TabakhiOne);
            SelectedTabakhi_Button_TabakhiOne.Click += delegate {
                 //طباخی1
                 Intent oi = new Intent(this, typeof(Tabakhi_Activity));
                 StartActivity(oi);
             };
            SelectedTabakhi_Button_TabakhiTwo = FindViewById<Button>(Resource.Id.SelectedTabakhi_Button_TabakhiTwo);
            SelectedTabakhi_Button_TabakhiTwo.Click += delegate {
                 //طباخی2
                 Intent oi = new Intent(this, typeof(Tabakhi_Activity));
                 StartActivity(oi);
             };
            // Create your application here
        }
    }
}