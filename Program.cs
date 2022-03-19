// See https://aka.ms/new-console-template for more information
using System;

namespace Mod4
{
    class Program
    {
        static void Main(String[] args)
        {
            int hasil = Penjumlahan.JumlahTigaAngka<int>(13, 02, 20);
            Console.WriteLine(hasil);
        }
    }
    class Penjumlahan
    {
        public static T JumlahTigaAngka<T>(T a, T b, T c)
        {
            dynamic tempA = a;
            dynamic tempB = b;
            dynamic tempC = c;

            return tempA + tempB + tempC;
        }
    }
}

