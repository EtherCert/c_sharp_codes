/*
اكتبي برنامج يسمح للمستخدم بإدخال طول وعرض المستطيل ثم احسبي:
مساحة المستطيل (الطول * العرض)
محيط المستطيل  2*(الطول + العرض)
*/
using System;
namespace exercise03_user_input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Width ..");
            double width = double.Parse(Console.ReadLine());//استقبال العرض
            Console.WriteLine("Enter length ..");
            double length = double.Parse(Console.ReadLine());//استقبال الطول
            
            double area = width * length; // حساب مساحة المستطيل
            double perimeter = 2 * (width + length); // حساب محيط المستطيل

            Console.WriteLine("Area = "+area+ "\nPerimeter = "+ perimeter);// طباعة النتائج

        }
    }
}
