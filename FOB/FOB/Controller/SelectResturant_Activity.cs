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
using FOB.Controller.Colllection;

namespace FOB.Controller
{
    [Activity(Label = "SelectResturant_Activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class SelectResturant_Activity :  Activity
    {
        TextView SelectResturant_TxtView_Header;
        Button SelectResturant_Button_Account;
        Button SelectResturant_Button_Message;
        Button SelectResturant_Button_Basket;
        Button SelectResturant_Button_Home;

        Button SelectResturant_Button_ResturantOne;
        Button SelectResturant_Button_ResturantTwo;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_selectresturant);
              SelectResturant_TxtView_Header=FindViewById<TextView>(Resource.Id.SelectResturant_TxtView_Header);
              SelectResturant_Button_Account = FindViewById<Button>(Resource.Id.SelectResturant_Button_Account);
            SelectResturant_Button_Account.Click += delegate{

                //حساب
                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
              SelectResturant_Button_Message = FindViewById<Button>(Resource.Id.SelectResturant_Button_Message);
            SelectResturant_Button_Message.Click += delegate {

                //پیام
                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
              SelectResturant_Button_Basket = FindViewById<Button>(Resource.Id.SelectResturant_Button_Basket);
            SelectResturant_Button_Basket.Click += delegate {

                //سبد
                Intent oi = new Intent(this, typeof(Basket_activity));
                StartActivity(oi);
            };
              SelectResturant_Button_Home = FindViewById<Button>(Resource.Id.SelectResturant_Button_Home);
            SelectResturant_Button_Home.Click += delegate {

                //خانه
                Intent oi = new Intent(this, typeof(MainActivity));
                StartActivity(oi);
            };

              SelectResturant_Button_ResturantOne = FindViewById<Button>(Resource.Id.SelectResturant_Button_ResturantForgien);
            SelectResturant_Button_ResturantOne.Click += delegate {

                //رستوران خارجی
                Intent oi = new Intent(this, typeof(ForeignResturant_Activity));
                StartActivity(oi);
            };
              SelectResturant_Button_ResturantTwo = FindViewById<Button>(Resource.Id.SelectResturant_Button_ResturantIranian);
            SelectResturant_Button_ResturantTwo.Click += delegate {

                //رستوران ایرانی
                Intent oi = new Intent(this, typeof(IranianResturant_Activity));
                StartActivity(oi);
            };
            // Create your application here
        }
    }
}