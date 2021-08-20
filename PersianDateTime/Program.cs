using System;
using System.Globalization;

namespace PersianDateTime
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var k = new dttm();
            Console.WriteLine("perisan : " + k.Get_Tarikh());
            Console.WriteLine("miladi : " + k.ToMiLadi(k.Get_Tarikh()).ToString("yyyy/MM/dd"));
            Console.WriteLine("time : " + k.Get_Time());
            Console.WriteLine("time : " + k.Get_Time_Full());
            Console.WriteLine("makedate : " + k.MakeDate("98/1/1"));
            Console.WriteLine("addday : " + k.ezaf_Kam_Day(k.Get_Tarikh(), 10));
            Console.WriteLine("Beforeday : " + k.ezaf_Kam_Day(k.Get_Tarikh(), -10));
            Console.WriteLine("MahName : " + k.Get_Mah_Name(k.Get_Tarikh()));
            Console.WriteLine("MahName int = 6 : " + k.Get_Mah_Name(6));
            Console.WriteLine("day of week  : " + k.Get_Day_Name_Week(k.Get_Tarikh()));
            Console.WriteLine("tafazol : " + k.Tafazol_Tarikh(k.Get_Tarikh(),"1398/06/01"));
            Console.ReadKey();
        }
        
    }
}
