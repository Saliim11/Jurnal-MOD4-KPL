using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302200119
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Penjumlahan.JumlahTigaAngka<long>(13, 02, 20);

            SimpleDataBase<long> simpleData = new SimpleDataBase<long>();

            simpleData.AddNewData(13);
            simpleData.AddNewData(02);
            simpleData.AddNewData(20);
            simpleData.PrintAllData();
        }
    }

    class Penjumlahan
    {
        public static void JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
        {
            dynamic n1 = angka1;
            dynamic n2 = angka2;
            dynamic n3 = angka3;
            Console.WriteLine(n1 + n2 + n3);
            
        }
    }

    class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            this.storedData = new List<T>();
            this.inputDates = new List<DateTime>();
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
                Console.WriteLine("Data "+(i+1)+" berisi: "+storedData[i]
                    +", yang disimpan pada waktu UTC: "+inputDates[i]);
            }
        }
    }
}
