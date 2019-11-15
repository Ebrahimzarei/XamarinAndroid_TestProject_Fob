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
    [Activity(Label = "SelectedLiver", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class SelectedLiver : AppCompatActivity
    {
        TextView SelectedLiver_TxtView_Header;
        Button SelectedLiver_Button_Account;
        Button SelectedLiver_Button_Message;
        Button SelectedLiver_Button_Basket;
        Button SelectedLiver_Button_Home;
        Button SelectedLiver_Button_LiverOne;
        Button SelectedLiver_Button_LiverTwo;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SelectedLiver_Activity);
              SelectedLiver_TxtView_Header = FindViewById<TextView>(Resource.Id.SelectedLiver_TxtView_Header); 
              SelectedLiver_Button_Account = FindViewById<Button>(Resource.Id.SelectedLiver_Button_Account);
            SelectedLiver_Button_Account.Click += delegate {

                 //حساب
                 Intent oi = new Intent(this, typeof(Account_Activity));
                 StartActivity(oi);

             };
              SelectedLiver_Button_Message = FindViewById<Button>(Resource.Id.SelectedLiver_Button_Message);
            SelectedLiver_Button_Message.Click += delegate {
                 //پیام
                 Intent oi = new Intent(this, typeof(Message_Activity));
                 StartActivity(oi);
             };
              SelectedLiver_Button_Basket = FindViewById<Button>(Resource.Id.SelectedLiver_Button_Basket);
            SelectedLiver_Button_Basket.Click += delegate {

                 //سبد خرید
                 Intent oi = new Intent(this, typeof(Basket_activity));
                 StartActivity(oi);
             };
              SelectedLiver_Button_Home = FindViewById<Button>(Resource.Id.SelectedLiver_Button_Home);
            SelectedLiver_Button_Home.Click += delegate {
                //خانه
                Intent oi = new Intent(this, typeof(MainActivity));
                StartActivity(oi);
            };
            SelectedLiver_Button_LiverOne = FindViewById<Button>(Resource.Id.SelectedLiver_Button_LiverOne);
            SelectedLiver_Button_LiverOne.Click += delegate {
                //جگرکی 1
                Intent oi = new Intent(this, typeof(Liver_Activity));
                StartActivity(oi);
            };
            SelectedLiver_Button_LiverTwo = FindViewById<Button>(Resource.Id.SelectedLiver_Button_LiverTwo);
            SelectedLiver_Button_LiverTwo.Click += delegate {
                //جگرکی 2
                Intent oi = new Intent(this, typeof(Liver_Activity));
                StartActivity(oi);
            };
            // Create your application here
        }
    }
}