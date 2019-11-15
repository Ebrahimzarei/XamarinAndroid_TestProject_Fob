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
    /// نوشیدنی
    /// </summary>
    [Activity(Label = "Drink_Activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]

    public class Drink_Activity : AppCompatActivity
    {
        TextView drink_TxtView_Header;
        ImageView drink_ImageView_Search;
        ImageView drink_ImageView_Triangle;

        TextView drink_TextView_Location;
        Button drink_Button_Account;
        Button drink_Button_Message;
        ImageButton drink_ImageButton_Menu;
        Button drink_Button_Basket;
        Button drink_Button_Home;
        ListView drink_Listview_Lstdrink;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_drinks);
            drink_TxtView_Header = FindViewById<TextView>(Resource.Id.drink_TxtView_Header);
            drink_ImageView_Search = FindViewById<ImageView>(Resource.Id.drink_ImageView_Search);
            drink_ImageView_Search.Click += delegate { };
            drink_ImageView_Triangle = FindViewById<ImageView>(Resource.Id.drink_ImageView_Triangle);
            drink_ImageView_Triangle.Click += delegate { };
            drink_TextView_Location = FindViewById<TextView>(Resource.Id.drink_TextView_Location);
            drink_TextView_Location.Click += delegate {
                //موقعیت
                Intent oi = new Intent(this, typeof(LocationActivity));
                StartActivity(oi);
            };
            drink_Button_Account = FindViewById<Button>(Resource.Id.drink_Button_Account);
            drink_Button_Account.Click += delegate {

                //حساب
                Intent oi = new Intent(this, typeof(Account_Activity));
                StartActivity(oi);
            };
            drink_Button_Message = FindViewById<Button>(Resource.Id.drink_Button_Message);
            drink_Button_Message.Click += delegate {

                //پیام
                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
            drink_ImageButton_Menu = FindViewById<ImageButton>(Resource.Id.drink_ImageButton_Menu);
            drink_Button_Basket = FindViewById<Button>(Resource.Id.drink_Button_Basket);
            drink_Button_Basket.Click += delegate {

                //سبد خرید
                Intent oi = new Intent(this, typeof(Basket_activity));
                StartActivity(oi);
            };
            drink_Button_Home = FindViewById<Button>(Resource.Id.drink_Button_Home);
            drink_Button_Home.Click += delegate {

                //خانه
                Intent oi = new Intent(this, typeof(MainActivity));
                StartActivity(oi);
            };
            drink_Listview_Lstdrink = FindViewById<ListView>(Resource.Id.drink_Listview_Lstdrink);
            List<Model.Drink> FakeListDrinke = new List<Model.Drink>
            {
                new Model.Drink{Job="شیراز_شهرک گلها",Name="قنادی" +
                " بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                        new Model.Drink{Job="شیراز_شهرک گلها",Name="کافه دلهای بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                new Model.Drink{Job="شیراز_شهرک گلها",Name="کافه دلهای بهاران ",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                        new Model.Drink{Job="شیراز_شهرک گلها",Name="کافه دلها",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                new Model.Drink{Job="شیراز_شهرک گلها",Name="کافه تنها",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                        new Model.Drink{Job="شیراز_شهرک گلها",Name="کافه شب بندر",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                new Model.Drink{Job="شیراز_شهرک گلها",Name="کافه دلها",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                        new Model.Drink{Job="شیراز_شهرک گلها",Name="کافه رویا",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                new Model.Drink{Job="شیراز_شهرک گلها",Name="کافه شازده",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                        new Model.Drink{Job="شیراز_شهرک گلها",Name="کافه غروب",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                new Model.Drink{Job="شیراز_شهرک گلها",Name="کافه طلوع",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                        new Model.Drink{Job="شیراز_شهرک گلها",Name="کافه اسلام",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                                new Model.Drink{Job="شیراز_شهرک گلها",Name="کافه بی نام",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                                        new Model.Drink{Job="شیراز_شهرک گلها",Name="کافه نامدار",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                                                new Model.Drink{Job="شیراز_شهرک گلها",Name="کافه سنگگی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },

            };
            Adapter.Drink_Adapter adp = new Adapter.Drink_Adapter(this, FakeListDrinke);
           drink_Listview_Lstdrink.Adapter = adp;
        }
    }
}