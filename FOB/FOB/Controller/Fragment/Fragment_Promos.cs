using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace FOB.Controller.Fragment
{
    public class Fragment_Promos : Android.Support.V4.App.Fragment
    {
        /// <summary>
        /// سبد خرید
        /// </summary>
        /// <param name="savedInstanceState"></param>
        /// 
        TextView FragmentPromose_TextView_TextHeader;
        Button FragmentPromose_Button_Payed;
        ListView FragmentPromose_ListView_MylstPromose;
        TextView FragmentPromose_TextView_Rial;
        TextView FragmentPromose_TextView_Count;
        TextView FragmentPromose_TextView_AllPrice;
        Button FragmentPromose_Button_VerifyResturant;
        Button FragmentPromose_Button_VerifyUser;
        Context Context;
        public Fragment_Promos(Context ctx)
        {
            Context = ctx;
        }
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }
        public override View OnCreateView(LayoutInflater inflater,
            ViewGroup container, Bundle savedInstanceState)
        {
            var view= inflater.Inflate(Resource.Layout.Fragment_Promos, container, false);
             FragmentPromose_TextView_TextHeader=view.FindViewById<TextView>(Resource.Id.FragmentPromose_TextView_TextHeader);
             FragmentPromose_Button_Payed = view.FindViewById<Button>(Resource.Id.FragmentPromose_Button_Payed);
            FragmentPromose_Button_Payed.Click += delegate { };
             FragmentPromose_ListView_MylstPromose = view.FindViewById<ListView>(Resource.Id.FragmentPromose_ListView_MylstPromose);
             FragmentPromose_TextView_Rial = view.FindViewById<TextView>(Resource.Id.FragmentPromose_TextView_Rial);
             FragmentPromose_TextView_Count = view.FindViewById<TextView>(Resource.Id.FragmentPromose_TextView_Count);
             FragmentPromose_TextView_AllPrice = view.FindViewById<TextView>(Resource.Id.FragmentPromose_TextView_AllPrice);
             FragmentPromose_Button_VerifyResturant = view.FindViewById<Button>(Resource.Id.FragmentPromose_Button_VerifyResturant);
            FragmentPromose_Button_VerifyResturant.Click += delegate { };
             FragmentPromose_Button_VerifyUser = view.FindViewById<Button>(Resource.Id.FragmentPromose_Button_VerifyUser);
            FragmentPromose_Button_VerifyUser.Click += delegate { };
            FragmentPromose_ListView_MylstPromose.Adapter = new FOB.Controller.SelectedItem.Adapter.Adapter_PromosResturant(Context, fakelst);


            return view;
        }
        List<Model.Promose_Resturant> fakelst = new List<Model.Promose_Resturant> {
            new Model.Promose_Resturant{Id=0,ItemOne="شرح",ItemTwo="10000",ItemThree="100000"},
            new Model.Promose_Resturant{Id=0,ItemOne="شرح",ItemTwo="10000",ItemThree="100000"},
            new Model.Promose_Resturant{Id=0,ItemOne="شرح",ItemTwo="10000",ItemThree="100000"},
            new Model.Promose_Resturant{Id=0,ItemOne="شرح",ItemTwo="10000",ItemThree="100000"},
            new Model.Promose_Resturant{Id=0,ItemOne="شرح",ItemTwo="10000",ItemThree="100000"},


        };
    }
}