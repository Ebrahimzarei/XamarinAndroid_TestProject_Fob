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
    /// انتخاب نوشیدنی
    /// </summary>
    [Activity(Label = "SelectDrink_Activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class SelectDrink_Activity : AppCompatActivity
    {
        TextView SelectDrink_TxtView_Header;
        Button SelectDrink_Button_Account;
        Button SelectDrink_Button_Message;
        Button SelectDrink_Button_Basket;
        Button SelectDrink_Button_Home;


        Button SelectDrink_Button_DrinkIranian;
        Button SelectDrink_Button_DrinkForgien;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_selectdrink);
              SelectDrink_TxtView_Header = FindViewById<TextView>(Resource.Id.SelectDrink_TxtView_Header);
              SelectDrink_Button_Account = FindViewById<Button>(Resource.Id.SelectDrink_Button_Account);
            SelectDrink_Button_Account.Click += delegate {


                //حساب
                Intent oi = new Intent(this, typeof(Account_Activity));
                StartActivity(oi);
            };
              SelectDrink_Button_Message = FindViewById<Button>(Resource.Id.SelectDrink_Button_Message);
            SelectDrink_Button_Message.Click += delegate {


                //پیام
                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
              SelectDrink_Button_Basket = FindViewById<Button>(Resource.Id.SelectDrink_Button_Basket);
            SelectDrink_Button_Basket.Click += delegate {

                //سبد
                Intent oi = new Intent(this, typeof(Basket_activity));
                StartActivity(oi);
            };
              SelectDrink_Button_Home = FindViewById<Button>(Resource.Id.SelectDrink_Button_Home);
            SelectDrink_Button_Home.Click += delegate {

                //Home
                Intent oi = new Intent(this, typeof(MainActivity));
                StartActivity(oi);
            };

              SelectDrink_Button_DrinkIranian = FindViewById<Button>(Resource.Id.SelectDrink_Button_DrinkIranian);
            SelectDrink_Button_DrinkIranian.Click += delegate {


                //ایرانی
                Intent oi = new Intent(this, typeof(IranianDrink_Activity));
                StartActivity(oi);
            };
              SelectDrink_Button_DrinkForgien = FindViewById<Button>(Resource.Id.SelectDrink_Button_DrinkForgien);
            SelectDrink_Button_DrinkForgien.Click += delegate {

                //خارجی
                Intent oi = new Intent(this, typeof(ForiegnDrink_Activity));
                StartActivity(oi);

            };
        }
    }
}