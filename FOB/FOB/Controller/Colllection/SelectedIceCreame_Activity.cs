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
    /// انتخاب بستنی
    /// </summary>
    [Activity(Label = "SelectedIceCreame_Activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class SelectedIceCreame_Activity : AppCompatActivity
    {
        TextView SelectedIceCreame_TxtView_Header;
        Button SelectedIceCreame_Button_Account;
        Button SelectedIceCreame_Button_Message;
        Button SelectedIceCreame_Button_Basket;
        Button SelectedIceCreame_Button_Home;

        Button SelectedIceCreame_Button_NationalIce;
        Button SelectedIceCreame_Button_ForiegnIce;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_selectedIceCream);
              SelectedIceCreame_TxtView_Header = FindViewById<TextView>(Resource.Id.Main_TxtView_Header);
              SelectedIceCreame_Button_Account = FindViewById<Button>(Resource.Id.SelectedIceCreame_Button_Account);
            SelectedIceCreame_Button_Account.Click += delegate {   
                //حساب
                Intent oi = new Intent(this, typeof(Account_Activity));
                StartActivity(oi);
            };
              SelectedIceCreame_Button_Message = FindViewById<Button>(Resource.Id.SelectedIceCreame_Button_Message);
            SelectedIceCreame_Button_Message.Click += delegate {
                //پیام
                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
              SelectedIceCreame_Button_Basket = FindViewById<Button>(Resource.Id.SelectedIceCreame_Button_Basket);
            SelectedIceCreame_Button_Basket.Click += delegate {

                //سبد
                Intent oi = new Intent(this, typeof(Basket_activity));
                StartActivity(oi);
            };
              SelectedIceCreame_Button_Home = FindViewById<Button>(Resource.Id.SelectedIceCreame_Button_Home);
            SelectedIceCreame_Button_Home.Click += delegate {

                //خانه
                Intent oi = new Intent(this, typeof(MainActivity));
                StartActivity(oi);
            };

              SelectedIceCreame_Button_NationalIce = FindViewById<Button>(Resource.Id.SelectedIceCreame_Button_NationalIce);
            SelectedIceCreame_Button_NationalIce.Click += delegate {
                //بستنی ایرانی
                Intent oi = new Intent(this, typeof(SelectedTwoIceCream_Activity));
                StartActivity(oi);
            };
              SelectedIceCreame_Button_ForiegnIce = FindViewById<Button>(Resource.Id.SelectedIceCreame_Button_ForiegnIce);
            SelectedIceCreame_Button_ForiegnIce.Click += delegate {

                //بستنی خارجی
                Intent oi = new Intent(this, typeof(SelectedTwoIceCream_Activity));
                StartActivity(oi);
            };
            // Create your application here
        }
    }
}