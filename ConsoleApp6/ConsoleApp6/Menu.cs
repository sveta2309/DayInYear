using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Menu
    {
        public void InputDay()
        {
            Console.WriteLine("Input day of year");

        }
        public int ReadDay()
        {
            int day = Convert.ToInt32(Console.ReadLine());
            return day;
        }
        public bool InputYear()
        {
            bool b;
            Console.WriteLine("Input year");
            int year = Convert.ToInt32(Console.ReadLine());
            if(year %4==0)
            {
                b = true;
            }
            else
            {
                b = false;
            }
            return b;
        }
        
    }
} 
 