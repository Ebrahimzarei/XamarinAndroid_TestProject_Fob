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
using FOB.Model;

namespace FOB.Controller.SelectedItem.Adapter
{
    class Adapter_DescriptionResturant : BaseAdapter
    {

        Context context;
        List<Description_Resturant> FakeModel;

        public Adapter_DescriptionResturant(Context ctx,List<Description_Resturant> Fake_Model)
        {
            this.context = ctx;
            this.FakeModel = Fake_Model;
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
            Adapter_DescriptionResturantViewHolder holder = null;

            if (view != null)
                holder = view.Tag as Adapter_DescriptionResturantViewHolder;

            if (holder == null)
            {
                holder = new Adapter_DescriptionResturantViewHolder();
                var inflater = context.GetSystemService(Context.LayoutInflaterService).JavaCast<LayoutInflater>();
                //replace with your item and your holder items
                //comment back in
              view = inflater.Inflate(Resource.Layout.ListViewCustom_DescriptionResturant, parent, false);
               holder.CustomDescriptionResturant_ImageView_MyImage = view.FindViewById<ImageView>(Resource.Id.CustomDescriptionResturant_ImageView_MyImage);
                holder.CustomDescriptionResturant_Textview_DescriptionOne = view.FindViewById<TextView>(Resource.Id.CustomDescriptionResturant_Textview_DescriptionOne);
                holder.CustomDescriptionResturant_Textview_DescriptionTwo = view.FindViewById<TextView>(Resource.Id.CustomDescriptionResturant_Textview_DescriptionTwo);
                holder.CustomDescriptionResturant_Textview_DescriptionThree = view.FindViewById<TextView>(Resource.Id.CustomDescriptionResturant_Textview_DescriptionThree);
                holder.CustomDescriptionResturant_Textview_DescriptionFor = view.FindViewById<TextView>(Resource.Id.CustomDescriptionResturant_Textview_DescriptionFor);
                holder.CustomDescriptionResturant_Textview_DescriptionFive = view.FindViewById<TextView>(Resource.Id.CustomDescriptionResturant_Textview_DescriptionFive);
                holder.CustomDescriptionResturant_Textview_AnswerDescriptionFive = view.FindViewById<TextView>(Resource.Id.CustomDescriptionResturant_Textview_AnswerDescriptionFive);
                
                view.Tag = holder;
            }



            holder.CustomDescriptionResturant_Textview_DescriptionTwo.Text = FakeModel[position].ItemOne;
            holder.CustomDescriptionResturant_Textview_DescriptionFor.Text= FakeModel[position].ItemTwo;


            holder.CustomDescriptionResturant_Textview_AnswerDescriptionFive.Text = FakeModel[position].ItemThree;
            
          


            //  view.FindViewById<Button>(Resource.Id.CustomSelectResturant_Button_BtnPluse).Click += delegate {
           
           

            

          


            //fill in your items
            //holder.Title.Text = "new text here";

            return view;
        }
     
        //Fill in cound here, currently 0
        public override int Count
        {
            get
            {
                return FakeModel.Count;
            }
        }

    }

    class Adapter_DescriptionResturantViewHolder : Java.Lang.Object
    {
        //Your adapter views to re-use
        public ImageView CustomDescriptionResturant_ImageView_MyImage { get; set; }
        public TextView CustomDescriptionResturant_Textview_DescriptionOne { get; set; }
        public TextView CustomDescriptionResturant_Textview_DescriptionTwo { get; set; }
        public TextView CustomDescriptionResturant_Textview_DescriptionThree { get; set; }
        public TextView CustomDescriptionResturant_Textview_DescriptionFor { get; set; }
        public TextView CustomDescriptionResturant_Textview_DescriptionFive { get; set; }
        public TextView CustomDescriptionResturant_Textview_AnswerDescriptionFive { get; set; }

     
    }
}