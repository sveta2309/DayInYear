using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Month
    {

        public string ReturnDate(int day, bool b)
        {
            int monthNumber = ReturnNumberOfMonth(day, b);
            string monthStr = ReturnMonth(monthNumber);
            int dayOfMonth = ReturnDay(day, monthNumber, b);
            return dayOfMonth + " " + monthStr;

        }

        public int ReturnNumberOfMonth(int day, bool b)
        {
            Dictionary<int, int> months = new Dictionary<int, int>();
            months.Add(1, 1);
            months.Add(2, 32);
            months.Add(3, 60);
            months.Add(4, 91);
            months.Add(5, 121);
            months.Add(6, 152);
            months.Add(7, 182);
            months.Add(8, 213);
            months.Add(9, 244);
            months.Add(10, 274);
            months.Add(11, 305);
            months.Add(12, 335);
            if (b == true)
            {
                for (int i = 0; i < 10; i++)
                {
                    months[3 + i] += 1;
                }
            }

            int month = 0;

            for (int i = 1; i < months.Count - 1; i++)
            {

                if (months[i] <= day && months[i + 1] > day)
                {
                    month = i;
                    break;
                }
            }
            return month;
        }
        public string ReturnMonth(int month)
        {
            Dictionary<int, string> months = new Dictionary<int, string>();
            months.Add(1, "January");
            months.Add(2, "February");
            months.Add(3, "March");
            months.Add(4, "April");
            months.Add(5, "May");
            months.Add(6, "June");
            months.Add(7, "July");
            months.Add(8, "August");
            months.Add(9, "September");
            months.Add(10, "October");
            months.Add(11, "November");
            months.Add(12, "December");

            return months[month];
        }

        public int ReturnDay(int day, int monthNumber, bool b)
        {
            Dictionary<int, int> months = new Dictionary<int, int>();
            months.Add(1, 1);
            months.Add(2, 32);
            months.Add(3, 60);
            months.Add(4, 91);
            months.Add(5, 121);
            months.Add(6, 152);
            months.Add(7, 182);
            months.Add(8, 213);
            months.Add(9, 244);
            months.Add(10, 274);
            months.Add(11, 305);
            months.Add(12, 335);
            if (b == true)
            {
                for (int i = 0; i < 10; i++)
                {
                    months[3 + i] += 1;
                }
            }

            return day - months[monthNumber] + 1;

        }

    }
}
