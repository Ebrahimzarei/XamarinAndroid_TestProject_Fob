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
    [Activity(Label = "SelectedAlas_Activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class SelectedAlas_Activity : AppCompatActivity
    {

       TextView SelectedAlas_TxtView_Header;
        Button SelectedAlas_Button_Account;
        Button SelectedAlas_Button_Message;
        Button SelectedAlas_Button_Basket;
        Button SelectedAlas_Button_Home;
        Button SelectedAlas_Button_AlasOne;
        Button SelectedAlas_Button_AlasTwo;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SelectedAlas_Activity);
            SelectedAlas_TxtView_Header = FindViewById<TextView>(Resource.Id.SelectedAlas_TxtView_Header);
              SelectedAlas_Button_Account = FindViewById<Button>(Resource.Id.SelectedAlas_Button_Account);
            SelectedAlas_Button_Account.Click += delegate {

                 //حساب
                 Intent oi = new Intent(this, typeof(Account_Activity));
                 StartActivity(oi);

             };
              SelectedAlas_Button_Message = FindViewById<Button>(Resource.Id.SelectedAlas_Button_Message);
            SelectedAlas_Button_Message.Click += delegate {
                 //پیام
                 Intent oi = new Intent(this, typeof(Message_Activity));
                 StartActivity(oi);
             };
              SelectedAlas_Button_Basket = FindViewById<Button>(Resource.Id.SelectedAlas_Button_Basket);
            SelectedAlas_Button_Basket.Click += delegate {

                 //سبد خرید
                 Intent oi = new Intent(this, typeof(Basket_activity));
                 StartActivity(oi);
             };
              SelectedAlas_Button_Home = FindViewById<Button>(Resource.Id.SelectedAlas_Button_Home);
            SelectedAlas_Button_Home.Click += delegate {
                 //خانه
                 Intent oi = new Intent(this, typeof(MainActivity));
                 StartActivity(oi);
             };
       
              SelectedAlas_Button_AlasOne = FindViewById<Button>(Resource.Id.SelectedAlas_Button_AlasOne);
            SelectedAlas_Button_AlasOne.Click += delegate {
                 // آشی 1
                 Intent oi = new Intent(this, typeof(Alas_Activity));
                 StartActivity(oi);
             };
              SelectedAlas_Button_AlasTwo = FindViewById<Button>(Resource.Id.SelectedAlas_Button_AlasTwo);
            SelectedAlas_Button_AlasTwo.Click += delegate {
                 //آش 2
                 Intent oi = new Intent(this, typeof(Alas_Activity));
                 StartActivity(oi);
             };
            // Create your application here
        }
    }
}