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
    [Activity(Label = "SelectedConfectionary_Activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class SelectedConfectionary_Activity : AppCompatActivity
    {
        TextView SelectedConfectionart_TxtView_Header;
        Button SelectedConfectionart_Button_Account;
        Button SelectedConfectionart_Button_Message;
        Button SelectedConfectionart_Button_Basket;
        Button SelectedConfectionart_Button_Home;
        Button SelectedConfectionart_Button_NationalIce;
        Button SelectedConfectionart_Button_ForiegnIce;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Selectedconfectionart_Activity);
              SelectedConfectionart_TxtView_Header = FindViewById<TextView>(Resource.Id.SelectedConfectionart_TxtView_Header);
         
              SelectedConfectionart_Button_Account = FindViewById<Button>(Resource.Id.SelectedConfectionart_Button_Account);
            SelectedConfectionart_Button_Account.Click += delegate {

                //حساب
                Intent oi = new Intent(this, typeof(Account_Activity));
                StartActivity(oi);

            };
              SelectedConfectionart_Button_Message = FindViewById<Button>(Resource.Id.SelectedConfectionart_Button_Message);
            SelectedConfectionart_Button_Message.Click += delegate {
                //پیام
                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
              SelectedConfectionart_Button_Basket = FindViewById<Button>(Resource.Id.SelectedConfectionart_Button_Basket);
            SelectedConfectionart_Button_Basket.Click += delegate {

                //سبد خرید
                Intent oi = new Intent(this, typeof(Basket_activity));
                StartActivity(oi);
            };
              SelectedConfectionart_Button_Home = FindViewById<Button>(Resource.Id.SelectedConfectionart_Button_Home);
            SelectedConfectionart_Button_Home.Click += delegate {
                //خانه
                Intent oi = new Intent(this, typeof(MainActivity));
                StartActivity(oi);
            };
              SelectedConfectionart_Button_NationalIce = FindViewById<Button>(Resource.Id.SelectedConfectionart_Button_NationalIce);
            SelectedConfectionart_Button_NationalIce.Click += delegate {

                //قنادی ایرانی
                Intent oi = new Intent(this, typeof(SelectedTwoConf ));
                StartActivity(oi);
            };
              SelectedConfectionart_Button_ForiegnIce = FindViewById<Button>(Resource.Id.SelectedConfectionart_Button_ForiegnIce);
            SelectedConfectionart_Button_ForiegnIce.Click += delegate {

                //قنادی خارجی
                Intent oi = new Intent(this, typeof(SelectedTwoConf));
                StartActivity(oi);
            };
            // Create your application here
        }
    }
}