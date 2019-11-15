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
{ /// <summary>
  /// رستوران ایرانی
  /// </summary>
    [Activity(Label = "SelectTwoResturnat_Activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class IranianResturant_Activity : AppCompatActivity
    {
        TextView SelectIranResturant_TxtView_Header;
        Button SelectIranResturant_Button_Account;
        Button SelectIranResturant_Button_Message;
        Button SelectIranResturant_Button_Basket;
        Button SelectIranResturant_Button_Home;

        Button SelectIranResturant_Button_Traditional;
        Button SelectIranResturant_Button_NewResturnat;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_IranianResturant);
            SelectIranResturant_TxtView_Header = FindViewById<TextView>(Resource.Id.SelectIranResturant_TxtView_Header);
            SelectIranResturant_Button_Account = FindViewById<Button>(Resource.Id.SelectIranResturant_Button_Account);
            SelectIranResturant_Button_Account.Click += delegate {
                //حساب
                Intent oi = new Intent(this, typeof(Account_Activity));
                StartActivity(oi);
            };
            SelectIranResturant_Button_Message = FindViewById<Button>(Resource.Id.SelectIranResturant_Button_Message);
            SelectIranResturant_Button_Message.Click += delegate {
                //پیام
                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
            SelectIranResturant_Button_Basket = FindViewById<Button>(Resource.Id.SelectIranResturant_Button_Basket);
            SelectIranResturant_Button_Basket.Click += delegate {

                //سبد
                Intent oi = new Intent(this, typeof(Basket_activity));
                StartActivity(oi);
            };
            SelectIranResturant_Button_Home = FindViewById<Button>(Resource.Id.SelectIranResturant_Button_Home);
            SelectIranResturant_Button_Home.Click += delegate {

                //خانه
                Intent oi = new Intent(this, typeof(MainActivity));
                StartActivity(oi);
            };

              SelectIranResturant_Button_Traditional = FindViewById<Button>(Resource.Id.SelectIranResturant_Button_Traditional);
            SelectIranResturant_Button_Traditional.Click += delegate {

                //رستوران سنتی
                Intent oi = new Intent(this, typeof(SelectTwoResturnat_Activity));
                StartActivity(oi);
            };
            SelectIranResturant_Button_NewResturnat = FindViewById<Button>(Resource.Id.SelectIranResturant_Button_NewResturnat);
            SelectIranResturant_Button_NewResturnat.Click += delegate {

                //رستوران جدید
                Intent oi = new Intent(this, typeof(SelectTwoResturnat_Activity));
                StartActivity(oi);
            };
        }
    }
}