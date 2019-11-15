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
    /// قهوه خونه
    /// </summary>
    [Activity(Label = "TradionalIranDrink_Activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class TradionalIranDrink_Activity : AppCompatActivity
    {
        TextView TraditionalIranDrink_TxtView_Header;
        Button TraditionalIranDrink_Button_Account;
        Button TraditionalIranDrink_Button_Message;
        Button TraditionalIranDrink_Button_Basket;
        Button TraditionalIranDrink_Button_Home;


        Button TraditionalIranDrink_Button_CoffeOne;
        Button TraditionalIranDrink_Button_CoffeTwo;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_traditionaliraniandrink);

              TraditionalIranDrink_TxtView_Header=FindViewById<TextView>(Resource.Id.TraditionalIranDrink_TxtView_Header);
              TraditionalIranDrink_Button_Account = FindViewById<Button>(Resource.Id.TraditionalIranDrink_Button_Account);
            TraditionalIranDrink_Button_Account.Click += delegate {

                //حساب
                Intent oi = new Intent(this, typeof(Account_Activity));
                StartActivity(oi);
            };
              TraditionalIranDrink_Button_Message = FindViewById<Button>(Resource.Id.TraditionalIranDrink_Button_Message);
            TraditionalIranDrink_Button_Message.Click += delegate 
          {
              //پیام
              Intent oi = new Intent(this, typeof(Message_Activity));
              StartActivity(oi);

          };
              TraditionalIranDrink_Button_Basket = FindViewById<Button>(Resource.Id.TraditionalIranDrink_Button_Basket);
            TraditionalIranDrink_Button_Basket.Click += delegate {
                //سبد
                Intent oi = new Intent(this, typeof(Basket_activity));
                StartActivity(oi);
            };
              TraditionalIranDrink_Button_Home = FindViewById<Button>(Resource.Id.TraditionalIranDrink_Button_Home);
            TraditionalIranDrink_Button_Home.Click += delegate {

                //خانه
                Intent oi = new Intent(this, typeof(MainActivity));
                StartActivity(oi);
            };

              TraditionalIranDrink_Button_CoffeOne = FindViewById<Button>(Resource.Id.TraditionalIranDrink_Button_CoffeOne);
            TraditionalIranDrink_Button_CoffeOne.Click += delegate {

                //قهوه خونه1
               
                Intent oi = new Intent(this, typeof(Drink_Activity));
                StartActivity(oi);
            };
              TraditionalIranDrink_Button_CoffeTwo = FindViewById<Button>(Resource.Id.TraditionalIranDrink_Button_CoffeTwo);
            TraditionalIranDrink_Button_CoffeTwo.Click += delegate {
                //قهوه خونه 2
                Intent oi = new Intent(this, typeof(Drink_Activity));
                StartActivity(oi);
            };
            // Create your application here
        }
    }
}