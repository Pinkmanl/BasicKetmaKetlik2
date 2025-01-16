using System;
namespace darajaHisoblash
{
    class darajaHisoblash
    {
        static void Main()
        {
            Console.WriteLine("bu dastur sonni darajasini hisoblar ekan");
            Console.WriteLine("sonni kiriting");
            int number = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("darajasini kiriting");
            int daraja = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine($"javobi = {Math.Pow(number,daraja)}");
        
        }
    }
}