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
    [Activity(Label = "FastFood_Activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class FastFood_Activity : AppCompatActivity
    {
        /// <summary>
        /// فست فود
        /// </summary>
        /// <param name="savedInstanceState"></param>
        /// 
        TextView FastFood_TxtView_Header;
        ImageView FastFood_ImageView_Search;
        ImageView FastFood_ImageView_Triangle;

        TextView FastFood_TextView_Location;
        Button FastFood_Button_Account;
        Button FastFood_Button_Message;
        ImageButton FastFood_ImageButton_Menu;
        Button FastFood_Button_Basket;
        Button FastFood_Button_Home;
        ListView FastFood_Listview_LstFastFood;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_fastfood);
            FastFood_TxtView_Header = FindViewById<TextView>(Resource.Id.FastFood_TxtView_Header);
            FastFood_ImageView_Search = FindViewById<ImageView>(Resource.Id.FastFood_ImageView_Search);
            FastFood_ImageView_Search.Click += delegate { };
            FastFood_ImageView_Triangle = FindViewById<ImageView>(Resource.Id.FastFood_ImageView_Triangle);
            FastFood_ImageView_Triangle.Click += delegate { };
            FastFood_TextView_Location = FindViewById<TextView>(Resource.Id.FastFood_TextView_Location);
            FastFood_TextView_Location.Click += delegate {
                //موقعیت
                Intent oi = new Intent(this, typeof(LocationActivity));
                StartActivity(oi);
            };
            FastFood_Button_Account = FindViewById<Button>(Resource.Id.FastFood_Button_Account);
            FastFood_Button_Account.Click += delegate {

                //حساب
                Intent oi = new Intent(this, typeof(Account_Activity));
                StartActivity(oi);
            };
            FastFood_Button_Message = FindViewById<Button>(Resource.Id.FastFood_Button_Message);
            FastFood_Button_Message.Click += delegate {

                //پیام
                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);
            };
            FastFood_ImageButton_Menu = FindViewById<ImageButton>(Resource.Id.FastFood_ImageButton_Menu);
            FastFood_Button_Basket = FindViewById<Button>(Resource.Id.FastFood_Button_Basket);
            FastFood_Button_Basket.Click += delegate {

                //سبد خرید
                Intent oi = new Intent(this, typeof(Basket_activity));
                StartActivity(oi);
            };
            FastFood_Button_Home = FindViewById<Button>(Resource.Id.FastFood_Button_Home);
            FastFood_Button_Home.Click += delegate {

                //خانه
                Intent oi = new Intent(this, typeof(MainActivity));
                StartActivity(oi);
            };
            FastFood_Listview_LstFastFood = FindViewById<ListView>(Resource.Id.FastFood_Listview_LstFastFood);
            List<Model.FastFood> FakeListFood = new List<Model.FastFood>
            {
                new Model.FastFood{Job="شیراز_شهرک گلها",Name="فست فود" +
                " بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                        new Model.FastFood{Job="شیراز_شهرک گلها",Name="فست فود بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                new Model.FastFood{Job="شیراز_شهرک گلها",Name="فست فود بهاران  بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                        new Model.FastFood{Job="شیراز_شهرک گلها",Name="فست فود  بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                new Model.FastFood{Job="شیراز_شهرک گلها",Name="فست فود  بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                        new Model.FastFood{Job="شیراز_شهرک گلها",Name="فست فود  بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                new Model.FastFood{Job="شیراز_شهرک گلها",Name="فست فود  بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                        new Model.FastFood{Job="شیراز_شهرک گلها",Name="فست فود  ",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                new Model.FastFood{Job="شیراز_شهرک گلها",Name="فست فود سنگگی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                        new Model.FastFood{Job="شیراز_شهرک گلها",Name="فست فود سنگگی ",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                new Model.FastFood{Job="شیراز_شهرک گلها",Name="فست فود سنگگی ",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                        new Model.FastFood{Job="شیراز_شهرک گلها",Name="فست فود  بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                                new Model.FastFood{Job="شیراز_شهرک گلها",Name="فست فود سنگگی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                                        new Model.FastFood{Job="شیراز_شهرک گلها",Name="فست فود سنگگی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },
                                                                                                                                new Model.FastFood{Job="شیراز_شهرک گلها",Name="فست فود سنگگی بهاران",Time="ساعت کار:8تا 4بعداز ظهر",Tell="07135895".Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩")
        },

            };
            Adapter.FastFood_adapter adp = new Adapter.FastFood_adapter(this, FakeListFood);
           FastFood_Listview_LstFastFood.Adapter = adp;

            // Create your application here
        }
    }
}