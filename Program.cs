
using System;
namespace UsingOperator
{
    class Program
    {
        private static void Main(string[] args)
        {
            float Width;
            float Height;
            Console.WriteLine("Nhap gia tri cho hinh chu nhat");
            Console.WriteLine("Nhap gia tri chieu rong");
            Width = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap gia tri chieu cao");
            Height = float.Parse(Console.ReadLine());
            Console.WriteLine("Dien tich hinh chu nhat la:" +  Width*Height);
        }
    }
}
