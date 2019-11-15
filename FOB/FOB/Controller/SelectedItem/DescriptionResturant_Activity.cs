using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using FOB.Model;

namespace FOB.Controller.SelectedItem
{
    [Activity(Label = "DescriptionResturant_Activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class DescriptionResturant_Activity : AppCompatActivity
    {
        Button SelectedDescriptionResturant_Button_NameResturant;
        TextView SelectedDescriptionResturant_TextView_UnitRiyal;
        TextView SelectedDescriptionResturant_Button_Count;
        TextView SelectedDescriptionResturant_Button_AllPrice;
        Button SelectedDescriptionResturant_Button_Back;
        Button SelectedDescriptionResturant_Button_Deser;
        Button SelectedDescriptionResturant_Button_Lunch;
        Button SelectedDescriptionResturant_Button_Drink;
        ListView SelectedDescriptionResturant_ListView_ItemResturant;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);


       

      
            SetContentView(Resource.Layout.Activity_DescriptionResturant);
              SelectedDescriptionResturant_Button_NameResturant = FindViewById<Button>(Resource.Id.SelectedDescriptionResturant_Button_NameResturant);
            SelectedDescriptionResturant_Button_NameResturant.Text = "رستوران بهاران شیراز";

              SelectedDescriptionResturant_TextView_UnitRiyal = FindViewById<TextView>(Resource.Id.SelectedDescriptionResturant_TextView_UnitRiyal);

              SelectedDescriptionResturant_Button_Count = FindViewById<TextView>(Resource.Id.SelectedDescriptionResturant_Button_Count);

              SelectedDescriptionResturant_Button_AllPrice = FindViewById<TextView>(Resource.Id.SelectedDescriptionResturant_Button_AllPrice);
              SelectedDescriptionResturant_Button_Back = FindViewById<Button>(Resource.Id.SelectedDescriptionResturant_Button_Back);
            SelectedDescriptionResturant_Button_Back.Click += delegate {

                //رفتن به سبد فوب

                var intent = new Intent(this, typeof(Basket_activity));
                StartActivity(intent);
              
            };
              SelectedDescriptionResturant_Button_Deser = FindViewById<Button>(Resource.Id.SelectedDescriptionResturant_Button_Deser);
            SelectedDescriptionResturant_Button_Deser.Click += delegate { };
              SelectedDescriptionResturant_Button_Lunch = FindViewById<Button>(Resource.Id.SelectedDescriptionResturant_Button_Lunch);
            SelectedDescriptionResturant_Button_Lunch.Click += delegate { };
              SelectedDescriptionResturant_Button_Drink = FindViewById<Button>(Resource.Id.SelectedDescriptionResturant_Button_Drink);
            SelectedDescriptionResturant_Button_Drink.Click += delegate { };
              SelectedDescriptionResturant_ListView_ItemResturant = FindViewById<ListView>(Resource.Id.SelectedDescriptionResturant_ListView_ItemResturant);
          
            List<Specifications_Resturant> _lstFake = new List<Specifications_Resturant>()
        {
            new Specifications_Resturant{Id=1,ItemOne="شرح ",ItemTwo="قیمت",ItemThree="تخفیف"},
             new Specifications_Resturant{Id=2,ItemOne="شرح",ItemTwo="قیمت",ItemThree="تخفیف"},
                new Specifications_Resturant{Id=3,ItemOne="شرح ",ItemTwo="قیمت",ItemThree="تخفیف "},

        };
            SelectedDescriptionResturant_ListView_ItemResturant.Adapter = new Adapter.Adapter_SelectedItemResturant(this, _lstFake);
            SelectedDescriptionResturant_ListView_ItemResturant.Clickable = true;
           

        }

   

       
    }
}