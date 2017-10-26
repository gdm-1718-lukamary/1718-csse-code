using System;
using System.Collections;
using System.Collections.Generic;

namespace week4
{
    class Program
    {
        static void Main(string[] args)
        {
            //OEF SAMENVOEGEN & PRIEMGETAL TOEVOEGEN
            GeefDeelbareGetallen();
            Fibbo();


            //is priemgetal toevoegen


        }

        private static void GeefDeelbareGetallen() {
            Console.WriteLine("Voer een getal in");
            int getal = Convert.ToInt32(Console.ReadLine());
            if (getal > 100)
            {
                Console.WriteLine("Doe is normaal, das veel te groot");
            }
            else
            {
                Console.WriteLine("{0} is deelbaar door: ", getal);
                calculateNumbers(getal);
                IsHetEenPriemGetal(getal);
            }
        }

        private static void IsHetEenPriemGetal(int getal) {
            // WAAAAH
        }

        private static void calculateNumbers(int getal) {
            var numbersList = new List<int>();
            for (int i = 1; i <= getal; i++)
            {
                if(getal % i == 0){
                    numbersList.Add(i);
                    Console.WriteLine(i);
                }
            }
        }

        private static void Fibbo() {
            Console.WriteLine("Fibonacci:");

            var fibboList = new List<int>();
            fibboList.Add(1);
            fibboList.Add(1);

            for (int i = 0; i < 10; i++)
            {
                fibboList.Add(fibboList[i] + fibboList[i + 1]);
                Console.WriteLine(fibboList[i] + fibboList[i + 1]);
            }
        }
    }
}
