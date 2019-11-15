using System;
using System.Collections.Generic;
using Android.Content;
using Android.Support.V4.App;



namespace FOB.Controller.Fragment.AdapterFragment
{
  public  class TabFragmentAdapter : FragmentPagerAdapter
    {
        Context context;

        
        public TabFragmentAdapter(FragmentManager fm, Context ctx) : base(fm)
        {
            context = ctx;
        }
        public override int Count => 2;

        public override Android.Support.V4.App.Fragment GetItem(int position)
        {
               switch (position)
                {
                    case 0: return new Fragment_Promos(context);
                    case 1: return new Fragment_MyCouponse();
                 
                    default: return new Fragment_Promos(context);
               }
        }


        //public override Fragment GetItem(int position)
        //{
        //    switch (position)
        //    {
        //        case 0: return new Fragment_Promos();
        //        case 1: return new Fragment_MyCouponse();
        //        case 2: return new Fragment_MyCouponse();
        //        default: return new Fragment_Promos();
        //    }
        //}



        //int f1() { return 100; }
        //int f1 => 100;
    }
}