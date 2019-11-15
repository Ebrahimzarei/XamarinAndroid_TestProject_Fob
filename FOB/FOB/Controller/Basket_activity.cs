using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.View;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using FOB.Controller.Fragment.AdapterFragment;

namespace FOB.Controller
{
    [Activity(Label = "سبد خرید", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class Basket_activity : AppCompatActivity
    {

        TextView MainBasket_TextView_TextHeader;
        Button MainBasket_Button_Payed;
        ListView MainBaskete_ListView_MylstPromose;
        TextView MainBasket_TextView_Rial;
        TextView MainBasket_TextView_Count;
        TextView MainBasket_TextView_AllPrice;
        Button MainBasket_Button_VerifyResturant;
        Button MainBasket_Button_VerifyUser;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);


            SetContentView(Resource.Layout.activity_MainBasket);
            MainBasket_TextView_TextHeader = FindViewById<TextView>(Resource.Id.MainBasket_TextView_TextHeader);
            MainBasket_Button_Payed = FindViewById<Button>(Resource.Id.MainBasket_Button_Payed);
            MainBasket_Button_Payed.Click += delegate {
                //پزداخت 
                Intent oi = new Intent(this, typeof(Payed_Activity));
                StartActivity(oi);
            };
            MainBaskete_ListView_MylstPromose = FindViewById<ListView>(Resource.Id.MainBasket_ListView_MylstPromose);
            MainBasket_TextView_Rial = FindViewById<TextView>(Resource.Id.MainBasket_TextView_Rial);
            MainBasket_TextView_Count = FindViewById<TextView>(Resource.Id.MainBasket_TextView_Count);
            MainBasket_TextView_AllPrice = FindViewById<TextView>(Resource.Id.MainBasket_TextView_AllPrice);
            MainBasket_Button_VerifyResturant = FindViewById<Button>(Resource.Id.MainBasket_Button_VerifyResturant);
            MainBasket_Button_VerifyResturant.Click += delegate { };
            MainBasket_Button_VerifyUser = FindViewById<Button>(Resource.Id.MainBasket_Button_VerifyUser);
            MainBasket_Button_VerifyUser.Click += delegate { };
            List<Model.Basket_Resturant> fakelst = new List<Model.Basket_Resturant> {
            new Model.Basket_Resturant{Id=0,ItemOne="شرح",ItemTwo="10000",ItemThree="100000"},
            new Model.Basket_Resturant{Id=1,ItemOne="شرح",ItemTwo="10000",ItemThree="100000"},
            new Model.Basket_Resturant{Id=2,ItemOne="شرح",ItemTwo="10000",ItemThree="100000"},
            new Model.Basket_Resturant{Id=3,ItemOne="شرح",ItemTwo="10000",ItemThree="100000"},
            new Model.Basket_Resturant{Id=4,ItemOne="شرح",ItemTwo="10000",ItemThree="100000"},


        };

            MainBaskete_ListView_MylstPromose.Adapter = new FOB.Controller.SelectedItem.Adapter.Adapter_Basket(this, fakelst);
             
           



            //   SetContentView(Resource.Layout.activity_Basket);

            //    var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.Basket_toolbar);

            //  SetSupportActionBar(toolbar);
            //   //  Basket_TextView_Header = FindViewById<TextView>(Resource.Id.Basket_TextView_Header);
            //   var tablayout = FindViewById<Android.Support.Design.Widget.TabLayout>(Resource.Id.Basket_TabLayout_MyTab);
            //   var viewpager = FindViewById<ViewPager>(Resource.Id.Basket_ViewPager_MyPager);
            //   viewpager.Adapter = new TabFragmentAdapter(this.SupportFragmentManager,this);

            //tablayout.SetupWithViewPager(viewpager);

            //   View iconlayout1 = LayoutInflater.Inflate(Resource.Layout.Basket_TabTextIcon, null);
            //   var txt = iconlayout1.FindViewById<TextView>(Resource.Id.Basket_TextView_TabTextIcon);
            //   txt.Text = "سبد خرید";
            //   txt.TextSize = 18;
            //   txt.SetCompoundDrawablesWithIntrinsicBounds(Resource.Mipmap.home32, 0, 0, 0);
            //   tablayout.GetTabAt(0).SetCustomView(iconlayout1);

            //   View iconlayout2 = LayoutInflater.Inflate(Resource.Layout.Basket_TabTextIcon, null);
            //   var txt2 = iconlayout2.FindViewById<TextView>(Resource.Id.Basket_TextView_TabTextIcon);
            //   txt2.Text = "تبلیغات";
            //   txt2.TextSize = 18;
            //   txt2.SetCompoundDrawablesWithIntrinsicBounds(Resource.Mipmap.menu,0, 0, 0);
            //  tablayout.GetTabAt(1).SetCustomView(iconlayout2);



            //   // TextView Basket_TextView_Header=FindViewById<TextView>(resou);
            //   Basket_Button_Account = FindViewById<Button>(Resource.Id.Basket_Button_Account);
            //   Basket_Button_Account.Click += delegate {   //حساب
            //       Intent oi = new Intent(this, typeof(Account_Activity));
            //       StartActivity(oi);
            //   };
            //   Basket_Button_Message = FindViewById<Button>(Resource.Id.Basket_Button_Message);
            //   Basket_Button_Message.Click += delegate {
            //       //پیام
            //       Intent oi = new Intent(this, typeof(Message_Activity));
            //       StartActivity(oi);
            //   };
            //   Basket_Button_MyBasket =FindViewById<Button>(Resource.Id.Basket_Button_MyBasket);
            //   Basket_Button_MyBasket.Click += delegate {
            //       //سبد
            //       Intent oi = new Intent(this, typeof(Basket_activity));
            //       StartActivity(oi);
            //   };
            //   Basket_Button_Home =FindViewById<Button>(Resource.Id.Basket_Button_Home);
            //   Basket_Button_Home.Click += delegate {

            //       var t = new Intent(this, type:typeof(MainActivity));
            //       StartActivity(t);
            //   };


        }

        private void MainBaskete_ListView_MylstPromose_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
              Intent oi = new Intent(this, typeof(PropertiseProduct_Activity));
            StartActivity(oi);
        }
    }
}