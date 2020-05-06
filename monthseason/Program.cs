using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monthseason
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("월 : ");
            String month = Console.ReadLine();

            if (month.Contains("3") || month.Contains("4") || month.Contains("5"))
            {
                Console.WriteLine("봄");
            }
            else if (month.Contains("6") || month.Contains("7") || month.Contains("8"))
            {
                Console.WriteLine("여름");
            }
            else if (month.Contains("9") || month.Contains("10") || month.Contains("11"))
            {
                Console.WriteLine("가을");
            }
            else if (month.Contains("12") || month.Contains("1") || month.Contains("2"))
            {
                Console.WriteLine("겨울");
            }
        }
    }
}
