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
using FOB.Model;

namespace FOB.Controller.SelectedItem
{
    [Activity(Label = "SelectedItemResturant_Activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class SelectedItemResturant_Activity : AppCompatActivity
    {
        Button SelectedItemResturant_Button_NameResturant;
        Button SelectedItemResturant_Button_Back;
        ViewPager SelectedItemResturant_ViewPager_ImageResturant;
        ListView SelectedItemResturant_ListView_ItemResturant;
        TabLayout SelectedItemResturant_TabLayout_MyTab;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Activity_SelectItemResturant);
             SelectedItemResturant_Button_NameResturant = FindViewById<Button>(Resource.Id.SelectedItemResturant_Button_NameResturant);
             SelectedItemResturant_Button_Back = FindViewById<Button>(Resource.Id.SelectedItemResturant_Button_Back);
             SelectedItemResturant_Button_Back.Click += delegate { Finish(); };
             SelectedItemResturant_ViewPager_ImageResturant = FindViewById<ViewPager>(Resource.Id.SelectedItemResturant_ViewPager_ImageResturant);
            SelectedItemResturant_ViewPager_ImageResturant.Adapter = new imageAdapter(this);
            SelectedItemResturant_ListView_ItemResturant = FindViewById<ListView>(Resource.Id.SelectedItemResturant_ListView_ItemResturant);
            SelectedItemResturant_ListView_ItemResturant.Adapter = new Adapter.Adapter_DescriptionResturant(this, _lstFake);
             SelectedItemResturant_TabLayout_MyTab = FindViewById<TabLayout>(Resource.Id.SelectedItemResturant_TabLayout_MyTab);
          //  SelectedItemResturant_TabLayout_MyTab.SetupWithViewPager(SelectedItemResturant_ViewPager_ImageResturant, true);
            // Create your application here
            SelectedItemResturant_ListView_ItemResturant.ItemClick += SelectedItemResturant_ListView_ItemResturant_ItemClick;
        }

        private void SelectedItemResturant_ListView_ItemResturant_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var intent = new Intent(this, typeof(DescriptionResturant_Activity));
            StartActivity(intent);
         

        }

        List<Description_Resturant> _lstFake = new List<Description_Resturant>()
        {
            new Description_Resturant{Id=1,ItemOne="مشخصات ",ItemTwo="مشخصات",ItemThree="مشخصات"},
             new Description_Resturant{Id=2,ItemOne="مشخصات",ItemTwo="مشخصات",ItemThree="مشخصات"},
                new Description_Resturant{Id=3,ItemOne="مشخصات ",ItemTwo="مشخصات",ItemThree="مشخصات "},

        };
        

        //  DescriptionResturant_Activity
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