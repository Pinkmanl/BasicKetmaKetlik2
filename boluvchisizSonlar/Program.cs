using System;
namespace boluvchisizSonlar
{
    class boluvchisizSonlar
    {
        static void Main()
        {
            System.Console.WriteLine("bu dastur kiritligan sonni 2 dan 10 gacha bo'lovchilarini topadi");
            System.Console.WriteLine("Sonni kiriting");
            int namber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Boluvchilari: = ");
            for (int i = 2; i <= 10; i++)
            {
                if (namber % i == 0)
                {
                    Console.Write("  " + i);
                }
            }
        }
    }
}