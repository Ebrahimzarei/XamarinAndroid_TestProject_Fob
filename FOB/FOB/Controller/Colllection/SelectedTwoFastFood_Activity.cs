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
    /// انتخاب2 فست فود
    /// </summary>
    [Activity(Label = "SelectedTwoFastFood_Activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class SelectedTwoFastFood_Activity : AppCompatActivity
    {
        TextView SelectedTwoFastfood_TxtView_Header;
        Button SelectedTwoFastfood_Button_Account;
        Button SelectedTwoFastfood_Button_Message;
        Button SelectedTwoFastfood_Button_Basket;
        Button SelectedTwoFastfood_Button_Home;

        Button SelectedTwoFastfood_Button_FastfoodTwo;
        Button SelectedTwoFastfood_Button_FastfoodOne;



        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_SelectedTwoFastFood);
              SelectedTwoFastfood_TxtView_Header = FindViewById<TextView>(Resource.Id.SelectedTwoFastfood_TxtView_Header);
              SelectedTwoFastfood_Button_Account = FindViewById<Button>(Resource.Id.SelectedTwoFastfood_Button_Account);
            SelectedTwoFastfood_Button_Account.Click += delegate {

                //حساب
                Intent oi = new Intent(this, typeof(Account_Activity));
                StartActivity(oi);
            };
              SelectedTwoFastfood_Button_Message = FindViewById<Button>(Resource.Id.SelectedTwoFastfood_Button_Message);
            SelectedTwoFastfood_Button_Message.Click += delegate {

                //پسام
                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
              SelectedTwoFastfood_Button_Basket = FindViewById<Button>(Resource.Id.SelectedTwoFastfood_Button_Basket);
            SelectedTwoFastfood_Button_Basket.Click += delegate {

                //سبد
                Intent oi = new Intent(this, typeof(Basket_activity));
                StartActivity(oi);
            };
              SelectedTwoFastfood_Button_Home = FindViewById<Button>(Resource.Id.SelectedTwoFastfood_Button_Home);
            SelectedTwoFastfood_Button_Home.Click += delegate {

                //home
                Intent oi = new Intent(this, typeof(MainActivity));
                StartActivity(oi);
            };


            SelectedTwoFastfood_Button_FastfoodTwo = FindViewById<Button>(Resource.Id.SelectedTwoFastfood_Button_FastfoodTwo);
            SelectedTwoFastfood_Button_FastfoodTwo .Click+= delegate {

                //غست فود1
                Intent oi = new Intent(this, typeof(FastFood_Activity));
                StartActivity(oi);
            };
              SelectedTwoFastfood_Button_FastfoodOne = FindViewById<Button>(Resource.Id.SelectedTwoFastfood_Button_FastfoodOne);
            SelectedTwoFastfood_Button_FastfoodOne.Click += delegate {

                //فست فود2
                Intent oi = new Intent(this, typeof(FastFood_Activity));
                StartActivity(oi);
            };
        }
    }
}