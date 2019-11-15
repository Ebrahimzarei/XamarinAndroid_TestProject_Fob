using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace FOB.Controller.Colllection
{
    /// <summary>
    /// انتخاب نون
    /// </summary>
    [Activity(Label = "SelectedBread_Activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class SelectedBread_Activity : Android.Support.V7.App.AppCompatActivity
    {
        TextView SelectedBread_TxtView_Header;
        Button SelectedBread_Button_Account;
        Button SelectedBread_Button_Message;
        Button SelectedBread_Button_Basket;
        Button SelectedBread_Button_Home;

        Button SelectedBread_Button_BreadNational;
        Button SelectedBread_Button_BreadForeign;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SelectedBread);
              SelectedBread_TxtView_Header = FindViewById<TextView>(Resource.Id.SelectedBread_TxtView_Header);

            SelectedBread_Button_Account = FindViewById<Button>(Resource.Id.SelectedBread_Button_Account);
            SelectedBread_Button_Account.Click += delegate {

                 //حساب
                 Intent oi = new Intent(this, typeof(Account_Activity));
                 StartActivity(oi);
             };
              SelectedBread_Button_Message = FindViewById<Button>(Resource.Id.SelectedBread_Button_Message);
            SelectedBread_Button_Message.Click += delegate {

                 //پیام
                 Intent oi = new Intent(this, typeof(Message_Activity));
                 StartActivity(oi);
             };
              SelectedBread_Button_Basket = FindViewById<Button>(Resource.Id.SelectedBread_Button_Basket);
            SelectedBread_Button_Basket.Click += delegate {
                 //سبد
                 Intent oi = new Intent(this, typeof(Basket_activity));
                 StartActivity(oi);
             };
              SelectedBread_Button_Home = FindViewById<Button>(Resource.Id.SelectedBread_Button_Home);
            SelectedBread_Button_Home.Click += delegate {

                 //خانه
                 Intent oi = new Intent(this, typeof(MainActivity));
                 StartActivity(oi);
             };

              SelectedBread_Button_BreadNational = FindViewById<Button>(Resource.Id.SelectedBread_Button_BreadNational);
            SelectedBread_Button_BreadNational.Click += delegate {

                 //خانه
                 Intent oi = new Intent(this, typeof(SelectTwoBread_Activity));
                 StartActivity(oi);
             };
              SelectedBread_Button_BreadForeign = FindViewById<Button>(Resource.Id.SelectedBread_Button_BreadForeign);
            SelectedBread_Button_BreadForeign.Click += delegate {

                 //خانه
                 Intent oi = new Intent(this, typeof(SelectTwoBread_Activity));
                 StartActivity(oi);
             };
            // Create your application here
        }
    }
}