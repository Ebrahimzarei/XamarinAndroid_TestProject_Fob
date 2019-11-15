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
    /// <summary>
    /// انتخاب قنادی
    /// </summary>
    [Activity(Label = "SelectedTwoConf", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class SelectedTwoConf : AppCompatActivity
    {
        TextView SelectedTwoConfectionart_TxtView_Header;
        Button SelectedTwoConfectionart_Button_Account;
        Button SelectedTwoConfectionart_Button_Message;
        Button SelectedTwoConfectionart_Button_Basket;
        Button SelectedTwoConfectionart_Button_Home;

        Button SelectedTwoConfectionart_Button_ConfOne;
        Button SelectedTwoConfectionart_Button_ConfTwo;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SelectedTwoConfectionary);
              SelectedTwoConfectionart_TxtView_Header = FindViewById<TextView>(Resource.Id.SelectedTwoConfectionart_TxtView_Header);
              SelectedTwoConfectionart_Button_Account = FindViewById<Button>(Resource.Id.SelectedTwoConfectionart_Button_Account);
            SelectedTwoConfectionart_Button_Account.Click += delegate {

                 //حساب
                 Intent oi = new Intent(this, typeof(Account_Activity));
                 StartActivity(oi);
             };
              SelectedTwoConfectionart_Button_Message = FindViewById<Button>(Resource.Id.SelectedTwoConfectionart_Button_Message);
            SelectedTwoConfectionart_Button_Message.Click += delegate {

                //پیام
                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
              SelectedTwoConfectionart_Button_Basket = FindViewById<Button>(Resource.Id.SelectedTwoConfectionart_Button_Basket);
            SelectedTwoConfectionart_Button_Basket.Click += delegate {

                 //سبد خرید
                 Intent oi = new Intent(this, typeof(Basket_activity));
                 StartActivity(oi);
             };
              SelectedTwoConfectionart_Button_Home = FindViewById<Button>(Resource.Id.SelectedTwoConfectionart_Button_Home);
            SelectedTwoConfectionart_Button_Home.Click += delegate {

                 //خانه
                 Intent oi = new Intent(this, typeof(MainActivity));
                 StartActivity(oi);
             };

              SelectedTwoConfectionart_Button_ConfOne = FindViewById<Button>(Resource.Id.SelectedTwoConfectionart_Button_ConfOne);
            SelectedTwoConfectionart_Button_ConfOne.Click += delegate {


                //قنادی 1
                Intent oi = new Intent(this, typeof(ConFectionary_Activity));
                StartActivity(oi);

            };
              SelectedTwoConfectionart_Button_ConfTwo = FindViewById<Button>(Resource.Id.SelectedTwoConfectionart_Button_ConfTwo);
            SelectedTwoConfectionart_Button_ConfTwo.Click += delegate {

                //قنادی 2
                Intent oi = new Intent(this, typeof(ConFectionary_Activity));
                StartActivity(oi);
            };

            // Create your application here
        }
    }
}