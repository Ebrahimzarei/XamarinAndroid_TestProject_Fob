using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace FOB.Controller.Account
{
    [Activity(Label = "AddAccount_Activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class Add_Account : AppCompatActivity
    {
        
        Button AddAccount_Button_Account;
        Button AddAccount_Button_Message;
        Button AddAccount_Button_Basket;
        Button AddAccount_Button_Home;
        TextView AddAccount_TextView_FullName;
        EditText AddAccount_EditText_FullName;
        TextView AddAccount_TextView_Tel;
        EditText AddAccount_EditText_Tel;
        TextView AddAccount_TextView_Adress;
        EditText AddAccount_EditText_Address;
       
        Button AddAccount_Button_Save;
        TextView AddAccount_TxtView_Header;


        Button Account_Button_Exit;


        TextView AddAccount_TextView_FamilyName;
        EditText AddAccount_EditText_FamilyName;

        TextView AddAccount_TextView_NationalCode;
        EditText AddAccount_EditText_NationalCode;

        TextView AddAccount_TextView_BirthDay;
        EditText AddAccount_EditText_BirthDay;
        CheckBox AddAccount_CheckBox_Male;
        CheckBox AddAcount_checkBox_Female;

        TextView AddAccount_TextView_Telhamrah;
        EditText AddAccount_EditText_Telhamrah;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_addaccount);
              AddAccount_TextView_Telhamrah = FindViewById<TextView>(Resource.Id.AddAccount_TextView_Telhamrah);
              AddAccount_EditText_Telhamrah = FindViewById<EditText>(Resource.Id.AddAccount_EditText_Telhamrah);



            AddAccount_TextView_FamilyName = FindViewById<TextView>(Resource.Id.AddAccount_TextView_FamilyName);
            AddAccount_EditText_FamilyName = FindViewById<EditText>(Resource.Id.AddAccount_EditText_FamilyName);
            AddAccount_TextView_NationalCode = FindViewById<TextView>(Resource.Id.AddAccount_TextView_NationalCode);
            AddAccount_EditText_NationalCode = FindViewById<EditText>(Resource.Id.AddAccount_EditText_NationalCode);
            AddAccount_TextView_BirthDay = FindViewById<TextView>(Resource.Id.AddAccount_TextView_BirthDay);
            AddAccount_EditText_BirthDay = FindViewById<EditText>(Resource.Id.AddAccount_EditText_BirthDay);
            AddAccount_CheckBox_Male = FindViewById<CheckBox>(Resource.Id.AddAccount_CheckBox_Male);
            AddAcount_checkBox_Female = FindViewById<CheckBox>(Resource.Id.AddAcount_checkBox_Female);
            //AddAccount_CheckBox_Male.Click += delegate { };
            AddAccount_CheckBox_Male.CheckedChange += delegate {

                if (AddAcount_checkBox_Female.Checked)
                {
                    AddAccount_CheckBox_Male.Checked = false;
                }
            };
        
            AddAcount_checkBox_Female.CheckedChange += delegate {

                if (AddAccount_CheckBox_Male.Checked)
                {
                    AddAcount_checkBox_Female.Checked = false;
                }

            };
            AddAccount_TxtView_Header = FindViewById<TextView>(Resource.Id.AddAccount_TxtView_Header);
            AddAccount_Button_Account = FindViewById<Button>(Resource.Id.AddAccount_Button_Account);
            AddAccount_Button_Account.Click += delegate {

                //حساب
                Intent oi = new Intent(this, typeof(Account_Activity));
                StartActivity(oi);
            };
           
      
            AddAccount_Button_Message = FindViewById<Button>(Resource.Id.AddAccount_Button_Message);
            AddAccount_Button_Message.Click += delegate {
                //پیام
                Intent oi = new Intent(this, typeof(Message_Activity));
                StartActivity(oi);

            };
             AddAccount_Button_Basket = FindViewById<Button>(Resource.Id.AddAccount_Button_Basket);
            AddAccount_Button_Basket.Click += delegate {
                //سبد
                Intent oi = new Intent(this, typeof(Basket_activity));
                StartActivity(oi);

            };
             AddAccount_Button_Home = FindViewById<Button>(Resource.Id.AddAccount_Button_Home);
            AddAccount_Button_Home.Click += delegate {   //خانه
                Intent oi = new Intent(this, typeof(MainActivity));
                StartActivity(oi);
            };
             AddAccount_TextView_FullName = FindViewById<TextView>(Resource.Id.AddAccount_TextView_FullName);
             AddAccount_EditText_FullName = FindViewById<EditText>(Resource.Id.AddAccount_EditText_FullName);
             AddAccount_TextView_Tel = FindViewById<TextView>(Resource.Id.AddAccount_TextView_Tel);
             AddAccount_EditText_Tel = FindViewById<EditText>(Resource.Id.AddAccount_EditText_Tel);
             AddAccount_TextView_Adress = FindViewById<TextView>(Resource.Id.AddAccount_TextView_Adress);
             AddAccount_EditText_Address = FindViewById<EditText>(Resource.Id.AddAccount_EditText_Address);
            
            AddAccount_Button_Save = FindViewById<Button>(Resource.Id.AddAccount_Button_Save);
           AddAccount_Button_Save.Click += delegate {


               Snackbar snackBar = Snackbar.Make(AddAccount_Button_Save, "عملیات مورد نظر با موفقیت انجام شد", Snackbar.LengthIndefinite).SetAction("تایید", (v) =>
               {
                   Finish();
               });

               //set  action button text color 
               snackBar.SetActionTextColor(Android.Graphics.Color.Green);

               snackBar.Show();
           };
         
        }
    }
}