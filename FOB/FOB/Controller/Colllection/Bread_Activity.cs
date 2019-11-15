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
    /// نون
    /// </summary>
    [Activity(Label = "Breads_Activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class Bread_Activity : AppCompatActivity
    {
        TextView Bread_TxtView_Header;
        ImageView Bread_ImageView_Search;
        ImageView Bread_ImageView_Triangle;

        TextView Bread_TextView_Location;
        Button Bread_Button_Account;
        Button Bread_Button_Message;
        ImageButton Bread_ImageButton_Menu;
        Button Bread_Button_Basket;
        Button Bread_Button_Home;
        ListView Bread_Listview_LstBread;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Activity_Breads);
            Bread_TxtView_Header = FindViewById<TextView>(Resource.Id.Bread_TxtView_Header);
            Bread_ImageView_Search = FindViewById<ImageView>(Resource.Id.Bread_ImageView_Search);
            Bread_ImageView_Search.Click += delegate { };
            Bread_ImageView_Triangle = FindViewById<ImageView>(Resource.Id.Bread_ImageView_Triangle);
            Bread_ImageView_Triangle.Click += delegate { };
            Bread_TextView_Location = FindViewById<TextView>(Resource.Id.Bread_TextView_Location);
            Bread_TextView_Location.Click += delegate { };
            Bread_Button_Account = FindViewById<Button>(Resource.Id.Bread_Button_Account);
            Bread_Button_Account.Click += delegate {

                //حساب
                Intent oi = new Intent(this, typeof(Account_Activity));
                StartActivity(oi);
            };
            Bread_Button_Message = FindViewById<Button>(Resource.Id.Bread_Button_Message);
            Bread_Button_Message.Click += delegate {

                //پیام
                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
            Bread_ImageButton_Menu = FindViewById<ImageButton>(Resource.Id.Bread_ImageButton_Menu);
            Bread_Button_Basket = FindViewById<Button>(Resource.Id.Bread_Button_Basket);
            Bread_Button_Basket.Click += delegate {

                //سبد خرید
                Intent oi = new Intent(this, typeof(Basket_activity));
                StartActivity(oi);
            };
            Bread_Button_Home = FindViewById<Button>(Resource.Id.Bread_Button_Home);
            Bread_Button_Home.Click += delegate {

                //خانه
                Intent oi = new Intent(this, typeof(MainActivity));
                StartActivity(oi);
            };
            Bread_Listview_LstBread = FindViewById<ListView>(Resource.Id.Bread_Listview_LstBread);
            List<Model.Bread> FakeListBreade = new List<Model.Bread>
            {
                new Model.Bread{Job="شیراز_شهرک گلها",Name="نان سنگگی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                        new Model.Bread{Job="شیراز_شهرک گلها",Name="نان ماشینی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                new Model.Bread{Job="شیراز_شهرک گلها",Name="نان فانتزی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                        new Model.Bread{Job="شیراز_شهرک گلها",Name="نان محلی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                new Model.Bread{Job="شیراز_شهرک گلها",Name="نان صنعتی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                        new Model.Bread{Job="شیراز_شهرک گلها",Name="نان سنگگی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                new Model.Bread{Job="شیراز_شهرک گلها",Name="نان سنگگی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                        new Model.Bread{Job="شیراز_شهرک گلها",Name="نان سنگگی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                new Model.Bread{Job="شیراز_شهرک گلها",Name="نان سنگگی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                        new Model.Bread{Job="شیراز_شهرک گلها",Name="نان سنگگی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                new Model.Bread{Job="شیراز_شهرک گلها",Name="نان سنگگی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                        new Model.Bread{Job="شیراز_شهرک گلها",Name="نان سنگگی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                                new Model.Bread{Job="شیراز_شهرک گلها",Name="نان سنگگی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                                        new Model.Bread{Job="شیراز_شهرک گلها",Name="نان سنگگی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                                                new Model.Bread{Job="شیراز_شهرک گلها",Name="نان سنگگی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },

            };
            Adapter.Bread_Adapter adp = new Adapter.Bread_Adapter(this, FakeListBreade);
            Bread_Listview_LstBread.Adapter = adp;
        }
    }
}