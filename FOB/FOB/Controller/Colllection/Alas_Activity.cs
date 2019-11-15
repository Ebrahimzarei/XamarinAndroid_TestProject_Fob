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
    /// آش
    /// </summary>
    [Activity(Label = "Alas_Activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class Alas_Activity : AppCompatActivity
    {
        TextView Alas_TxtView_Header;
        ImageView Alas_ImageView_Search;
        ImageView Alas_ImageView_Triangle;

        TextView Alas_TextView_Location;
        Button Alas_Button_Account;
        Button Alas_Button_Message;
        ImageButton Alas_ImageButton_Menu;
        Button Alas_Button_Basket;
        Button Alas_Button_Home;
        ListView Alas_Listview_LstAlas;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Activity_Alas);
          
             Alas_TxtView_Header =FindViewById<TextView>(Resource.Id.Alas_TxtView_Header);
             Alas_ImageView_Search = FindViewById<ImageView>(Resource.Id.Alas_ImageView_Search);
            Alas_ImageView_Search.Click += delegate { };
              Alas_ImageView_Triangle = FindViewById<ImageView>(Resource.Id.Alas_ImageView_Triangle);
            Alas_ImageView_Triangle.Click += delegate{ };
             Alas_TextView_Location = FindViewById<TextView>(Resource.Id.Alas_TextView_Location);
            Alas_TextView_Location.Click += delegate {
                //موقعیت
                Intent oi = new Intent(this, typeof(LocationActivity));
                StartActivity(oi);
            };
             Alas_Button_Account = FindViewById<Button>(Resource.Id.Alas_Button_Account);
            Alas_Button_Account.Click += delegate {

                //حساب
                Intent oi = new Intent(this, typeof(Account_Activity));
                StartActivity(oi);
            };
             Alas_Button_Message = FindViewById<Button>(Resource.Id.Alas_Button_Message);
            Alas_Button_Message.Click += delegate {

                //پیام
                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
             Alas_ImageButton_Menu = FindViewById<ImageButton>(Resource.Id.Alas_ImageButton_Menu);
             Alas_Button_Basket = FindViewById<Button>(Resource.Id.Alas_Button_Basket);
            Alas_Button_Basket.Click += delegate {

                //سبد خرید
                Intent oi = new Intent(this, typeof(Basket_activity));
                StartActivity(oi);
            };
             Alas_Button_Home = FindViewById<Button>(Resource.Id.Alas_Button_Home);
            Alas_Button_Home.Click += delegate {

                //خانه
                Intent oi = new Intent(this, typeof(MainActivity));
                StartActivity(oi);
            };
             Alas_Listview_LstAlas = FindViewById<ListView>(Resource.Id.Alas_Listview_LstAlas);
            List<Model.Alas> FakeListAlase = new List<Model.Alas>
            {
                new Model.Alas{Job="شیراز_شهرک گلها",Name="آشی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                        new Model.Alas{Job="شیراز_شهرک گلها",Name="آشی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                new Model.Alas{Job="شیراز_شهرک گلها",Name="آشی بهاران سنگگی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                        new Model.Alas{Job="شیراز_شهرک گلها",Name="آشی سنگگی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                new Model.Alas{Job="شیراز_شهرک گلها",Name="آشی سنگگی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                        new Model.Alas{Job="شیراز_شهرک گلها",Name="آشی سنگگی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                new Model.Alas{Job="شیراز_شهرک گلها",Name="آشی سنگگی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                        new Model.Alas{Job="شیراز_شهرک گلها",Name="آشی سنگگی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                new Model.Alas{Job="شیراز_شهرک گلها",Name="آشی سنگگی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                        new Model.Alas{Job="شیراز_شهرک گلها",Name="آشی سنگگی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                new Model.Alas{Job="شیراز_شهرک گلها",Name="آشی سنگگی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                        new Model.Alas{Job="شیراز_شهرک گلها",Name="آشی سنگگی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                                new Model.Alas{Job="شیراز_شهرک گلها",Name="آشی سنگگی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                                        new Model.Alas{Job="شیراز_شهرک گلها",Name="آشی سنگگی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                                                new Model.Alas{Job="شیراز_شهرک گلها",Name="آشی سنگگی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },

            };
            Adapter.Alas_Adapter adp = new Adapter.Alas_Adapter(this, FakeListAlase);
            Alas_Listview_LstAlas.Adapter = adp;
            


        }
    }
}