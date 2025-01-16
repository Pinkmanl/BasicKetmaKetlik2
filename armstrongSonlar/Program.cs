
using System;
namespace boluvchisizSonlar
{
    class boluvchisizSonlar
    {
        static void Main()
        {
            Console.WriteLine("sonni kiriting");
            int number = Convert.ToInt32(Console.ReadLine());

            int r1 = number % 10 / 1;
            int r10 = number % 100 / 10;
            int r100 = number % 1000 / 100;
            Console.WriteLine(Math.Pow(r100, r1) + Math.Pow(r10, r1) + Math.Pow(r1, r1)==number?"Armstrong son":"Armstrong son emas");



        }
    }
}
