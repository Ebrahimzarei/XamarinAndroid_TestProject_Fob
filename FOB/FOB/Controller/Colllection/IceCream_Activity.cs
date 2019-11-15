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
    [Activity(Label = "IceCreame_Activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class IceCream_Activity : AppCompatActivity
    {
        /// <summary>
        /// بستنی
        /// </summary>
        /// <param name="savedInstanceState"></param>
        /// 
        TextView IceCreame_TxtView_Header;
        ImageView IceCreame_ImageView_Search;
        ImageView IceCreame_ImageView_Triangle;

        TextView IceCreame_TextView_Location;
        Button IceCreame_Button_Account;
        Button IceCreame_Button_Message;
        ImageButton IceCreame_ImageButton_Menu;
        Button IceCreame_Button_Basket;
        Button IceCreame_Button_Home;
        ListView IceCreame_Listview_LstIceCreame;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_icecreams);
            IceCreame_TxtView_Header = FindViewById<TextView>(Resource.Id.IceCreame_TxtView_Header);
            IceCreame_ImageView_Search = FindViewById<ImageView>(Resource.Id.IceCreame_ImageView_Search);
            IceCreame_ImageView_Search.Click += delegate { };
            IceCreame_ImageView_Triangle = FindViewById<ImageView>(Resource.Id.IceCreame_ImageView_Triangle);
            IceCreame_ImageView_Triangle.Click += delegate { };
            IceCreame_TextView_Location = FindViewById<TextView>(Resource.Id.IceCreame_TextView_Location);
            IceCreame_TextView_Location.Click += delegate {
                //موقعیت
                Intent oi = new Intent(this, typeof(LocationActivity));
                StartActivity(oi);
            };
            IceCreame_Button_Account = FindViewById<Button>(Resource.Id.IceCreame_Button_Account);
            IceCreame_Button_Account.Click += delegate {

                //حساب
                Intent oi = new Intent(this, typeof(Account_Activity));
                StartActivity(oi);
            };
            IceCreame_Button_Message = FindViewById<Button>(Resource.Id.IceCreame_Button_Message);
            IceCreame_Button_Message.Click += delegate {

                //پیام
                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
            IceCreame_ImageButton_Menu = FindViewById<ImageButton>(Resource.Id.IceCreame_ImageButton_Menu);
            IceCreame_Button_Basket = FindViewById<Button>(Resource.Id.IceCreame_Button_Basket);
            IceCreame_Button_Basket.Click += delegate {

                //سبد خرید
                Intent oi = new Intent(this, typeof(Basket_activity));
                StartActivity(oi);
            };
            IceCreame_Button_Home = FindViewById<Button>(Resource.Id.IceCreame_Button_Home);
            IceCreame_Button_Home.Click += delegate {

                //خانه
                Intent oi = new Intent(this, typeof(MainActivity));
                StartActivity(oi);
            };
            IceCreame_Listview_LstIceCreame = FindViewById<ListView>(Resource.Id.IceCreame_Listview_LstIceCreame);
            List<Model.ICeCreame> FakeListFood = new List<Model.ICeCreame>
            {
                new Model.ICeCreame{Job="شیراز_شهرک گلها",Name="بستنی" +
                " بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                        new Model.ICeCreame{Job="شیراز_شهرک گلها",Name="بستنی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                new Model.ICeCreame{Job="شیراز_شهرک گلها",Name="بستنی بهاران  ",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                        new Model.ICeCreame{Job="شیراز_شهرک گلها",Name="بستنی  جنوب",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                new Model.ICeCreame{Job="شیراز_شهرک گلها",Name="فالوده شیراز",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                        new Model.ICeCreame{Job="شیراز_شهرک گلها",Name="فالوده سنگگی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                new Model.ICeCreame{Job="شیراز_شهرک گلها",Name="فالوده ناصری بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                        new Model.ICeCreame{Job="شیراز_شهرک گلها",Name="بستنی کاظمی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                new Model.ICeCreame{Job="شیراز_شهرک گلها",Name="بستنی شیرازی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                        new Model.ICeCreame{Job="شیراز_شهرک گلها",Name="بستنی مشهدی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                new Model.ICeCreame{Job="شیراز_شهرک گلها",Name="بستنی سنگگی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                        new Model.ICeCreame{Job="شیراز_شهرک گلها",Name="بستنی سنگگی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                                new Model.ICeCreame{Job="شیراز_شهرک گلها",Name="بستنی سنگگی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                                        new Model.ICeCreame{Job="شیراز_شهرک گلها",Name="بستنی سنگگی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                                                new Model.ICeCreame{Job="شیراز_شهرک گلها",Name="بستنی سنگگی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },

            };
            Adapter.IceCreame_Adapter adp = new Adapter.IceCreame_Adapter(this, FakeListFood);
            IceCreame_Listview_LstIceCreame.Adapter = adp;

            // Create your application here
        }
    }
}