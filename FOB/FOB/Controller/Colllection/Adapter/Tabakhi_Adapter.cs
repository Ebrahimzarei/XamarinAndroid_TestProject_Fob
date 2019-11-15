﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using FOB.Model;

namespace FOB.Controller.Colllection.Adapter
{
    class Tabakhi_Adapter : BaseAdapter
    {

        Context context;
        private List<Model.Tabbalhi> Lst_tabakhi;

        public Tabakhi_Adapter(Context context,List<Tabbalhi> lst_tabakhi)
        {
            this.context = context;
            this.Lst_tabakhi = lst_tabakhi;
        }


        public override Java.Lang.Object GetItem(int position)
        {
            return position;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView;
            Tabakhi_AdapterViewHolder holder = null;

            if (view != null)
                holder = view.Tag as Tabakhi_AdapterViewHolder;

            if (holder == null)
            {
                holder = new Tabakhi_AdapterViewHolder();
                var inflater = context.GetSystemService(Context.LayoutInflaterService).JavaCast<LayoutInflater>();
                view = inflater.Inflate( Resource.Layout.activity_Tabakhi_CustomListview, parent, false);
                //replace with your item and your holder items
                //comment back in
                //holder.Holder_Imageview_Header = view.FindViewById<ImageView>(Resource.Id.Act_BreadListView_Imageview_Header);
               holder.Holder_TextView_Name = view.FindViewById<TextView>(Resource.Id.Act_TabakhiListView_TextView_Name);
                holder.Holder_TextView_Place = view.FindViewById<TextView>(Resource.Id.Act_TabakhiListView_TextView_Place);
                 holder.Holder_TextView_JobTime = view.FindViewById<TextView>(Resource.Id.Act_TabakhiListView_TextView_JobTime);
                  holder.Holder_RatingBar_rating = view.FindViewById<RatingBar>(Resource.Id.Act_TabakhiListView_RatingBar_rating);

                view.Tag = holder;
            }
            holder.Holder_TextView_Name.Text = Lst_tabakhi[position].Name;
            holder.Holder_TextView_Place.Text = Lst_tabakhi[position].Time;
            holder.Holder_TextView_JobTime.Text = Lst_tabakhi[position].Job;
            // holder.Holder_RatingBar_rating.Rating = Lst_tabakhi[position].id;
            holder.Holder_RatingBar_rating.Rating = 4;

            return view;
        }

        //Fill in cound here, currently 0
        public override int Count
        {
            get
            {
                return Lst_tabakhi.Count;
            }
        }

    }

    class Tabakhi_AdapterViewHolder : Java.Lang.Object
    {
        //Your adapter views to re-use
         public ImageView Holder_Imageview_Header { get; set; }
        public TextView Holder_TextView_Name { get; set; }
        public TextView Holder_TextView_Place { get; set; }
        public TextView Holder_TextView_JobTime { get; set; }
        public RatingBar Holder_RatingBar_rating { get; set; }
    }
}