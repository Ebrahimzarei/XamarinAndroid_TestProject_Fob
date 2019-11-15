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
    [Activity(Label = "SelectTwoBread_Activity")]
    public class SelectTwoBread_Activity : AppCompatActivity
    {
        TextView SelectedTwoBread_TxtView_Header;
        Button SelectedTwoBread_Button_Account;
        Button SelectedTwoBread_Button_Message;
        Button SelectedTwoBread_Button_Basket;
        Button SelectedTwoBread_Button_Home;

        Button SelectedTwoBread_Button_BreadOne;
        Button SelectedTwoBread_Button_BreadTwo;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SelectedTwoBread);
              SelectedTwoBread_TxtView_Header = FindViewById<TextView>(Resource.Id.Alas_TxtView_Header);
              SelectedTwoBread_Button_Account = FindViewById<Button>(Resource.Id.SelectedTwoBread_Button_Account);
            SelectedTwoBread_Button_Account.Click += delegate {

                 //خانه
                 Intent oi = new Intent(this, typeof(SelectTwoBread_Activity));
                 StartActivity(oi);
             };
            SelectedTwoBread_Button_Message = FindViewById<Button>(Resource.Id.SelectedTwoBread_Button_Message);
            SelectedTwoBread_Button_Message.Click += delegate {

                 //یپام
                 Intent oi = new Intent(this, typeof(Message_Activity));
                 StartActivity(oi);
             };
            SelectedTwoBread_Button_Basket = FindViewById<Button>(Resource.Id.SelectedTwoBread_Button_Basket);
            SelectedTwoBread_Button_Basket.Click += delegate {

                 //سبد
                 Intent oi = new Intent(this, typeof(Basket_activity));
                 StartActivity(oi);
             };
            SelectedTwoBread_Button_Home = FindViewById<Button>(Resource.Id.SelectedTwoBread_Button_Home);
            SelectedTwoBread_Button_Home.Click += delegate {

                 //خانه
                 Intent oi = new Intent(this, typeof(MainActivity));
                 StartActivity(oi);
             };

            SelectedTwoBread_Button_BreadOne = FindViewById<Button>(Resource.Id.SelectedTwoBread_Button_BreadOne);
            SelectedTwoBread_Button_BreadOne.Click += delegate {

                 //نان 1
                 Intent oi = new Intent(this, typeof(Bread_Activity));
                 StartActivity(oi);
             };
            SelectedTwoBread_Button_BreadTwo = FindViewById<Button>(Resource.Id.SelectedTwoBread_Button_BreadTwo);
            SelectedTwoBread_Button_BreadTwo.Click += delegate {

                 //نان 2
                 Intent oi = new Intent(this, typeof(Bread_Activity));
                 StartActivity(oi);
             };

            // Create your application here
        }
    }
}