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
    /// <summary>
    /// کافی شاپ خارجی
    /// </summary>
    [Activity(Label = "ForiegnDrink_Activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class ForiegnDrink_Activity : AppCompatActivity
    {
        TextView ForiegnDrink_TxtView_Header;
        Button ForiegnDrink_Button_Account;
        Button ForiegnDrink_Button_Message;
        Button ForiegnDrink_Button_Basket;
        Button ForiegnDrink_Button_Home;


        Button ForiegnDrink_Button_American;
        Button ForiegnDrink_Button_Europ;
        Button ForiegnDrink_Button_China;
        Button ForiegnDrink_Button_Japan;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_foriegndrink);
              ForiegnDrink_TxtView_Header = FindViewById<TextView>(Resource.Id.TraditionalIranDrink_TxtView_Header);
              ForiegnDrink_Button_Account = FindViewById<Button>(Resource.Id.ForiegnDrink_Button_Account);
            ForiegnDrink_Button_Account.Click += delegate {

                //حساب
                Intent oi = new Intent(this, typeof(Account_Activity));
                StartActivity(oi);
            };
              ForiegnDrink_Button_Message = FindViewById<Button>(Resource.Id.ForiegnDrink_Button_Message);
            ForiegnDrink_Button_Message.Click += delegate {
                //پیام
                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
            ForiegnDrink_Button_Basket = FindViewById<Button>(Resource.Id.ForiegnDrink_Button_Basket);
            ForiegnDrink_Button_Basket.Click += delegate {
                //سبد
                Intent oi = new Intent(this, typeof(Basket_activity));
                StartActivity(oi);
            };
            ForiegnDrink_Button_Home = FindViewById<Button>(Resource.Id.ForiegnDrink_Button_Home);
            ForiegnDrink_Button_Home.Click += delegate {
                //خانه
                Intent oi = new Intent(this, typeof(MainActivity));
                StartActivity(oi);
            };
            

            ForiegnDrink_Button_American = FindViewById<Button>(Resource.Id.ForiegnDrink_Button_American);
            ForiegnDrink_Button_American.Click += delegate {
                //آمریکایی
                Intent oi = new Intent(this, typeof(SelectNewCoffeShop_Activity));
                StartActivity(oi);

            };
            ForiegnDrink_Button_Europ = FindViewById<Button>(Resource.Id.ForiegnDrink_Button_Europ);
            ForiegnDrink_Button_Europ.Click += delegate {
                //اروپایی
                Intent oi = new Intent(this, typeof(SelectNewCoffeShop_Activity));
                StartActivity(oi);
            };
            ForiegnDrink_Button_China = FindViewById<Button>(Resource.Id.ForiegnDrink_Button_China);
            ForiegnDrink_Button_China.Click += delegate {
                //پینی
                Intent oi = new Intent(this, typeof(SelectNewCoffeShop_Activity));
                StartActivity(oi);
            };
            ForiegnDrink_Button_Japan = FindViewById<Button>(Resource.Id.ForiegnDrink_Button_Japan);
            ForiegnDrink_Button_Japan.Click += delegate {

                //ژاپنی
                Intent oi = new Intent(this, typeof(SelectNewCoffeShop_Activity));
                StartActivity(oi);
            };
        }
    }
}