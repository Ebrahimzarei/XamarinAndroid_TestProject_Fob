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
    /// انتخاب فست فود
    /// </summary>
    [Activity(Label = "SelectedFastFoood_Activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class SelectedFastFoood_Activity : AppCompatActivity
    {
        TextView SelectedFastfood_TxtView_Header;
        Button SelectedFastfood_Button_Account;
        Button SelectedFastfood_Button_Message;
        Button SelectedFastfood_Button_Basket;
        Button SelectedFastfood_Button_Home;

        Button SelectedFastfood_Button_NationalFastFood;
        Button SelectedFastfood_Button_ForiegnFastFood;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_selectedfastFood);

              SelectedFastfood_TxtView_Header = FindViewById<TextView>(Resource.Id.Alas_TxtView_Header);
              SelectedFastfood_Button_Account = FindViewById<Button>(Resource.Id.SelectedFastfood_Button_Account);
            SelectedFastfood_Button_Account.Click += delegate {

                //حساب
                Intent oi = new Intent(this, typeof(Account_Activity));
                StartActivity(oi);
            };
              SelectedFastfood_Button_Message = FindViewById<Button>(Resource.Id.SelectedFastfood_Button_Message);
            SelectedFastfood_Button_Message.Click += delegate {

                //پیام
                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
              SelectedFastfood_Button_Basket = FindViewById<Button>(Resource.Id.SelectedFastfood_Button_Basket);
            SelectedFastfood_Button_Basket.Click += delegate {
                //سبد
                Intent oi = new Intent(this, typeof(Basket_activity));
                StartActivity(oi);
            };
              SelectedFastfood_Button_Home = FindViewById<Button>(Resource.Id.SelectedFastfood_Button_Home);
            SelectedFastfood_Button_Home.Click += delegate {

                //خانه
                Intent oi = new Intent(this, typeof(MainActivity));
                StartActivity(oi);
            };

SelectedFastfood_Button_NationalFastFood = FindViewById<Button>(Resource.Id.SelectedFastfood_Button_NationalFastFood);
         SelectedFastfood_Button_NationalFastFood.Click += delegate {

             //انتخاب فست فود
             Intent oi = new Intent(this, typeof(SelectedTwoFastFood_Activity));
             StartActivity(oi);
         };
             SelectedFastfood_Button_ForiegnFastFood = FindViewById<Button>(Resource.Id.SelectedFastfood_Button_ForiegnFastFood);
             SelectedFastfood_Button_ForiegnFastFood.Click += delegate {

                 //انتخاب فست فود
                 Intent oi = new Intent(this, typeof(SelectedTwoFastFood_Activity));
                 StartActivity(oi);
             };
            // Create your application here
        }
    }
}