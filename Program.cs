﻿// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

namespace Mod4
{
    class Program
    {
        static void Main(String[] args)
        {

            int hasil = Penjumlahan.JumlahTigaAngka<int>(13, 02, 20);
            Console.WriteLine(hasil);

            SimpleDataBase<int> data = new SimpleDataBase<int>();
            data.AddNewData(13);
            data.AddNewData(02);
            data.AddNewData(20);

            data.PrintAllData();

        }
    }
    class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }

        public void AddNewData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.Now);
        }

        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine("Data " + (i+1) + " berisi: " + storedData[i].ToString() +  ", yang disimpan pada waktu " + inputDates[i]);
            }
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

