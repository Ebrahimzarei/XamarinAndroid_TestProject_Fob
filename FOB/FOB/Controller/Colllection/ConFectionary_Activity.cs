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
    /// قنادی
    /// </summary>
    [Activity(Label = "Confectionary_Activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]

    public class ConFectionary_Activity : AppCompatActivity
    {

        TextView ConF_TxtView_Header;
        ImageView ConF_ImageView_Search;
        ImageView ConF_ImageView_Triangle;

        TextView ConF_TextView_Location;
        Button ConF_Button_Account;
        Button ConF_Button_Message;
        ImageButton ConF_ImageButton_Menu;
        Button ConFs_Button_Basket;
        Button ConF_Button_Home;
        ListView ConF_Listview_LstAlas;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_confectionary);
              ConF_TxtView_Header = FindViewById<TextView>(Resource.Id.Confectionary_TxtView_Header);
              ConF_ImageView_Search = FindViewById<ImageView>(Resource.Id.Confectionary_ImageView_Search);
              ConF_ImageView_Triangle = FindViewById<ImageView>(Resource.Id.Confectionary_ImageView_Triangle);

              ConF_TextView_Location = FindViewById<TextView>(Resource.Id.Confectionary_TextView_Location);
            ConF_TextView_Location.Click += delegate {
                //موقعیت
                Intent oi = new Intent(this, typeof(LocationActivity));
                StartActivity(oi);
            };
              ConF_Button_Account = FindViewById<Button>(Resource.Id.Confectionary_Button_Account);
            ConF_Button_Account.Click += delegate {
                //حساب
                Intent oi = new Intent(this, typeof(Account_Activity));
                StartActivity(oi);
            };
              ConF_Button_Message = FindViewById<Button>(Resource.Id.Confectionary_Button_Message);
            ConF_Button_Message.Click += delegate {
                //پیام
                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
             ConF_ImageButton_Menu = FindViewById<ImageButton>(Resource.Id.Confectionary_ImageButton_Menu);
             ConFs_Button_Basket = FindViewById<Button>(Resource.Id.Confectionary_Button_Basket);
            ConFs_Button_Basket.Click += delegate {
                //سبد خرید
                Intent oi = new Intent(this, typeof(Basket_activity));
                StartActivity(oi);
            };
             ConF_Button_Home = FindViewById<Button>(Resource.Id.Confectionary_Button_Home);
            ConF_Button_Home.Click += delegate {
                //خانه
                Intent oi = new Intent(this, typeof(MainActivity));
                StartActivity(oi);
            };
             ConF_Listview_LstAlas = FindViewById<ListView>(Resource.Id.Confectionary_Listview_LstConfectionary);
            List<Model.Confectionary> FakeListconf = new List<Model.Confectionary>
            {
                new Model.Confectionary{Job="شیراز_شهرک گلها",Name="قنادی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                        new Model.Confectionary{Job="شیراز_شهرک گلها",Name="قنادی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                new Model.Confectionary{Job="شیراز_شهرک گلها",Name="قنادی بهاران  بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                        new Model.Confectionary{Job="شیراز_شهرک گلها",Name="قنادی  بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                new Model.Confectionary{Job="شیراز_شهرک گلها",Name="قنادی  بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                        new Model.Confectionary{Job="شیراز_شهرک گلها",Name="قنادی  بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                new Model.Confectionary{Job="شیراز_شهرک گلها",Name="قنادی  بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                        new Model.Confectionary{Job="شیراز_شهرک گلها",Name="قنادی  بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                new Model.Confectionary{Job="شیراز_شهرک گلها",Name="قنادی  بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                        new Model.Confectionary{Job="شیراز_شهرک گلها",Name="قنادی سنگگی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                new Model.Confectionary{Job="شیراز_شهرک گلها",Name="قنادی  بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                        new Model.Confectionary{Job="شیراز_شهرک گلها",Name="قنادی  بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                                new Model.Confectionary{Job="شیراز_شهرک گلها",Name="قنادی  بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                                        new Model.Confectionary{Job="شیراز_شهرک گلها",Name="قنادی  بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                                                new Model.Confectionary{Job="شیراز_شهرک گلها",Name="قنادی  بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },

            };
            Adapter.Confectionary_Adapter adp = new Adapter.Confectionary_Adapter(this, FakeListconf);
            ConF_Listview_LstAlas.Adapter = adp;
        }
    }
}