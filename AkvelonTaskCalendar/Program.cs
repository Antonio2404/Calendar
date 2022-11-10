using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AkvelonTaskCalendar
{
    
    class Program
    {

        static void Main(string[] args)
        {
            //DateExep Exep = new DateExep();
            PrintCalendar PrCalendar = new PrintCalendar();

            string[] split = Console.ReadLine().Split('.', ',', '/', ' ');

            try
            {
                SplEx(split.Length);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Не Верно введена дата!");
                Environment.Exit(0);
            }
            
            Iskl(split[0], split[1], split[2]);

            // определение количества дней в месяце
            int dayMonth = DateTime.DaysInMonth(int.Parse(split[2]), byte.Parse(split[1]));

            // определение с какого дня недели по счету начинается месяц
            DateTime dt = new DateTime(int.Parse(split[2]), byte.Parse(split[1]), 1);
            int OneDayOfWeek = (int)dt.DayOfWeek;

            // назначение sunday седьмым днем
            if (OneDayOfWeek == 0)
                OneDayOfWeek += 7;

            PrCalendar.OutCalendar(dayMonth, byte.Parse(split[0]), OneDayOfWeek);

            Console.SetCursorPosition(0,10);

        }

        public static void Iskl(string _DayExep, string _MonthExep, string _YearExep)
        {
            try
            {
                byte DayExep = byte.Parse(_DayExep);
                byte MonthExep = byte.Parse(_MonthExep);
                int YearExep = int.Parse(_YearExep);

                ExDate(DayExep, MonthExep, YearExep);
            }

            catch (FormatException)
            {
                Console.WriteLine("Не верный тип данных!");
                Environment.Exit(0);
            }

            catch (ArgumentNullException)
            {
                Console.WriteLine("Не верный диапазон даты!");
                Environment.Exit(0);
            }

        }
        public static void ExDate(byte day, byte month, int year)
        {
            if (day <= 0 || day > 31)
                throw new ArgumentNullException();
            if (month <= 0 || month > 12)
                throw new ArgumentNullException();
            if (year < 1600 || year > 2400)
                throw new ArgumentNullException();
        }

        public static void SplEx(int a)
        {
            if (a < 3 || a > 3)
                throw new ArgumentNullException();
            
            
        }

    }
}
