
using System.Collections.Generic;


using Android.App;
using Android.Content;
using Android.Graphics;

using Android.Runtime;
using Android.Views;
using Android.Widget;
using FOB.Model;

namespace FOB.Controller.SelectedItem.Adapter
{
    class Adapter_SelectedItemResturant : BaseAdapter
    {

        Context context;
        List<Specifications_Resturant> FakeModel;

        public Adapter_SelectedItemResturant(Context context, List<Specifications_Resturant> Fake_Model)
        {
            this.context = context;
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
            Adapter_SelectedItemResturantViewHolder holder = null;

            if (view != null)
                holder = view.Tag as Adapter_SelectedItemResturantViewHolder;

            if (holder == null)
            {
                holder = new Adapter_SelectedItemResturantViewHolder();
                var inflater = context.GetSystemService(Context.LayoutInflaterService).JavaCast<LayoutInflater>();
                //replace with your item and your holder items
                //comment back in
              view = inflater.Inflate(Resource.Layout.ListView_CustomSelectedResturant, parent, false);
               holder.CustomSelectResturant_ImageView_MyImage = view.FindViewById<ImageView>(Resource.Id.CustomSelectResturant_ImageView_MyImage);
                holder.CustomSelectResturant_Textview_Description = view.FindViewById<TextView>(Resource.Id.CustomSelectResturant_Textview_Description);
                holder.CustomSelectResturant_Textview_AnswerDescription = view.FindViewById<TextView>(Resource.Id.CustomSelectResturant_Textview_AnswerDescription);
                holder.CustomSelectResturant_Textview_Price = view.FindViewById<TextView>(Resource.Id.CustomSelectResturant_Textview_Price);
                holder.CustomSelectResturant_Textview_AnswerPrice = view.FindViewById<TextView>(Resource.Id.CustomSelectResturant_Textview_AnswerPrice);
                holder.CustomSelectResturant_Textview_Discount = view.FindViewById<TextView>(Resource.Id.CustomSelectResturant_Textview_Discount);
                holder.CustomSelectResturant_Textview_AnswerDiscount = view.FindViewById<TextView>(Resource.Id.CustomSelectResturant_Textview_AnswerDiscount);
                holder.CustomSelectResturant_Button_BtnPluse = view.FindViewById<Button>(Resource.Id.CustomSelectResturant_Button_BtnPluse);
                holder.CustomSelectResturant_TextView_TxtCount = view.FindViewById<TextView>(Resource.Id.CustomSelectResturant_TextView_TxtCount);
                holder.CustomSelectResturant_Button_BtnMinuse = view.FindViewById<Button>(Resource.Id.CustomSelectResturant_Button_BtnMinuse);
              //  holder.CustomSelectResturant_Button_ProductMore= view.FindViewById<Button>(Resource.Id.CustomSelectResturant_Button_ProductMore);
                view.Tag = holder;
            }



            holder.CustomSelectResturant_Textview_AnswerDescription.Text = FakeModel[position].ItemOne;
            holder.CustomSelectResturant_Textview_Description.Text= FakeModel[position].ItemOne;


            holder.CustomSelectResturant_Textview_AnswerPrice.Text = FakeModel[position].ItemTwo;
            
          
            holder.CustomSelectResturant_Textview_AnswerDiscount.Text = FakeModel[position].ItemThree;
          
            holder.CustomSelectResturant_Textview_AnswerDescription.Text = FakeModel[position].ItemThree;
            if (!holder.CustomSelectResturant_ImageView_MyImage.HasOnClickListeners)
            {
               holder.CustomSelectResturant_ImageView_MyImage.Click += delegate {

                    Intent oi = new Intent(this.context, typeof(PropertiseProduct_Activity));
                    this.context.StartActivity(oi);
                };
            }
            #region
            if (!holder.CustomSelectResturant_Textview_Description.HasOnClickListeners)
            {
                holder.CustomSelectResturant_Textview_Description.Click += delegate {

                    Intent oi = new Intent(this.context, typeof(PropertiseProduct_Activity));
                    this.context.StartActivity(oi);
                };
            }
            if (!holder.CustomSelectResturant_Textview_AnswerDescription.HasOnClickListeners)
            {
                holder.CustomSelectResturant_Textview_AnswerDescription.Click += delegate {

                    Intent oi = new Intent(this.context, typeof(PropertiseProduct_Activity));
                    this.context.StartActivity(oi);
                };
            }
            if (!holder.CustomSelectResturant_Textview_Price.HasOnClickListeners)
            {
                holder.CustomSelectResturant_Textview_Price.Click += delegate {

                    Intent oi = new Intent(this.context, typeof(PropertiseProduct_Activity));
                    this.context.StartActivity(oi);
                };
            }
            if (!holder.CustomSelectResturant_Textview_AnswerPrice.HasOnClickListeners)
            {
                holder.CustomSelectResturant_Textview_AnswerPrice.Click += delegate {

                    Intent oi = new Intent(this.context, typeof(PropertiseProduct_Activity));
                    this.context.StartActivity(oi);
                };
            }
            if (!holder.CustomSelectResturant_Textview_Discount.HasOnClickListeners)
            {
                holder.CustomSelectResturant_Textview_Discount.Click += delegate {

                    Intent oi = new Intent(this.context, typeof(PropertiseProduct_Activity));
                    this.context.StartActivity(oi);
                };
            }
            if (!holder.CustomSelectResturant_Textview_AnswerDiscount.HasOnClickListeners)
            {
                holder.CustomSelectResturant_Textview_AnswerDiscount.Click += delegate {

                    Intent oi = new Intent(this.context, typeof(PropertiseProduct_Activity));
                    this.context.StartActivity(oi);
                };
            }
            #endregion

            //  view.FindViewById<Button>(Resource.Id.CustomSelectResturant_Button_BtnPluse).Click += delegate {
            if (!holder.CustomSelectResturant_Button_BtnPluse.HasOnClickListeners)
            {
                holder.CustomSelectResturant_Button_BtnPluse.Click += delegate
                {
                    string value = holder.CustomSelectResturant_TextView_TxtCount.Text;

                    int number = int.Parse(value);


                    string value2 = (number + 1).ToString();
                    holder.CustomSelectResturant_TextView_TxtCount.Text = value2;
                    NotifyDataSetChanged();

                };

              }
            if (!holder.CustomSelectResturant_Button_BtnMinuse.HasOnClickListeners)
            {
                holder.CustomSelectResturant_Button_BtnMinuse.Click += delegate {

                    string value = holder.CustomSelectResturant_TextView_TxtCount.Text;
                    int number = int.Parse(value);
                    if (number <= 0)
                    {
                        return;
                    }
                    string value2 = (number - 1).ToString();
                    holder.CustomSelectResturant_TextView_TxtCount.Text = value2;
                };

            }

            

            holder.CustomSelectResturant_Textview_AnswerDescription.Text = FakeModel[position].ItemOne;


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

    class Adapter_SelectedItemResturantViewHolder : Java.Lang.Object
    {
        //Your adapter views to re-use
        public ImageView CustomSelectResturant_ImageView_MyImage { get; set; }
        public TextView CustomSelectResturant_Textview_Description { get; set; }
        public TextView CustomSelectResturant_Textview_AnswerDescription { get; set; }
        public TextView CustomSelectResturant_Textview_Price { get; set; }
        public TextView CustomSelectResturant_Textview_AnswerPrice { get; set; }
        public TextView CustomSelectResturant_Textview_Discount { get; set; }
        public TextView CustomSelectResturant_Textview_AnswerDiscount { get; set; }

        public Button CustomSelectResturant_Button_BtnPluse { get; set; }
        public TextView CustomSelectResturant_TextView_TxtCount { get; set; }
        public Button CustomSelectResturant_Button_BtnMinuse { get; set; }
        public Button CustomSelectResturant_Button_ProductMore { get; set; }
    }
}