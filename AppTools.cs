using System.Globalization;
using System.Text.RegularExpressions;

namespace Useful_Functions
{
    public static class AppTools
    {
        // read by sinapirzadeh
        public static string AddFirstZero(int num, int length)
        {
            var result = num.ToString();

            while (result.Length < length)
            {
                result = "0" + result;
            }

            return result;
        }

        public static int ToInt(string str)
        {
            var result = 0;

            if (str != null)
            {
                if (int.TryParse(str, out int num))
                {
                    result = num;
                }
            }

            return result;

        }

        /*        public static string ToPersianNumber(this string txt)
                {
                    var result = txt.Trim();

                    char[] temp = new char[result.Length];

                    int i = 0;
                    foreach (char c in result)
                    {
                        if (char.IsDigit(c))
                        {

                        }
                    }
                }*/

        public static string ToShamsiDate(this DateTime dt)
        {
            PersianCalendar pc = new PersianCalendar();
            var result = $"سال {pc.GetYear(dt)} ماه {pc.GetMonth(dt)} روز {pc.GetDayOfMonth(dt)}";
            return result;
        }

        public static string ToShamsiDateOfMonth(this DateTime dt)
        {
            PersianCalendar pc = new PersianCalendar();
            var month = new string[]
            {
                "فروردین","اردیبهشت","خرداد",
                "تیر","مرداد","شهریور",
                "مهر","آبان","آذر",
                "دی","بهمن","اسفند",
            };

            return month[pc.GetMonth(dt) - 1];
        }

        public static string ToShamsiDateOfDayOfWeek(this DateTime dt)
        {
            PersianCalendar pc = new PersianCalendar();
            var dayofweek = new string[]
            {
                "شنبه",
                "یک شنبه",
                "دو شنبه",
                "سه شنبه",
                "جهار شنبه",
                "پنج شنبه",
                "جمعه"
            };

            return dayofweek[(int)pc.GetDayOfWeek(dt)];
        }

        public static int GetRandomNumber(int min, int max)
        {
            Random rd = new Random();
            return rd.Next(min, max);
        }

        public static string GetToRevarsText(this string str)
        {
            char[] txt = str.ToCharArray();
            Array.Reverse(txt);
            return new String(txt);
        }

        public static bool IsNumber(this string str) => Regex.IsMatch(str, @"^\d+$");
    }
}
