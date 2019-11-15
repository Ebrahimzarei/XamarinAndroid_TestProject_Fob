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

namespace FOB.Controller
{
    /// <summary>
    /// اطلاعات بیشتر محصول
    /// </summary>
    [Activity(Label = "PropertiseProduct_Activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class PropertiseProduct_Activity : AppCompatActivity
    {
        TextView PropertiseProduct_TxtView_Header;
        Button PropertiseProduct_Button_Account;
        Button PropertiseProduct_Button_Message;
        Button PropertiseProduct_Button_Basket;
        Button PropertiseProduct_Button_Home;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_PropertieseProduct);
              PropertiseProduct_TxtView_Header = FindViewById<TextView>(Resource.Id.PropertiseProduct_TxtView_Header); ;
              PropertiseProduct_Button_Account = FindViewById<Button>(Resource.Id.PropertiseProduct_Button_Account);
            PropertiseProduct_Button_Account.Click += delegate {
                //حساب
                Intent oi = new Intent(this, typeof(Account_Activity));
                StartActivity(oi);

            };
              PropertiseProduct_Button_Message = FindViewById<Button>(Resource.Id.PropertiseProduct_Button_Message);
            PropertiseProduct_Button_Message.Click += delegate {
                //پیام
                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
            PropertiseProduct_Button_Basket = FindViewById<Button>(Resource.Id.PropertiseProduct_Button_Basket);
            PropertiseProduct_Button_Basket.Click += delegate {
                //سبد
                Intent oi = new Intent(this, typeof(Basket_activity));
                StartActivity(oi);
            };
            PropertiseProduct_Button_Home = FindViewById<Button>(Resource.Id.PropertiseProduct_Button_Home);
            PropertiseProduct_Button_Home.Click += delegate {

                //خانه
                Intent oi = new Intent(this, typeof(MainActivity));
                StartActivity(oi);
            };
        }
    }
}