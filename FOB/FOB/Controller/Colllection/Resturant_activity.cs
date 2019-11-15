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
using FOB.Controller.SelectedItem;

namespace FOB.Controller.Colllection
{
    [Activity(Label = "Resturant_Activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class Resturant_activity : AppCompatActivity
    {
        /// <summary>
        /// رستوران
        /// </summary>
        /// <param name="savedInstanceState"></param>
        /// 
        TextView Resturant_TxtView_Header;
        ImageView Resturant_ImageView_Search;
        ImageView Resturant_ImageView_Triangle;

        TextView Resturant_TextView_Location;
        Button Resturant_Button_Account;
        Button Resturant_Button_Message;
        ImageButton Resturant_ImageButton_Menu;
        Button Resturant_Button_Basket;
        Button Resturant_Button_Home;
        ListView Resturant_Listview_LstResturant;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_resturant);
            Resturant_TxtView_Header = FindViewById<TextView>(Resource.Id.Resturant_TxtView_Header);
            Resturant_ImageView_Search = FindViewById<ImageView>(Resource.Id.Resturant_ImageView_Search);
            Resturant_ImageView_Search.Click += delegate { };
            Resturant_ImageView_Triangle = FindViewById<ImageView>(Resource.Id.Resturant_ImageView_Triangle);
            Resturant_ImageView_Triangle.Click += delegate { };
            Resturant_TextView_Location = FindViewById<TextView>(Resource.Id.Resturant_TextView_Location);
            Resturant_TextView_Location.Click += delegate {
                //موقعیت
                Intent oi = new Intent(this, typeof(LocationActivity));
                StartActivity(oi);
            };
            Resturant_Button_Account = FindViewById<Button>(Resource.Id.Resturant_Button_Account);
            Resturant_Button_Account.Click += delegate {

                //حساب
                Intent oi = new Intent(this, typeof(Account_Activity));
                StartActivity(oi);
            };
            Resturant_Button_Message = FindViewById<Button>(Resource.Id.Resturant_Button_Message);
            Resturant_Button_Message.Click += delegate {

                //پیام
                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
            Resturant_ImageButton_Menu = FindViewById<ImageButton>(Resource.Id.Resturant_ImageButton_Menu);
            Resturant_Button_Basket = FindViewById<Button>(Resource.Id.Resturant_Button_Basket);
            Resturant_Button_Basket.Click += delegate {

                //سبد خرید
                Intent oi = new Intent(this, typeof(Basket_activity));
                StartActivity(oi);
            };
            Resturant_Button_Home = FindViewById<Button>(Resource.Id.Resturant_Button_Home);
            Resturant_Button_Home.Click += delegate {

                //خانه
                Intent oi = new Intent(this, typeof(MainActivity));
                StartActivity(oi);
            };
            Resturant_Listview_LstResturant = FindViewById<ListView>(Resource.Id.Resturant_Listview_LstResturant);
            List<Model.Resturant> FakeListFood = new List<Model.Resturant>
            {
                new Model.Resturant{Job="شیراز_شهرک گلها",Name="فست رستوران" +
                " بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                        new Model.Resturant{Job="شیراز_شهرک گلها",Name="فست رستوران بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                new Model.Resturant{Job="شیراز_شهرک گلها",Name="فست رستوران   بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                        new Model.Resturant{Job="شیراز_شهرک گلها",Name="فست رستوران  بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                new Model.Resturant{Job="شیراز_شهرک گلها",Name="فست رستوران  بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                        new Model.Resturant{Job="شیراز_شهرک گلها",Name="فست رستوران بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                new Model.Resturant{Job="شیراز_شهرک گلها",Name="فست رستوران بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                        new Model.Resturant{Job="شیراز_شهرک گلها",Name="فست رستوران  بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                new Model.Resturant{Job="شیراز_شهرک گلها",Name="فست رستوران بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                        new Model.Resturant{Job="شیراز_شهرک گلها",Name="فست رستوران  بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                new Model.Resturant{Job="شیراز_شهرک گلها",Name="فست رستوران بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                        new Model.Resturant{Job="شیراز_شهرک گلها",Name="فست رستوران  بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                                new Model.Resturant{Job="شیراز_شهرک گلها",Name="فست رستوران بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                                        new Model.Resturant{Job="شیراز_شهرک گلها",Name="فست رستوران  بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                                                new Model.Resturant{Job="شیراز_شهرک گلها",Name="فست رستوران  بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },

            };
           Adapter.Resturant_Adapter adp = new Adapter.Resturant_Adapter(this, FakeListFood);
            Resturant_Listview_LstResturant.Adapter = adp;
            Resturant_Listview_LstResturant.ItemClick += Resturant_Listview_LstResturant_ItemClick;

            // Create your application here


        }

        private void Resturant_Listview_LstResturant_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {

            //انتخاب رستوران انتخاب شده
            Intent oi = new Intent(this, typeof(SelectedItemResturant_Activity));
            StartActivity(oi);
        }
    }
}