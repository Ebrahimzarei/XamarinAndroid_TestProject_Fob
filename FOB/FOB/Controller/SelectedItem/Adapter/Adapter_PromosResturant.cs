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
    class Adapter_PromosResturant : BaseAdapter
    {

        Context context;
        List<Promose_Resturant> FakeModel;

        public Adapter_PromosResturant(Context ctx,List<Promose_Resturant> Fake_Model)
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
            Adapter_PromosResturantViewHolder holder = null;

            if (view != null)
                holder = view.Tag as Adapter_PromosResturantViewHolder;

            if (holder == null)
            {
                holder = new Adapter_PromosResturantViewHolder();
                var inflater = context.GetSystemService(Context.LayoutInflaterService).JavaCast<LayoutInflater>();
                //replace with your item and your holder items
                //comment back in
              view = inflater.Inflate(Resource.Layout.ListView_CustomFragmnetPromose, parent, false);
               holder.CustomFragmentPromose_ImageView_MyImage = view.FindViewById<ImageView>(Resource.Id.CustomFragmentPromose_ImageView_MyImage);
                holder.CustomFragmentPromose_Textview_Description = view.FindViewById<TextView>(Resource.Id.CustomFragmentPromose_Textview_Description);
                holder.CustomFragmentPromose_Textview_AnswerDescription = view.FindViewById<TextView>(Resource.Id.CustomFragmentPromose_Textview_AnswerDescription);
                holder.CustomFragmentPromose_Textview_Price = view.FindViewById<TextView>(Resource.Id.CustomFragmentPromose_Textview_Price);
                holder.CustomFragmentPromose_Textview_AnswerPrice = view.FindViewById<TextView>(Resource.Id.CustomFragmentPromose_Textview_AnswerPrice);
                holder.CustomFragmentPromose_Textview_Discount = view.FindViewById<TextView>(Resource.Id.CustomFragmentPromose_Textview_Discount);
                holder.CustomFragmentPromose_Textview_AnswerDiscount = view.FindViewById<TextView>(Resource.Id.CustomFragmentPromose_Textview_AnswerDiscount);
                holder.CustomFragmentPromose_Button_BtnPluse = view.FindViewById<Button>(Resource.Id.CustomFragmentPromose_Button_BtnPluse);
                holder.CustomFragmentPromose_TextView_TxtCount = view.FindViewById<TextView>(Resource.Id.CustomFragmentPromose_TextView_TxtCount);
                holder.CustomFragmentPromose_Button_BtnMinuse = view.FindViewById<Button>(Resource.Id.CustomFragmentPromose_Button_BtnMinuse);
                view.Tag = holder;
            }



            holder.CustomFragmentPromose_Textview_AnswerDescription.Text = FakeModel[position].ItemOne;
            holder.CustomFragmentPromose_Textview_Description.Text= FakeModel[position].ItemOne;


            holder.CustomFragmentPromose_Textview_AnswerPrice.Text = FakeModel[position].ItemTwo;
            
          
            holder.CustomFragmentPromose_Textview_AnswerDiscount.Text = FakeModel[position].ItemThree;
          
            holder.CustomFragmentPromose_Textview_AnswerDescription.Text = FakeModel[position].ItemThree;

            //  view.FindViewById<Button>(Resource.Id.CustomFragmentPromose_Button_BtnPluse).Click += delegate {
            if (!holder.CustomFragmentPromose_Button_BtnPluse.HasOnClickListeners)
            {
                holder.CustomFragmentPromose_Button_BtnPluse.Click += delegate
                {
                    string value = holder.CustomFragmentPromose_TextView_TxtCount.Text;

                    int number = int.Parse(value);


                    string value2 = (number + 1).ToString();
                    holder.CustomFragmentPromose_TextView_TxtCount.Text = value2;
                    NotifyDataSetChanged();

                };

              }
            if (!holder.CustomFragmentPromose_Button_BtnMinuse.HasOnClickListeners)
            {
                holder.CustomFragmentPromose_Button_BtnMinuse.Click += delegate {

                    string value = holder.CustomFragmentPromose_TextView_TxtCount.Text;
                    int number = int.Parse(value);
                    if (number <= 0)
                    {
                        return;
                    }
                    string value2 = (number - 1).ToString();
                    holder.CustomFragmentPromose_TextView_TxtCount.Text = value2;
                };

            }

            

            holder.CustomFragmentPromose_Textview_AnswerDescription.Text = FakeModel[position].ItemOne;


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

    class Adapter_PromosResturantViewHolder : Java.Lang.Object
    {
        //Your adapter views to re-use
        public ImageView CustomFragmentPromose_ImageView_MyImage { get; set; }
        public TextView CustomFragmentPromose_Textview_Description { get; set; }
        public TextView CustomFragmentPromose_Textview_AnswerDescription { get; set; }
        public TextView CustomFragmentPromose_Textview_Price { get; set; }
        public TextView CustomFragmentPromose_Textview_AnswerPrice { get; set; }
        public TextView CustomFragmentPromose_Textview_Discount { get; set; }
        public TextView CustomFragmentPromose_Textview_AnswerDiscount { get; set; }

        public Button CustomFragmentPromose_Button_BtnPluse { get; set; }
        public TextView CustomFragmentPromose_TextView_TxtCount { get; set; }
        public Button CustomFragmentPromose_Button_BtnMinuse { get; set; }
    }
}