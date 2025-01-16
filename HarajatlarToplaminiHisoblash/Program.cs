using System;
namespace HarajatlarToplaminiHisoblash
{
    class HarajatlarToplaminiHisoblash
    {
        static void Main()
        {
            System.Console.WriteLine("nechta son kiritmoqchisiz");
            int n = Convert.ToInt32(Console.ReadLine());
            int yigindi = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i} - kiriting");
                int number = Convert.ToInt32(Console.ReadLine());
                yigindi += number;
            }
            Console.WriteLine("natija = " + yigindi);
        }
    }
}