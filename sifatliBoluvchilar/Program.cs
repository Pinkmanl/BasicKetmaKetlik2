using System;
namespace sifatliBoluvchilar
{
    class sifatliBoluvchilar
    {
        static void Main()
        {
           
            Console.WriteLine("Sonni kiriting");
            int number = Convert.ToInt32(Console.ReadLine());
          
            int sanoq = 0;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    
                    sanoq++;
                }
            }
            Console.WriteLine("Output = "+sanoq);
        }
    }
}