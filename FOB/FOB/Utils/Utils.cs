using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;


namespace FOB.Utils
{
  public static  class Utils
    {
        public static string PersianDate(DateTime DateTime1)
        {
            PersianCalendar PersianCalendar1 = new PersianCalendar();
            string year = PersianCalendar1.GetYear(DateTime1).ToString();
            string RemoveOneYear = year.Remove(0, 2);
            int month = PersianCalendar1.GetMonth(DateTime1);

            string Month = string.Empty;
            if (month == 1)
            {
                Month = "فروردین";
            }
            if (month == 2)
            {
                Month = "اردیبهشت";
            }
            if (month == 3)
            {
                Month = "خرداد";
            }

            if (month == 4)
            {
                Month = "تیر";
            }
            if (month == 5)
            {
                Month = "مرداد";
            }
            if (month == 6)
            {
                Month = "شهریور";
            }

            if (month == 7)
            {
                Month = "مهر";
            }
            if (month == 8)
            {
                Month = "آبان";
            }
            if (month == 9)
            {
                Month = "آذر";
            }

            if (month == 10)
            {
                Month = "دی";
            }
            if (month == 11)
            {
                Month = "بهمن";
            }
            if (month == 12)
            {
                Month = "اسفند";
            }
            string YearOfMonth = PersianCalendar1.GetDayOfMonth(DateTime1).ToString();
            string ConvertFarsiDate = YearOfMonth.ToString() + Month + RemoveOneYear;
            return ConvertFarsiDate;
            //return string.Format(@"{0}/{1}/{2}",
            //             PersianCalendar1.GetYear(DateTime1),
            //             PersianCalendar1.GetMonth(DateTime1),
            //             PersianCalendar1.GetDayOfMonth(DateTime1));

        }
    }
}