using System;

namespace Laba_6_KTP
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {   Console.WriteLine("Введiть число: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ви ввели число: " + num);   
            }
            catch (FormatException) 
            {
            
                Console.WriteLine("Ви ввели не число");
            }
            
               
        }
    }
}   
