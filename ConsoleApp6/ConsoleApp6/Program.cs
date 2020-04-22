using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                Menu menu = new Menu();
                menu.InputDay();
                int day = menu.ReadDay();
                if(day<1 || day>365)
                {
                    throw new Exception("Incorrect day. Year can contain only 1-365 days.");
                }
                bool b = menu.InputYear();
                Month month = new Month();
                Console.WriteLine(month.ReturnDate(day,b));
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error.{ex.Message }");
            }
            finally
                {
                Console.ReadLine();
            }
        }
    }
}
