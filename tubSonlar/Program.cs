using System;
namespace tubSonlar
{
    class tubSonlar
    {
        static void Main()
        {

            Console.WriteLine("bu dastur kiritilgan sonni tub songa tekshiradi");

            Console.Write("input = ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sanoq = 0;
            for (int i = 1; i <= number; i++)
            {
                sanoq += number % i == 0 ? 1 : 0;

            }

            Console.WriteLine(sanoq == 2 ? "tub son" : "murakkab son");

        }
    }
}