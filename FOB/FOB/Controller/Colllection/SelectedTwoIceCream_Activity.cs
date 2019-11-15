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
    /// بستنی 1 و دو
    /// </summary>
    [Activity(Label = "SelectedTwoIceCream_Activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class SelectedTwoIceCream_Activity : AppCompatActivity
    {

        TextView SelectedTwoIceCreame_TxtView_Header;
        Button SelectedTwoIceCreame_Button_Account;
        Button SelectedTwoIceCreame_Button_Message;
        Button SelectedTwoIceCreame_Button_Basket;
        Button SelectedTwoIceCreame_Button_Home;

        Button SelectedTwoIceCreame_Button_NationalIce;
        Button SelectedTwoIceCreame_Button_ForiegnIce;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_selectedtwoicecreame);
              SelectedTwoIceCreame_TxtView_Header = FindViewById<TextView>(Resource.Id.Main_TxtView_Header);
         
            SelectedTwoIceCreame_Button_Account = FindViewById<Button>(Resource.Id.SelectedTwoIceCreame_Button_Account);
            SelectedTwoIceCreame_Button_Account.Click += delegate {
                 //حساب
                 Intent oi = new Intent(this, typeof(Account_Activity));
                 StartActivity(oi);
             };
            SelectedTwoIceCreame_Button_Message = FindViewById<Button>(Resource.Id.SelectedTwoIceCreame_Button_Message);
            SelectedTwoIceCreame_Button_Message.Click += delegate {
                 //پیام
                 Intent oi = new Intent(this, typeof(Message_Activity));
                 StartActivity(oi);
             };
            SelectedTwoIceCreame_Button_Basket = FindViewById<Button>(Resource.Id.SelectedTwoIceCreame_Button_Basket);
            SelectedTwoIceCreame_Button_Basket.Click += delegate {
                 //سبد
                 Intent oi = new Intent(this, typeof(Basket_activity));
                 StartActivity(oi);
             };
            SelectedTwoIceCreame_Button_Home = FindViewById<Button>(Resource.Id.SelectedTwoIceCreame_Button_Home);
            SelectedTwoIceCreame_Button_Home.Click += delegate {
                 //خانه
                 Intent oi = new Intent(this, typeof(MainActivity));
                 StartActivity(oi);
             };

            SelectedTwoIceCreame_Button_NationalIce = FindViewById<Button>(Resource.Id.SelectedTwoIceCreame_Button_NationalIce);
            SelectedTwoIceCreame_Button_NationalIce.Click += delegate {
                 //1بستی
                 Intent oi = new Intent(this, typeof(IceCream_Activity));
                 StartActivity(oi);
             };
            SelectedTwoIceCreame_Button_ForiegnIce = FindViewById<Button>(Resource.Id.SelectedTwoIceCreame_Button_ForiegnIce);
            SelectedTwoIceCreame_Button_ForiegnIce.Click += delegate {
                //2بستی
                Intent oi = new Intent(this, typeof(IceCream_Activity));
                 StartActivity(oi);
             };
            // Create your application here
        }
    }
}