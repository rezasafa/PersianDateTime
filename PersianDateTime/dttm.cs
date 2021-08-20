using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace PersianDateTime
{
    public class dttm
    {
        public DateTime ToMiLadi(string PersianDate)
        {
            var pc = new PersianCalendar();
            string[] values = PersianDate.Split('/');
            int y = int.Parse(values[0]);
            int m = int.Parse(values[1]);
            int d = int.Parse(values[2]);
            var dt = new DateTime(y, m, d, new PersianCalendar());
            DateTime miladi = pc.ToDateTime(y, m, d, 0, 0, 0, 0);
            return miladi;
        }
        public string ToPersianDateString(DateTime dt)
        {
            var pr = new PersianCalendar();
            return string.Format("{1}{0}{2}{0}{3}",
                CultureInfo.CurrentCulture.DateTimeFormat.DateSeparator,
                pr.GetYear(dt).ToString("0000"), pr.GetMonth(dt).ToString("00"), pr.GetDayOfMonth(dt).ToString("00"));
        }
        public string Get_Tarikh()
        {
            var today = DateTime.Now;
            return ToPersianDateString(today);
        }
        public string Get_Time()
        {
            return DateTime.Now.ToString("HH:mm");
        }
        public string Get_Time_Full()
        {
            return DateTime.Now.ToString("HH:mm:ss:fff");
        }
        public string MakeDate(string PersianDate)
        {
            var pc = new PersianCalendar();
            string[] values = PersianDate.Split('/');
            int y = int.Parse(values[0]);
            int m = int.Parse(values[1]);
            int d = int.Parse(values[2]);

            if (y.ToString().Length == 2)
            {
                if (y > 90)
                {
                    var x = "13" + y.ToString();
                    y = int.Parse(x);
                }
            }

            var dt = new DateTime(y, m, d, new PersianCalendar());
            DateTime miladi = pc.ToDateTime(y, m, d, 0, 0, 0, 0);
            return ToPersianDateString(miladi);
        }
        public string ezaf_Kam_Day(string PersianDate,int Count)
        {
            DateTime dt = ToMiLadi(PersianDate);
            dt = dt.AddDays(Count);
            return ToPersianDateString(dt);
        }
        public string Get_Mah_Name(string PersianDate)
        {
            string[] values = PersianDate.Split('/');
            int m = int.Parse(values[1]);
            string mahName = "";
            switch (m)
            {
                case 1:
                    mahName = "فروردین";
                    break;
                case 2:
                    mahName = "اردیبهشت";
                    break;
                case 3:
                    mahName = "خرداد";
                    break;
                case 4:
                    mahName ="تیر";
                    break;
                case 5:
                    mahName ="مرداد";
                    break;
                case 6:
                    mahName ="شهریور";
                    break;
                case 7:
                    mahName ="مهر";
                    break;
                case 8:
                    mahName ="آبان";
                    break;
                case 9:
                    mahName ="آذر";
                    break;
                case 10:
                    mahName = "دی";
                    break;
                case 11:
                    mahName = "بهمن";
                    break;
                case 12:
                    mahName = "اسفند";
                    break;
            }
            return mahName;
        }
        public string Get_Mah_Name(int Mah)
        {
            string mahName = "";
            switch (Mah)
            {
                case 1:
                    mahName = "فروردین";
                    break;
                case 2:
                    mahName = "اردیبهشت";
                    break;
                case 3:
                    mahName = "خرداد";
                    break;
                case 4:
                    mahName = "تیر";
                    break;
                case 5:
                    mahName = "مرداد";
                    break;
                case 6:
                    mahName = "شهریور";
                    break;
                case 7:
                    mahName = "مهر";
                    break;
                case 8:
                    mahName = "آبان";
                    break;
                case 9:
                    mahName = "آذر";
                    break;
                case 10:
                    mahName = "دی";
                    break;
                case 11:
                    mahName = "بهمن";
                    break;
                case 12:
                    mahName = "اسفند";
                    break;
            }
            return mahName;
        }
        public string Get_Day_Name_Week(string PersianDate)
        {
            DateTime dt = ToMiLadi(PersianDate);
            int d = (int)dt.DayOfWeek;
            string DayName = "";
            switch (d)
            {
                case 6:
                    DayName = "شنبه";
                    break;
                case 0:
                    DayName = "یک شنبه";
                    break;
                case 1:
                    DayName = "دو شنبه";
                    break;
                case 2:
                    DayName = "سه شنبه";
                    break;
                case 3:
                    DayName = "چهار شنبه";
                    break;
                case 4:
                    DayName = "پنج شنبه";
                    break;
                case 5:
                    DayName = "جمعه";
                    break;
            }
            return DayName;
        }
        public int Tafazol_Tarikh(string PersianDate1, string PersianDate2)
        {
            DateTime dt1 = ToMiLadi(PersianDate1);
            DateTime dt2 = ToMiLadi(PersianDate2);
            TimeSpan ts = dt1 - dt2;
            return ts.Days;
        }
	/*
TimeZoneInfo timeInfo = TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time");
            var x = timeInfo.StandardName;
            Console.WriteLine(x.ToString());
            DateTime thisDate = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, timeInfo);
            Console.WriteLine(thisDate.ToString());


<select>
<option value="Morocco Standard Time">(GMT) Casablanca</option>
<option value="GMT Standard Time">(GMT) Greenwich Mean Time : Dublin, Edinburgh, Lisbon, London</option>
<option value="Greenwich Standard Time">(GMT) Monrovia, Reykjavik</option>
<option value="W. Europe Standard Time">(GMT+01:00) Amsterdam, Berlin, Bern, Rome, Stockholm, Vienna</option>
<option value="Central Europe Standard Time">(GMT+01:00) Belgrade, Bratislava, Budapest, Ljubljana, Prague</option>
<option value="Romance Standard Time">(GMT+01:00) Brussels, Copenhagen, Madrid, Paris</option>
<option value="Central European Standard Time">(GMT+01:00) Sarajevo, Skopje, Warsaw, Zagreb</option>
<option value="W. Central Africa Standard Time">(GMT+01:00) West Central Africa</option>
<option value="Jordan Standard Time">(GMT+02:00) Amman</option>
<option value="GTB Standard Time">(GMT+02:00) Athens, Bucharest, Istanbul</option>
<option value="Middle East Standard Time">(GMT+02:00) Beirut</option>
<option value="Egypt Standard Time">(GMT+02:00) Cairo</option>
<option value="South Africa Standard Time">(GMT+02:00) Harare, Pretoria</option>
<option value="FLE Standard Time">(GMT+02:00) Helsinki, Kyiv, Riga, Sofia, Tallinn, Vilnius</option>
<option value="Israel Standard Time">(GMT+02:00) Jerusalem</option>
<option value="E. Europe Standard Time">(GMT+02:00) Minsk</option>
<option value="Namibia Standard Time">(GMT+02:00) Windhoek</option>
<option value="Arabic Standard Time">(GMT+03:00) Baghdad</option>
<option value="Arab Standard Time">(GMT+03:00) Kuwait, Riyadh</option>
<option value="Russian Standard Time">(GMT+03:00) Moscow, St. Petersburg, Volgograd</option>
<option value="E. Africa Standard Time">(GMT+03:00) Nairobi</option>
<option value="Georgian Standard Time">(GMT+03:00) Tbilisi</option>
<option value="Iran Standard Time">(GMT+03:30) Tehran</option>
<option value="Arabian Standard Time">(GMT+04:00) Abu Dhabi, Muscat</option>
<option value="Azerbaijan Standard Time">(GMT+04:00) Baku</option>
<option value="Mauritius Standard Time">(GMT+04:00) Port Louis</option>
<option value="Caucasus Standard Time">(GMT+04:00) Yerevan</option>
<option value="Afghanistan Standard Time">(GMT+04:30) Kabul</option>
<option value="Ekaterinburg Standard Time">(GMT+05:00) Ekaterinburg</option>
<option value="Pakistan Standard Time">(GMT+05:00) Islamabad, Karachi</option>
<option value="West Asia Standard Time">(GMT+05:00) Tashkent</option>
<option value="India Standard Time">(GMT+05:30) Chennai, Kolkata, Mumbai, New Delhi</option>
<option value="Sri Lanka Standard Time">(GMT+05:30) Sri Jayawardenepura</option>
<option value="Nepal Standard Time">(GMT+05:45) Kathmandu</option>
<option value="N. Central Asia Standard Time">(GMT+06:00) Almaty, Novosibirsk</option>
<option value="Central Asia Standard Time">(GMT+06:00) Astana, Dhaka</option>
<option value="Myanmar Standard Time">(GMT+06:30) Yangon (Rangoon)</option>
<option value="SE Asia Standard Time">(GMT+07:00) Bangkok, Hanoi, Jakarta</option>
<option value="North Asia Standard Time">(GMT+07:00) Krasnoyarsk</option>
<option value="China Standard Time">(GMT+08:00) Beijing, Chongqing, Hong Kong, Urumqi</option>
<option value="North Asia East Standard Time">(GMT+08:00) Irkutsk, Ulaan Bataar</option>
<option value="Singapore Standard Time">(GMT+08:00) Kuala Lumpur, Singapore</option>
<option value="W. Australia Standard Time">(GMT+08:00) Perth</option>
<option value="Taipei Standard Time">(GMT+08:00) Taipei</option>
<option value="Tokyo Standard Time">(GMT+09:00) Osaka, Sapporo, Tokyo</option>
<option value="Korea Standard Time">(GMT+09:00) Seoul</option>
<option value="Yakutsk Standard Time">(GMT+09:00) Yakutsk</option>
<option value="Cen. Australia Standard Time">(GMT+09:30) Adelaide</option>
<option value="AUS Central Standard Time">(GMT+09:30) Darwin</option>
<option value="E. Australia Standard Time">(GMT+10:00) Brisbane</option>
<option value="AUS Eastern Standard Time">(GMT+10:00) Canberra, Melbourne, Sydney</option>
<option value="West Pacific Standard Time">(GMT+10:00) Guam, Port Moresby</option>
<option value="Tasmania Standard Time">(GMT+10:00) Hobart</option>
<option value="Vladivostok Standard Time">(GMT+10:00) Vladivostok</option>
<option value="Central Pacific Standard Time">(GMT+11:00) Magadan, Solomon Is., New Caledonia</option>
<option value="New Zealand Standard Time">(GMT+12:00) Auckland, Wellington</option>
<option value="Fiji Standard Time">(GMT+12:00) Fiji, Kamchatka, Marshall Is.</option>
<option value="Tonga Standard Time">(GMT+13:00) Nuku'alofa</option>
<option value="Azores Standard Time">(GMT-01:00) Azores</option>
<option value="Cape Verde Standard Time">(GMT-01:00) Cape Verde Is.</option>
<option value="Mid-Atlantic Standard Time">(GMT-02:00) Mid-Atlantic</option>
<option value="E. South America Standard Time">(GMT-03:00) Brasilia</option>
<option value="Argentina Standard Time">(GMT-03:00) Buenos Aires</option>
<option value="SA Eastern Standard Time">(GMT-03:00) Georgetown</option>
<option value="Greenland Standard Time">(GMT-03:00) Greenland</option>
<option value="Montevideo Standard Time">(GMT-03:00) Montevideo</option>
<option value="Newfoundland Standard Time">(GMT-03:30) Newfoundland</option>
<option value="Atlantic Standard Time">(GMT-04:00) Atlantic Time (Canada)</option>
<option value="SA Western Standard Time">(GMT-04:00) La Paz</option>
<option value="Central Brazilian Standard Time">(GMT-04:00) Manaus</option>
<option value="Pacific SA Standard Time">(GMT-04:00) Santiago</option>
<option value="Venezuela Standard Time">(GMT-04:30) Caracas</option>
<option value="SA Pacific Standard Time">(GMT-05:00) Bogota, Lima, Quito, Rio Branco</option>
<option value="Eastern Standard Time">(GMT-05:00) Eastern Time (US & Canada)</option>
<option value="US Eastern Standard Time">(GMT-05:00) Indiana (East)</option>
<option value="Central America Standard Time">(GMT-06:00) Central America</option>
<option value="Central Standard Time">(GMT-06:00) Central Time (US & Canada)</option>
<option value="Central Standard Time (Mexico)">(GMT-06:00) Guadalajara, Mexico City, Monterrey</option>
<option value="Canada Central Standard Time">(GMT-06:00) Saskatchewan</option>
<option value="US Mountain Standard Time">(GMT-07:00) Arizona</option>
<option value="Mountain Standard Time (Mexico)">(GMT-07:00) Chihuahua, La Paz, Mazatlan</option>
<option value="Mountain Standard Time">(GMT-07:00) Mountain Time (US & Canada)</option>
<option value="Pacific Standard Time">(GMT-08:00) Pacific Time (US & Canada)</option>
<option value="Pacific Standard Time (Mexico)">(GMT-08:00) Tijuana, Baja California</option>
<option value="Alaskan Standard Time">(GMT-09:00) Alaska</option>
<option value="Hawaiian Standard Time">(GMT-10:00) Hawaii</option>
<option value="Samoa Standard Time">(GMT-11:00) Midway Island, Samoa</option>
<option value="Dateline Standard Time">(GMT-12:00) International Date Line West</option>
</select>
	*/
    }
}
