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
    /// نوشیدنی ایرانی
    /// </summary>
    [Activity(Label = "IranianDrink_Activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class IranianDrink_Activity : AppCompatActivity
    {
        TextView Irandrink_TxtView_Header;
        Button Irandrink_Button_Account;
        Button Irandrink_Button_Message;
        Button Irandrink_Button_Basket;
        Button Irandrink_Button_Home;

        Button Irandrink_Button_TraditionalDrink;
        Button Irandrink_Button_NewDrink;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_iraniandrink);
              Irandrink_TxtView_Header = FindViewById<TextView>(Resource.Id.SelectDrink_TxtView_Header);
              Irandrink_Button_Account = FindViewById<Button>(Resource.Id.Irandrink_Button_Account);
            Irandrink_Button_Account.Click += delegate {

                //حساب
                Intent oi = new Intent(this, typeof(Account_Activity));
                StartActivity(oi);
            };
              Irandrink_Button_Message = FindViewById<Button>(Resource.Id.Irandrink_Button_Message);
            Irandrink_Button_Message.Click += delegate {
                //پیام
                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
              Irandrink_Button_Basket = FindViewById<Button>(Resource.Id.Irandrink_Button_Basket);
            Irandrink_Button_Basket.Click += delegate {
                //سبد
                Intent oi = new Intent(this, typeof(Basket_activity));
                StartActivity(oi);
            };
              Irandrink_Button_Home = FindViewById<Button>(Resource.Id.Irandrink_Button_Home);
            Irandrink_Button_Home.Click += delegate {

                //خانه
                Intent oi = new Intent(this, typeof(MainActivity));
                StartActivity(oi);
            };

              Irandrink_Button_TraditionalDrink = FindViewById<Button>(Resource.Id.Irandrink_Button_TraditionalDrink);
            Irandrink_Button_TraditionalDrink.Click += delegate {
                //سنتی
                Intent oi = new Intent(this, typeof(TradionalIranDrink_Activity));
                StartActivity(oi);

            };
              Irandrink_Button_NewDrink = FindViewById<Button>(Resource.Id.Irandrink_Button_NewDrink);
            Irandrink_Button_NewDrink.Click += delegate {

                //جدید
                Intent oi = new Intent(this, typeof(SelectNewCoffeShop_Activity));
                StartActivity(oi);
            };
        }
    }
}