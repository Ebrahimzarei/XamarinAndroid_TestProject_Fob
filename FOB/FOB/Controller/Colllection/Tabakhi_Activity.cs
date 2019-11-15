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
    [Activity(Label = "Tabakhi_Activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class Tabakhi_Activity : AppCompatActivity
    {
        /// <summary>
        /// طباخی
        /// </summary>
        /// <param name="savedInstanceState"></param>
        /// 
        TextView Tabakhi_TxtView_Header;
        ImageView Tabakhi_ImageView_Search;
        ImageView Tabakhi_ImageView_Triangle;

        TextView Tabakhi_TextView_Location;
        Button Tabakhi_Button_Account;
        Button Tabakhi_Button_Message;
        ImageButton Tabakhi_ImageButton_Menu;
        Button Tabakhi_Button_Basket;
        Button Tabakhi_Button_Home;
        ListView Tabakhi_Listview_LstTabakhi;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_tabakhi);
            Tabakhi_TxtView_Header = FindViewById<TextView>(Resource.Id.Tabakhi_TxtView_Header);
            Tabakhi_ImageView_Search = FindViewById<ImageView>(Resource.Id.Tabakhi_ImageView_Search);
            Tabakhi_ImageView_Search.Click += delegate { };
            Tabakhi_ImageView_Triangle = FindViewById<ImageView>(Resource.Id.Tabakhi_ImageView_Triangle);
            Tabakhi_ImageView_Triangle.Click += delegate { };
            Tabakhi_TextView_Location = FindViewById<TextView>(Resource.Id.Tabakhi_TextView_Location);
            Tabakhi_TextView_Location.Click += delegate {
                //موقعیت
                Intent oi = new Intent(this, typeof(LocationActivity));
                StartActivity(oi);
            };
            Tabakhi_Button_Account = FindViewById<Button>(Resource.Id.Tabakhi_Button_Account);
            Tabakhi_Button_Account.Click += delegate {

                //حساب
                Intent oi = new Intent(this, typeof(Account_Activity));
                StartActivity(oi);
            };
            Tabakhi_Button_Message = FindViewById<Button>(Resource.Id.Tabakhi_Button_Message);
            Tabakhi_Button_Message.Click += delegate {

                //پیام
                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
            Tabakhi_ImageButton_Menu = FindViewById<ImageButton>(Resource.Id.Tabakhi_ImageButton_Menu);
            Tabakhi_Button_Basket = FindViewById<Button>(Resource.Id.Tabakhi_Button_Basket);
            Tabakhi_Button_Basket.Click += delegate {

                //سبد خرید
                Intent oi = new Intent(this, typeof(Basket_activity));
                StartActivity(oi);
            };
            Tabakhi_Button_Home = FindViewById<Button>(Resource.Id.Tabakhi_Button_Home);
            Tabakhi_Button_Home.Click += delegate {

                //خانه
                Intent oi = new Intent(this, typeof(MainActivity));
                StartActivity(oi);
            };
            Tabakhi_Listview_LstTabakhi = FindViewById<ListView>(Resource.Id.Tabakhi_Listview_LstTabakhi);
            List<Model.Tabbalhi> FakeListTabakhi = new List<Model.Tabbalhi>
            {
                new Model.Tabbalhi{Job="شیراز_شهرک گلها",Name="فست طباخی" +
                " بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                        new Model.Tabbalhi{Job="شیراز_شهرک گلها",Name="فست طباخی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                new Model.Tabbalhi{Job="شیراز_شهرک گلها",Name="فست طباخی ",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                        new Model.Tabbalhi{Job="شیراز_شهرک گلها",Name="فست طباخی  بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                new Model.Tabbalhi{Job="شیراز_شهرک گلها",Name="فست طباخی  بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                        new Model.Tabbalhi{Job="شیراز_شهرک گلها",Name="فست طباخی  بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                new Model.Tabbalhi{Job="شیراز_شهرک گلها",Name="فست طباخی  بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                        new Model.Tabbalhi{Job="شیراز_شهرک گلها",Name="فست طباخی   بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                new Model.Tabbalhi{Job="شیراز_شهرک گلها",Name="فست طباخی   بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                        new Model.Tabbalhi{Job="شیراز_شهرک گلها",Name="فست طباخی   بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                new Model.Tabbalhi{Job="شیراز_شهرک گلها",Name="فست طباخی   بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                        new Model.Tabbalhi{Job="شیراز_شهرک گلها",Name="فست طباخی   بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                                new Model.Tabbalhi{Job="شیراز_شهرک گلها",Name="فست طباخی   بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                                        new Model.Tabbalhi{Job="شیراز_شهرک گلها",Name="فست طباخی   بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                                                new Model.Tabbalhi{Job="شیراز_شهرک گلها",Name="فست طباخی   بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },

            };
            Adapter.Tabakhi_Adapter adp = new Adapter.Tabakhi_Adapter(this, FakeListTabakhi);
           Tabakhi_Listview_LstTabakhi.Adapter = adp;

            // Create your application here
        }
    }
}