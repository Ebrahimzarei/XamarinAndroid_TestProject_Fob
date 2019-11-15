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
using Newtonsoft.Json.Linq;
using SQLite;

namespace FOB.Model.Bank
{
    /// <summary>
    /// وضعیت پرداخت کاربر
    /// </summary>
   public class StatuseVerify
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public string StatusePayed { get; set; }
        public string DateTransaction { get; set; }
        public string Error { get; set; }
        public string MessagError { get; set; }
        


    }
    public class Json_StatuseVerify
    {
        public Json_StatuseVerify(string json)
        {
            JObject jObject = JObject.Parse(json);
            //JToken jUser = jObject["statuse"];
            error = (bool)jObject["error"];
            status = (string)jObject["status"];
            pay_code = (string)jObject["pay_code"];
            message = (string)jObject["message"];



        }

        public bool? error { get; set; }
        public string status { get; set; }
        public string pay_code { get; set; }
        public string message { get; set; }
       



    }

}