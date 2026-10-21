using System;

namespace Baitap
{
    class Program
    {
        //static int Tinhtong(int a, int b) - //TinhTong(B1)
        //{  return a + b; }
        //---------------------------------------------------------------

        //static void Hoanvi(ref int n)         // Hoan Vi (B1)
        //{
        //    n = 10000;
        //}
        //---------------------------------------------------------------

        //static void TinhThuong(              //Tinh Thuong(B1)
        //    int a,int b,
        //    out double Difference)
        //{
        //    Difference = a / b;
        //}
        //----------------------------------------------------------------

        //static void HienThi<T>(T a)     //Hien Thi 1 gia tri (B2)
        //{
        //    Console.WriteLine(a);
        //}
        //----------------------------------------------------------------

        //static T Laygiatribandau<T>(T a, T b)     //LayGiatri (B2)
        //{
        //    return a;
        //}
        //----------------------------------------------------------------

        static void Hienthicap<T, V>(T a, V b)
        {
            Console.WriteLine($"Khoa: {a}");
            Console.WriteLine($"giatri: {b}");
        }

        //----------------------------------------------------------------
        static void Main()
        {
            //int x = Tinhtong(10, 29);
            //Console.WriteLine($"{x}");

            //int x = 10;
            //Hoanvi(ref x);
            //Console.WriteLine($"{x}");

            //TinhThuong(10, 5, out double Difference);
            //Console.WriteLine($"{Difference}");

            //HienThi<int>(100);
            //HienThi<double>(0.2);
            //HienThi<string>("Xin chao");

            //int x = Laygiatribandau(10, 20);
            //string y = Laygiatribandau("hello", "xin chao");
            //Console.WriteLine($"giatri: {x}");
            //Console.WriteLine($"Chu: {y}");

            Hienthicap<int, double>(10, 20.1);
            Hienthicap<double, string>(22.3, "xin chao");
        }
    }
}