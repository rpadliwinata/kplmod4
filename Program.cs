// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

namespace Mod4
{
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
}

