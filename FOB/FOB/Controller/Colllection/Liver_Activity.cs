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
    [Activity(Label = "Liver_Activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class Liver_Activity : AppCompatActivity
    {
        /// <summary>
        /// جگرکی
        /// </summary>
        /// <param name="savedInstanceState"></param>
        /// 
        TextView Liver_TxtView_Header;
        ImageView Liver_ImageView_Search;
        ImageView Liver_ImageView_Triangle;

        TextView Liver_TextView_Location;
        Button Liver_Button_Account;
        Button Liver_Button_Message;
        ImageButton Liver_ImageButton_Menu;
        Button Liver_Button_Basket;
        Button Liver_Button_Home;
        ListView Liver_Listview_LstLiver;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_liver);
            Liver_TxtView_Header = FindViewById<TextView>(Resource.Id.Liver_TxtView_Header);
            Liver_ImageView_Search = FindViewById<ImageView>(Resource.Id.Liver_ImageView_Search);
            Liver_ImageView_Search.Click += delegate { };
            Liver_ImageView_Triangle = FindViewById<ImageView>(Resource.Id.Liver_ImageView_Triangle);
            Liver_ImageView_Triangle.Click += delegate { };
            Liver_TextView_Location = FindViewById<TextView>(Resource.Id.Liver_TextView_Location);
            Liver_TextView_Location.Click += delegate {
                //موقعیت
                Intent oi = new Intent(this, typeof(LocationActivity));
                StartActivity(oi);
            };
            Liver_Button_Account = FindViewById<Button>(Resource.Id.Liver_Button_Account);
            Liver_Button_Account.Click += delegate {

                //حساب
                Intent oi = new Intent(this, typeof(Account_Activity));
                StartActivity(oi);
            };
            Liver_Button_Message = FindViewById<Button>(Resource.Id.Liver_Button_Message);
            Liver_Button_Message.Click += delegate {

                //پیام
                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
            Liver_ImageButton_Menu = FindViewById<ImageButton>(Resource.Id.Liver_ImageButton_Menu);
            Liver_Button_Basket = FindViewById<Button>(Resource.Id.Liver_Button_Basket);
            Liver_Button_Basket.Click += delegate {

                //سبد خرید
                Intent oi = new Intent(this, typeof(Basket_activity));
                StartActivity(oi);
            };
            Liver_Button_Home = FindViewById<Button>(Resource.Id.Liver_Button_Home);
            Liver_Button_Home.Click += delegate {

                //خانه
                Intent oi = new Intent(this, typeof(MainActivity));
                StartActivity(oi);
            };
            Liver_Listview_LstLiver = FindViewById<ListView>(Resource.Id.Liver_Listview_LstLiver);
            List<Model.Liver> FakeListLiver = new List<Model.Liver>
            {
                new Model.Liver{Job="شیراز_شهرک گلها",Name="فست فود" +
                " بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                        new Model.Liver{Job="شیراز_شهرک گلها",Name="جگرکی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                new Model.Liver{Job="شیراز_شهرک گلها",Name="جگرکی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                        new Model.Liver{Job="شیراز_شهرک گلها",Name="جگرکی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                new Model.Liver{Job="شیراز_شهرک گلها",Name="جگرکی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                        new Model.Liver{Job="شیراز_شهرک گلها",Name="جگرکی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                new Model.Liver{Job="شیراز_شهرک گلها",Name="جگرکی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                        new Model.Liver{Job="شیراز_شهرک گلها",Name="جگرکی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                new Model.Liver{Job="شیراز_شهرک گلها",Name="جگرکی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                        new Model.Liver{Job="شیراز_شهرک گلها",Name="جگرکی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                new Model.Liver{Job="شیراز_شهرک گلها",Name="جگرکی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                        new Model.Liver{Job="شیراز_شهرک گلها",Name="جگرکی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                                new Model.Liver{Job="شیراز_شهرک گلها",Name="جگرکی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                                        new Model.Liver{Job="شیراز_شهرک گلها",Name="جگرکی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                                                new Model.Liver{Job="شیراز_شهرک گلها",Name="جگرکی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },

            };
            Adapter.Liver_Adapter adp = new Adapter.Liver_Adapter(this, FakeListLiver);
            Liver_Listview_LstLiver.Adapter = adp;
            // Create your application here
        }
    }
}