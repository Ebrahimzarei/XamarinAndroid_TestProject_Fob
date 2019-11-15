using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using FOB.Controller;
using FOB.Controller.Colllection;

namespace FOB
{
    [Activity(Label = "MainActivity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class MainActivity :  AppCompatActivity
    {
     
      


        TextView Main_TxtView_Header;
        ImageView Main_ImageView_Search;
        TextView Main_TextView_Location;

        Button Main_Button_Home;
        Button Main_Button_Order;
        ImageButton Main_ImageButton_Menu;

        Button Main_Button_Basket;
        Button Main_Button_Account;
       ViewPager Main_ViewPager_SliderFood;
        Android.Support.Design.Widget.TabLayout Main_TabLayouts_WithPager;

        Button Main_Button_Resturant;
        Button Main_Button_FastFood;
        Button Main_Button_Drink;
        Button Main_Button_Icecream;
        Button Main_Button_Liver;
        Button Main_Button_Tabakhi;
        Button Main_Button_Connfectionary;
        Button Main_Button_Alas;
        Button Main_Button_Breads;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            Main_TxtView_Header = FindViewById<TextView>(Resource.Id.Main_TxtView_Header);
            Main_TxtView_Header.Click += delegate {



            };

            Main_ImageView_Search = FindViewById<ImageView>(Resource.Id.Main_ImageView_Search);

            Main_TextView_Location = FindViewById<TextView>(Resource.Id.Main_TextView_Location);

            Main_Button_Home = FindViewById<Button>(Resource.Id.Main_Button_Home);
            Main_Button_Order = FindViewById<Button>(Resource.Id.Main_Button_Order);
            Main_Button_Order.Click += delegate {
            
                    //پیام
                    Intent oi = new Intent(this, typeof(Message_Activity));
                    StartActivity(oi);
            
            };
            Main_ImageButton_Menu = FindViewById<ImageButton>(Resource.Id.Main_ImageButton_Menu);

            Main_Button_Basket = FindViewById<Button>(Resource.Id.Main_Button_Basket);
            Main_Button_Basket.Click += delegate {
   
           
                    //سبد خرید
                    Intent oi = new Intent(this, typeof(Basket_activity));
                    StartActivity(oi);
           
                
            };
            Main_Button_Account = FindViewById<Button>(Resource.Id.Main_Button_Account);
            Main_Button_Account.Click += delegate {
             
                
                    //حساب
                    Intent oi = new Intent(this, typeof(Account_Activity));
                    StartActivity(oi);
               
             
            };

            Main_ViewPager_SliderFood = FindViewById<ViewPager>(Resource.Id.Main_ViewPager_SliderFood);
            Main_TabLayouts_WithPager = FindViewById<Android.Support.Design.Widget.TabLayout>(Resource.Id.Main_TabLayouts_WithPager);

            Main_Button_Resturant = FindViewById<Button>(Resource.Id.Main_Button_Resturant);
            Main_Button_Resturant.Click += delegate {

                //رستوران
                //if (Main_TextView_Location.Text == "نام شهر,نام منطقه")
                //{
                //    Snackbar snackBar = Snackbar.Make(Main_Button_Order, "لطفا ابتدا موقعیت مکانی را مشخص فرمایید", Snackbar.LengthIndefinite).SetAction("تایید", (v) =>
                //    {
                //        Finish();
                //    });


                //    snackBar.SetActionTextColor(Android.Graphics.Color.Green);

                //    snackBar.Show();

                //}
                //else
                //{
                    //انتخاب رستوان
                    Intent oi = new Intent(this, typeof(SelectResturant_Activity));
                    StartActivity(oi);
             //   }
           

            };

            Main_Button_FastFood = FindViewById<Button>(Resource.Id.Main_Button_FastFood);
            Main_Button_FastFood.Click += delegate {
                //if (Main_TextView_Location.Text == "نام شهر,نام منطقه")
                //{
                //    Snackbar snackBar = Snackbar.Make(Main_Button_Order, "لطفا ابتدا موقعیت مکانی را مشخص فرمایید", Snackbar.LengthIndefinite).SetAction("تایید", (v) =>
                //    {
                //        Finish();
                //    });


                //    snackBar.SetActionTextColor(Android.Graphics.Color.Green);

                //    snackBar.Show();

                //}
            //    else
             //   {
                    //فست غود
                    Intent oi = new Intent(this, typeof(SelectedFastFoood_Activity));
                    StartActivity(oi);
            //    }
         
            };

            Main_Button_Drink = FindViewById<Button>(Resource.Id.Main_Button_Drink);
            Main_Button_Drink.Click += delegate {
                //if (Main_TextView_Location.Text == "نام شهر,نام منطقه")
                //{
                //    Snackbar snackBar = Snackbar.Make(Main_Button_Order, "لطفا ابتدا موقعیت مکانی را مشخص فرمایید", Snackbar.LengthIndefinite).SetAction("تایید", (v) =>
                //    {
                //        Finish();
                //    });


                //    snackBar.SetActionTextColor(Android.Graphics.Color.Green);

                //    snackBar.Show();

                //}
                //else
                //{
                    //نوشیدنی
                    Intent oi = new Intent(this, typeof(SelectDrink_Activity));
                    StartActivity(oi);
              //  }

              
            };
            Main_Button_Icecream = FindViewById<Button>(Resource.Id.Main_Button_Icecream);
            Main_Button_Icecream.Click += delegate {
                //if (Main_TextView_Location.Text == "نام شهر,نام منطقه")
                //{
                //    Snackbar snackBar = Snackbar.Make(Main_Button_Order, "لطفا ابتدا موقعیت مکانی را مشخص فرمایید", Snackbar.LengthIndefinite).SetAction("تایید", (v) =>
                //    {
                //        Finish();
                //    });


                //    snackBar.SetActionTextColor(Android.Graphics.Color.Green);

                //    snackBar.Show();

                //}
                //else
                //{
                    //بستنی
                    Intent oi = new Intent(this, typeof(SelectedIceCreame_Activity));
                    StartActivity(oi);
            //    }
             
            };

            Main_Button_Liver = FindViewById<Button>(Resource.Id.Main_Button_Liver);  
                Main_Button_Liver.Click += delegate {
                    //if (Main_TextView_Location.Text == "نام شهر,نام منطقه")
                    //{
                    //    Snackbar snackBar = Snackbar.Make(Main_Button_Order, "لطفا ابتدا موقعیت مکانی را مشخص فرمایید", Snackbar.LengthIndefinite).SetAction("تایید", (v) =>
                    //    {
                    //        Finish();
                    //    });


                    //    snackBar.SetActionTextColor(Android.Graphics.Color.Green);

                    //    snackBar.Show();

                    //}
                    //else
                    //{
                        //چگرکی
                        Intent oi = new Intent(this, typeof(SelectedLiver));
                        StartActivity(oi);
                   // }
                 
                };
            Main_Button_Tabakhi = FindViewById<Button>(Resource.Id. Main_Button_Tabakhi);
            Main_Button_Tabakhi.Click += delegate {
                //if (Main_TextView_Location.Text == "نام شهر,نام منطقه")
                //{
                //    Snackbar snackBar = Snackbar.Make(Main_Button_Order, "لطفا ابتدا موقعیت مکانی را مشخص فرمایید", Snackbar.LengthIndefinite).SetAction("تایید", (v) =>
                //    {
                //        Finish();
                //    });


                //    snackBar.SetActionTextColor(Android.Graphics.Color.Green);

                //    snackBar.Show();

                //}
                //else
                //{
                    //طباخی
                    Intent oi = new Intent(this, typeof(SelectedTabakhi_Activity));
                    StartActivity(oi);
                //}
      
            };
            Main_Button_Connfectionary = FindViewById<Button>(Resource.Id.Main_Button_Connfectionary);
            Main_Button_Connfectionary.Click += delegate {
                //if (Main_TextView_Location.Text == "نام شهر,نام منطقه")
                //{
                //    Snackbar snackBar = Snackbar.Make(Main_Button_Order, "لطفا ابتدا موقعیت مکانی را مشخص فرمایید", Snackbar.LengthIndefinite).SetAction("تایید", (v) =>
                //    {
                //        Finish();
                //    });


                //    snackBar.SetActionTextColor(Android.Graphics.Color.Green);

                //    snackBar.Show();

                //}
                //else
                //{
                    //قنادی
                    Intent oi = new Intent(this, typeof(SelectedTwoConf));
                    StartActivity(oi);
             //   }
             

            };
            Main_Button_Alas = FindViewById<Button>(Resource.Id.Main_Button_Alas);
            Main_Button_Alas.Click += delegate {
                //if (Main_TextView_Location.Text == "نام شهر,نام منطقه")
                //{
                //    Snackbar snackBar = Snackbar.Make(Main_Button_Order, "لطفا ابتدا موقعیت مکانی را مشخص فرمایید", Snackbar.LengthIndefinite).SetAction("تایید", (v) =>
                //    {
                //        Finish();
                //    });


                //    snackBar.SetActionTextColor(Android.Graphics.Color.Green);

                //    snackBar.Show();

                //}
                //else
                //{
                    //اش
                    Intent oi = new Intent(this, typeof(SelectedAlas_Activity));
                    StartActivity(oi);
              //  }

        
            };
            Main_Button_Breads = FindViewById<Button>(Resource.Id.Main_Button_Breads);
            Main_Button_Breads.Click += delegate {
                //if (Main_TextView_Location.Text == "نام شهر,نام منطقه")
                //{
                //    Snackbar snackBar = Snackbar.Make(Main_Button_Order, "لطفا ابتدا موقعیت مکانی را مشخص فرمایید", Snackbar.LengthIndefinite).SetAction("تایید", (v) =>
                //    {
                //        Finish();
                //    });


                //    snackBar.SetActionTextColor(Android.Graphics.Color.Green);

                //    snackBar.Show();

                //}
                //else
                //{
                    //نون
                    Intent oi = new Intent(this, typeof(SelectedBread_Activity));
                    StartActivity(oi);
              //  }
             
            };

            //string[] ITEMS = { "شیراز,معالی آباد", "شیراز,چهارراه زند", "شیراز,چمران" };
            //var adapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleSpinnerItem, ITEMS);
            //adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            //Main_Spinner_Location.Hint = "نام شهر-اسم منطقه ";
            //Main_Spinner_Location.TextDirection = TextDirection.FirstStrongLtr;
            //Main_Spinner_Location.Adapter = adapter;
            //string[] ITEMS = { "شیراز,معالی آباد", "شیراز,چهارراه زند", "شیراز,چمران" };
            var items = new List<string>() { "نام شهر,نام منطقه", "شیراز,معالی آباد", "اهواز,نادری" };
           // var adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerItem, items);

            // Main_Spinner_Location
        

      
            Main_TextView_Location.Click += delegate {
                Intent oi = new Intent(this, typeof(LocationActivity));
                StartActivity(oi);

            };
         

            

          //  Main_Spinner_Location.Adapter = adapter;




            Main_ViewPager_SliderFood.Adapter = new imageAdapter(this);
            var timer = new System.Timers.Timer();
            timer.Interval = 3000;
            timer.Enabled = true;
            int page = 0;
            timer.Elapsed += (sender, args) =>
            {
                RunOnUiThread(() =>
                {
                    if (page <= Main_ViewPager_SliderFood.Adapter.Count)
                    {
                        page++;
                    }
                    else
                    {
                        page = 0;
                    }
                    Main_ViewPager_SliderFood.SetCurrentItem(page, true);

                });
            };
            
            var dots = FindViewById<TabLayout>(Resource.Id.Main_TabLayouts_WithPager);
    // dots.SetupWithViewPager(Main_ViewPager_SliderFood, true);

           // Main_TabLayouts_WithPager.SetupWithViewPager(Main_ViewPager_SliderFood, true);
        }

        
        public void ChangeLocation( View v)
        {
        }
    }
    public class imageAdapter : PagerAdapter
    {
        Context context;
        private int[] imagelist =
        {
            Resource.Mipmap.chickenTwo,
             Resource.Mipmap.chickenTwo,
             Resource.Mipmap.chickenTwo,
                Resource.Mipmap.chickenTwo,
                 Resource.Mipmap.chickenTwo,


        };
        public imageAdapter(Context cnt)
        {
            context = cnt;
        }
        public override int Count
        {
            get
            {
                return imagelist.Length;
            }
        }

        public override bool IsViewFromObject(View view, Java.Lang.Object @object)
        {
            return view == ((ImageView)@object);
        }

        public override Java.Lang.Object InstantiateItem(ViewGroup container, int position)
        {
            ImageView imageview = new ImageView(context);
            imageview.SetScaleType(ImageView.ScaleType.FitCenter);
            imageview.SetImageResource(imagelist[position]);
            ((ViewPager)container).AddView(imageview, 0);
            return imageview;


        }


        //public override void DestroyItem(View container, int position, Java.Lang.Object @object) =>
        //    // base.DestroyItem(container, position, @object);
        //    ((ViewPager)container).RemoveView((ImageView)@object);


        public override void DestroyItem(View container, int position, Java.Lang.Object @object)
        {
            // base.DestroyItem(container, position, @object);
            ((ViewPager)container).RemoveView((ImageView)@object);
        }
        //public override void DestroyItem(View container, int position, Java.Interop.JniEnvironment.Object @object)
        //{
        //    ((ViewPager)container).RemoveView((ImageView)@object);
        //}
    }
}