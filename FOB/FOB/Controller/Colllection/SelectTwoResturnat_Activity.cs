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
    /// انتخاب رستوران
    /// </summary>
    [Activity(Label = "SelectTwoResturnat_Activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class SelectTwoResturnat_Activity :  AppCompatActivity
    {
        TextView SelectTwoResturant_TxtView_Header;
        Button SelectTwoResturant_Button_Account;
        Button SelectTwoResturant_Button_Message;
        Button SelectTwoResturant_Button_Basket;
        Button SelectTwoResturant_Button_Home;


        Button SelectTwoResturant_Button_ResturantOne;
        Button SelectTwoResturant_Button_ResturantTwo;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.SelectTwoResturant);
             SelectTwoResturant_TxtView_Header=FindViewById<TextView>(Resource.Id.SelectTwoResturant_TxtView_Header);
             SelectTwoResturant_Button_Account = FindViewById<Button>(Resource.Id.SelectTwoResturant_Button_Account);
            SelectTwoResturant_Button_Account.Click += delegate {
                //حساب
                Intent oi = new Intent(this, typeof(Account_Activity));
                StartActivity(oi);
            };
             SelectTwoResturant_Button_Message = FindViewById<Button>(Resource.Id.SelectTwoResturant_Button_Message);
            SelectTwoResturant_Button_Message.Click += delegate {
                //پیام
                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
            SelectTwoResturant_Button_Basket = FindViewById<Button>(Resource.Id.SelectTwoResturant_Button_Basket);
            SelectTwoResturant_Button_Basket.Click += delegate {

                //سبد
                Intent oi = new Intent(this, typeof(Basket_activity));
                StartActivity(oi);
            };
            SelectTwoResturant_Button_Home = FindViewById<Button>(Resource.Id.SelectTwoResturant_Button_Home);
            SelectTwoResturant_Button_Home.Click += delegate {

                //خانه
                Intent oi = new Intent(this, typeof(MainActivity));
                StartActivity(oi);
            };


            SelectTwoResturant_Button_ResturantOne = FindViewById<Button>(Resource.Id.SelectTwoResturant_Button_ResturantOne);
            SelectTwoResturant_Button_ResturantOne.Click += delegate {

                //رستوران اول
              
                Intent oi = new Intent(this, typeof(Resturant_activity));
                StartActivity(oi);
            };
            SelectTwoResturant_Button_ResturantTwo = FindViewById<Button>(Resource.Id.SelectTwoResturant_Button_ResturantTwo);
            SelectTwoResturant_Button_ResturantTwo.Click += delegate {
                //رستوران دوم
            
                Intent oi = new Intent(this, typeof(Resturant_activity));
                StartActivity(oi);
            };

        }
    }
}