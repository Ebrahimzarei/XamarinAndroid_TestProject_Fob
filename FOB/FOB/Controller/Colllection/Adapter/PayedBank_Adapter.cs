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

namespace FOB.Controller.Colllection.Adapter
{
    class PayedBank_Adapter : BaseAdapter
    {

        Context context;
        private List<Model.Bank.StatuseVerify> Lst_Bank;

        public PayedBank_Adapter(Context context,List<Model.Bank.StatuseVerify> lstBank)
        {
            this.context = context;
            this.Lst_Bank = lstBank;
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
            PayedBank_AdapterViewHolder holder = null;

            if (view != null)
                holder = view.Tag as PayedBank_AdapterViewHolder;

            if (holder == null)
            {
                holder = new PayedBank_AdapterViewHolder();
                var inflater = context.GetSystemService(Context.LayoutInflaterService).JavaCast<LayoutInflater>();
                view = inflater.Inflate( Resource.Layout.ListView_PayedBank_CustomListView, parent, false);
                //holder.Holder_Imageview_Header = view.FindViewById<ImageView>(Resource.Id.Act_AlasListView_Imageview_Header);
                holder.CustomPayedBank_Textview_StatusePayed = view.FindViewById<TextView>(Resource.Id.CustomPayedBank_Textview_StatusePayed);
                holder.CustomPayedBank_Textview_DateTranction = view.FindViewById<TextView>(Resource.Id.CustomPayedBank_Textview_DateTranction);
                holder.CustomPayedBank_Textview_StateError = view.FindViewById<TextView>(Resource.Id.CustomPayedBank_Textview_StateError);
                 

                view.Tag = holder;
            }


            if (Lst_Bank[position].StatusePayed== "SUCCESSFUL_PAYMENT")
            {
                holder.CustomPayedBank_Textview_StatusePayed.Text = "پرداخت موفق";
            }
            if (Lst_Bank[position].StatusePayed == "INVALID_TRANSACTION")
            {
                holder.CustomPayedBank_Textview_StatusePayed.Text = "تراکنش نامعتبر";
            }
            if (Lst_Bank[position].StatusePayed == "BEFORE_PAID")
            {
                holder.CustomPayedBank_Textview_StatusePayed.Text = "پرداخت انجام نشده است";
            }
            if (Lst_Bank[position].StatusePayed == "BAD_PARAMETERS")
            {
                holder.CustomPayedBank_Textview_StatusePayed.Text = "اطلاعات ارسال شده ناقص است";
            }
            //

            holder.CustomPayedBank_Textview_DateTranction.Text = Lst_Bank[position].DateTransaction;
            holder.CustomPayedBank_Textview_StateError.Text = Lst_Bank[position].MessagError;
    

            return view;
        }

        //Fill in cound here, currently 0
        public override int Count
        {
            get
            {
                return Lst_Bank.Count;
            }
        }

    }

    class PayedBank_AdapterViewHolder : Java.Lang.Object
    {
        //Your adapter views to re-use
  
        public TextView CustomPayedBank_Textview_StatusePayed { get; set; }
        public TextView CustomPayedBank_Textview_DateTranction { get; set; }
        public TextView CustomPayedBank_Textview_StateError { get; set; }
   
    }
}