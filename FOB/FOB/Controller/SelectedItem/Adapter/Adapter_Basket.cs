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
    class Adapter_Basket : BaseAdapter
    {

        Context context;
        List<Basket_Resturant> FakeModel;

        public Adapter_Basket(Context context, List<Model.Basket_Resturant> Fake_Model)
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
            Adapter_BasketViewHolder holder = null;

            if (view != null)
                holder = view.Tag as Adapter_BasketViewHolder;

            if (holder == null)
            {
                holder = new Adapter_BasketViewHolder();
                var inflater = context.GetSystemService(Context.LayoutInflaterService).JavaCast<LayoutInflater>();
                //replace with your item and your holder items
                //comment back in
              view = inflater.Inflate(Resource.Layout.ListViewCustom_Basket, parent, false);
        holder.CustomListViewBasket_ImageView_MyImage = view.FindViewById<ImageView>(Resource.Id.CustomListViewBasket_ImageView_MyImage);
             holder.CustomListViewBasket_Textview_Description = view.FindViewById<TextView>(Resource.Id.CustomListViewBasket_Textview_Description);
              holder.CustomListViewBasket_Textview_AnswerDescription = view.FindViewById<TextView>(Resource.Id.CustomListViewBasket_Textview_AnswerDescription);
              holder.CustomListViewBasket_Textview_Price = view.FindViewById<TextView>(Resource.Id.CustomListViewBasket_Textview_Price);
              holder.CustomListViewBasket_Textview_AnswerPrice = view.FindViewById<TextView>(Resource.Id.CustomListViewBasket_Textview_AnswerPrice);
              holder.CustomListViewBasket_Textview_Discount = view.FindViewById<TextView>(Resource.Id.CustomListViewBasket_Textview_Discount);
             holder.CustomListViewBasket_Textview_AnswerDiscount = view.FindViewById<TextView>(Resource.Id.CustomListViewBasket_Textview_AnswerDiscount);
               holder.CustomListViewBasket_Button_BtnPluse = view.FindViewById<Button>(Resource.Id.CustomListViewBasket_Button_BtnPluse);
              holder.CustomListViewBasket_TextView_TxtCount = view.FindViewById<TextView>(Resource.Id.CustomListViewBasket_TextView_TxtCount);
               holder.CustomListViewBasket_Button_BtnMinuse = view.FindViewById<Button>(Resource.Id.CustomListViewBasket_Button_BtnMinuse);
             //   holder.CustomListViewBasket_Button_BtnAboutProduct = view.FindViewById<Button>(Resource.Id.CustomListViewBasket_Button_BtnAboutProduct);
                view.Tag = holder;
            }



            holder.CustomListViewBasket_Textview_AnswerDescription.Text = FakeModel[position].ItemOne;
            holder.CustomListViewBasket_Textview_Description.Text= FakeModel[position].ItemOne;


            holder.CustomListViewBasket_Textview_AnswerPrice.Text = FakeModel[position].ItemTwo;
            
          
            holder.CustomListViewBasket_Textview_AnswerDiscount.Text = FakeModel[position].ItemThree;
          
            holder.CustomListViewBasket_Textview_AnswerDescription.Text = FakeModel[position].ItemThree;
            #region
            if (!holder.CustomListViewBasket_ImageView_MyImage.HasOnClickListeners)
            {
                holder.CustomListViewBasket_ImageView_MyImage.Click += delegate {
                    //اطلاعات بیشتر محصول

                    Intent oi = new Intent(this.context, typeof(PropertiseProduct_Activity));
                    context.StartActivity(oi);
                };

            }
            if (!holder.CustomListViewBasket_Textview_Description.HasOnClickListeners)
            {
                holder.CustomListViewBasket_Textview_Description.Click += delegate {
                    //اطلاعات بیشتر محصول

                    Intent oi = new Intent(this.context, typeof(PropertiseProduct_Activity));
                    context.StartActivity(oi);
                };

            }
            if (!holder.CustomListViewBasket_Textview_AnswerDescription.HasOnClickListeners)
            {
                holder.CustomListViewBasket_Textview_AnswerDescription.Click += delegate {
                    //اطلاعات بیشتر محصول

                    Intent oi = new Intent(this.context, typeof(PropertiseProduct_Activity));
                    context.StartActivity(oi);
                };

            }
            if (!holder.CustomListViewBasket_Textview_Price.HasOnClickListeners)
            {
                holder.CustomListViewBasket_Textview_Price.Click += delegate {
                    //اطلاعات بیشتر محصول

                    Intent oi = new Intent(this.context, typeof(PropertiseProduct_Activity));
                    context.StartActivity(oi);
                };

            }
            if (!holder.CustomListViewBasket_Textview_AnswerPrice.HasOnClickListeners)
            {
                holder.CustomListViewBasket_Textview_AnswerPrice.Click += delegate {
                    //اطلاعات بیشتر محصول

                    Intent oi = new Intent(this.context, typeof(PropertiseProduct_Activity));
                    context.StartActivity(oi);
                };

            }
            if (!holder.CustomListViewBasket_Textview_Discount.HasOnClickListeners)
            {
                holder.CustomListViewBasket_Textview_Discount.Click += delegate {
                    //اطلاعات بیشتر محصول

                    Intent oi = new Intent(this.context, typeof(PropertiseProduct_Activity));
                    context.StartActivity(oi);
                };

            }
            if (!holder.CustomListViewBasket_Textview_AnswerDiscount.HasOnClickListeners)
            {
                holder.CustomListViewBasket_Textview_AnswerDiscount.Click += delegate {
                    //اطلاعات بیشتر محصول

                    Intent oi = new Intent(this.context, typeof(PropertiseProduct_Activity));
                    context.StartActivity(oi);
                };

            }
            if (!holder.CustomListViewBasket_Textview_AnswerDiscount.HasOnClickListeners)
            {
                holder.CustomListViewBasket_Textview_AnswerDiscount.Click += delegate {
                    //اطلاعات بیشتر محصول

                    Intent oi = new Intent(this.context, typeof(PropertiseProduct_Activity));
                    context.StartActivity(oi);
                };

            }
            #endregion


            if (!holder.CustomListViewBasket_Button_BtnPluse.HasOnClickListeners)
            {
                holder.CustomListViewBasket_Button_BtnPluse.Click += delegate
                {
                    string value = holder.CustomListViewBasket_TextView_TxtCount.Text;

                    int number = int.Parse(value);


                    string value2 = (number + 1).ToString();
                    holder.CustomListViewBasket_TextView_TxtCount.Text = value2;
                    NotifyDataSetChanged();

                };

              }
            if (!holder.CustomListViewBasket_Button_BtnMinuse.HasOnClickListeners)
            {
                holder.CustomListViewBasket_Button_BtnMinuse.Click += delegate {

                    string value = holder.CustomListViewBasket_TextView_TxtCount.Text;
                    int number = int.Parse(value);
                    if (number <= 0)
                    {
                        return;
                    }
                    string value2 = (number - 1).ToString();
                    holder.CustomListViewBasket_TextView_TxtCount.Text = value2;
                };

            }

            

            holder.CustomListViewBasket_Textview_AnswerDescription.Text = FakeModel[position].ItemOne;


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

    class Adapter_BasketViewHolder : Java.Lang.Object
    {
        //Your adapter views to re-use
        public ImageView CustomListViewBasket_ImageView_MyImage { get; set; }
        public TextView CustomListViewBasket_Textview_Description { get; set; }
        public TextView CustomListViewBasket_Textview_AnswerDescription { get; set; }
        public TextView CustomListViewBasket_Textview_Price { get; set; }
        public TextView CustomListViewBasket_Textview_AnswerPrice { get; set; }
        public TextView CustomListViewBasket_Textview_Discount { get; set; }
        public TextView CustomListViewBasket_Textview_AnswerDiscount { get; set; }

        public Button CustomListViewBasket_Button_BtnPluse { get; set; }
        public TextView CustomListViewBasket_TextView_TxtCount { get; set; }
        public Button CustomListViewBasket_Button_BtnMinuse { get; set; }

     //   public Button CustomListViewBasket_Button_BtnAboutProduct { get; set; }
    }
}