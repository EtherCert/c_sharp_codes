/*
اكتبي برنامج بلغة السي شارب يسمح للمستخدم بإدخال:
اسمه
عمره
رقم الجوال 
عنوان السكن
من ثم طباعة ما أدخله المستخدم بتنسيق
كما هو موضح بالصورة:
*/
using System;
namespace exercise01_user_input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            string age = Console.ReadLine();
            Console.WriteLine("Enter your phone:");
            string phone = Console.ReadLine();
            Console.WriteLine("Enter your address:");
            string address = Console.ReadLine();
            Console.WriteLine("-+-+-+-+ Your Info -+-+-+-+-\nName: " + name + "\nAge: " + age + "\nphone: " + phone + "\naddress: " + address + "\n-+-+-+-+-+-+-+-+-+-+-+-+-+-");
        }
    }
}


