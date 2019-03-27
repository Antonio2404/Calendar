using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkvelonTaskCalendar
{
    public class PrintCalendar
    {
        public int dayMomth;
        public byte nowDay;
        public int OneDayOfWeek;

        public void OutCalendar(int dayMomth, byte nowDay, int OneDayOfWeek)
        {
            Console.SetCursorPosition(0, 2);
            Console.WriteLine($"mon\ntue\nwed\nthu\nfri\nsat\nsun\n");

            // i - дни месяца, j - отсчет дней недели
            for (int i = 1, j = OneDayOfWeek, x = 6, y = 2 + (OneDayOfWeek - 1); i <= dayMomth; i++)
            {
                if (i == nowDay)
                {
                    // выделение дня
                    Console.SetCursorPosition(x - 1, y);
                    Console.Write($"[{i}]");
                    j++;
                    y++;

                }
                else
                {
                    //печать обычного дня
                    Console.SetCursorPosition(x, y);
                    Console.Write(i);
                    j++;
                    y++;
                }

                //переход на следующую неделю
                if (j == 8)
                {
                    j = 1;
                    x += 4;
                    y = 2;
                }

            }


        }
    }
}
