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
    /// رستوران خارجی
    /// </summary>
    [Activity(Label = "SelectTwoResturnat_Activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class ForeignResturant_Activity :  AppCompatActivity
    {
        TextView ForigenResturant_TxtView_Header;
        Button ForigenResturant_Button_Account;
        Button ForigenResturant_Button_Message;
        Button ForigenResturant_Button_Basket;
        Button ForigenResturant_Button_Home;

        Button ForigenResturant_Button_American;
        Button ForigenResturant_Button_Europe;
        Button ForigenResturant_Button_China;
        Button ForigenResturant_Button_Japan;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_ForigenResturant);
              ForigenResturant_TxtView_Header=FindViewById<TextView>(Resource.Id.ForigenResturant_TxtView_Header);
              ForigenResturant_Button_Account = FindViewById<Button>(Resource.Id.ForigenResturant_Button_Account);
            ForigenResturant_Button_Account.Click += delegate {
         
                //حساب
                Intent oi = new Intent(this, typeof(Account_Activity));
                StartActivity(oi);
            };
              ForigenResturant_Button_Message = FindViewById<Button>(Resource.Id.ForigenResturant_Button_Message);
            ForigenResturant_Button_Message.Click += delegate {
                //پیام
                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
            ForigenResturant_Button_Basket = FindViewById<Button>(Resource.Id.ForigenResturant_Button_Basket);
            ForigenResturant_Button_Basket.Click += delegate {
                //سبد
                Intent oi = new Intent(this, typeof(Basket_activity));
                StartActivity(oi);
            };
            ForigenResturant_Button_Home = FindViewById<Button>(Resource.Id.ForigenResturant_Button_Home);
            ForigenResturant_Button_Home.Click += delegate {
                //خانه
                Intent oi = new Intent(this, typeof(MainActivity));
                StartActivity(oi);
            };



             ForigenResturant_Button_American = FindViewById<Button>(Resource.Id.ForigenResturant_Button_American);
            ForigenResturant_Button_American.Click += delegate {

                //انتخاب رستوران
                Intent oi = new Intent(this, typeof(SelectTwoResturnat_Activity));
                StartActivity(oi);
            };
             ForigenResturant_Button_Europe = FindViewById<Button>(Resource.Id.ForigenResturant_Button_Europe);
            ForigenResturant_Button_Europe.Click += delegate {

                //انتخاب رستوران
                Intent oi = new Intent(this, typeof(SelectTwoResturnat_Activity));
                StartActivity(oi);
            };
             ForigenResturant_Button_China = FindViewById<Button>(Resource.Id.ForigenResturant_Button_China);
            ForigenResturant_Button_China.Click += delegate {
                //انتخاب رستوران
                Intent oi = new Intent(this, typeof(SelectTwoResturnat_Activity));
                StartActivity(oi);
            };
             ForigenResturant_Button_Japan = FindViewById<Button>(Resource.Id.ForigenResturant_Button_Japan);
            ForigenResturant_Button_Japan.Click += delegate {
                //انتخاب رستوران
                Intent oi = new Intent(this, typeof(SelectTwoResturnat_Activity));
                StartActivity(oi);
            };
        }
    }
}