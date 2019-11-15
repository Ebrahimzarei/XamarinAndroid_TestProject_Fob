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
    /// انتخاب کافی شاپ
    /// </summary>
    [Activity(Label = "SelectNewCoffeShop_Activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class SelectNewCoffeShop_Activity : AppCompatActivity
    {
        TextView NewCoofeShop_TxtView_Header;
        Button NewCoofeShop_Button_Account;
        Button NewCoofeShop_Button_Message;
        Button NewCoofeShop_Button_Basket;
        Button NewCoofeShop_Button_Home;


        Button NewCoofeShop_Button_CoffeOne;
        Button NewCoofeShop_Button_CoffeTwo;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_selectNewcoffeShop);
            //  = FindViewById<TextView>(Resource.Id.TraditionalIranDrink_TxtView_Header);
              NewCoofeShop_TxtView_Header = FindViewById<TextView>(Resource.Id.TraditionalIranDrink_TxtView_Header);
              NewCoofeShop_Button_Account = FindViewById<Button>(Resource.Id.NewCoofeShop_Button_Account);
            NewCoofeShop_Button_Account.Click += delegate {
                //حساب
                Intent oi = new Intent(this, typeof(Account_Activity));
                StartActivity(oi);

            };
              NewCoofeShop_Button_Message = FindViewById<Button>(Resource.Id.NewCoofeShop_Button_Message);
            NewCoofeShop_Button_Message.Click += delegate {
                //پیام
                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
            NewCoofeShop_Button_Basket = FindViewById<Button>(Resource.Id.NewCoofeShop_Button_Basket);
            NewCoofeShop_Button_Basket.Click += delegate {

                //سبد
                Intent oi = new Intent(this, typeof(Basket_activity));
                StartActivity(oi);
            };
            NewCoofeShop_Button_Home = FindViewById<Button>(Resource.Id.NewCoofeShop_Button_Home);
            NewCoofeShop_Button_Home.Click += delegate {

                //خانه
                Intent oi = new Intent(this, typeof(MainActivity));
                StartActivity(oi);
            };

            NewCoofeShop_Button_CoffeOne = FindViewById<Button>(Resource.Id.NewCoofeShop_Button_CoffeOne);
            NewCoofeShop_Button_CoffeOne.Click += delegate {

                //کافی شاپ1
                Intent oi = new Intent(this, typeof(Drink_Activity));
                StartActivity(oi);

            };
            NewCoofeShop_Button_CoffeTwo = FindViewById<Button>(Resource.Id.NewCoofeShop_Button_CoffeTwo);
            NewCoofeShop_Button_CoffeTwo.Click += delegate {

                //کافی شاپ2
                Intent oi = new Intent(this, typeof(Drink_Activity));
                StartActivity(oi);
            };
        }
    }
}