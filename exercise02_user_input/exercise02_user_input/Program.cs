/*
اكتبي برنامج يسمح للمستخدم بإدخال 5 أرقام من نوع double ؛ ثم 
جدي مجموع ومتوسط الأرقام(مجموع القيم / عددها).
*/
using System;
namespace exercise02_user_input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter five numbers, please ...");
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double n3 = double.Parse(Console.ReadLine());
            double n4 = double.Parse(Console.ReadLine());
            double n5 = double.Parse(Console.ReadLine());

            double sum = n1 + n2 + n3 + n4 + n5;
            double avg = sum / 5;
            Console.WriteLine("Sum = "+sum+"\nAvarage = "+avg);
            
        }
    }
}
