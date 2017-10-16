using System;
using System.Collections;
using System.Collections.Generic;

namespace opdrachtweek3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer een getal in");

            int getal = Convert.ToInt32(Console.ReadLine());

            //aanmaken array
            int[] solutionArray = new int[11];
            //aanmake hashtable
            Hashtable solutionHashtable = new Hashtable();
            //aanmaken List
            var solutionList = new List<int>();

            Console.WriteLine("Vermenigvuldigtal: {0}", getal);
            Console.WriteLine("Vermenigvuldigingstafel:");

            for (int i = 0; i <= 10; i++) {
                int result =  i*getal;
                putResultInArray(solutionArray, solutionHashtable, solutionList, result, i);
                Console.WriteLine("{0} x {1} = {2} ",i,getal,result);
            }
        
            writeArray(solutionArray);
            writeHashtable(solutionHashtable);
            writeList(solutionList);
           
        }

        private static void putResultInArray(int[] solutionArray, Hashtable solutionHashtable,List<int> solutionList, int result, int i) {
            solutionArray[i] = result;
            solutionHashtable[i] = result;
            solutionList.Add(result);
        }

        private static void writeArray(int[] solutionArray) {
            Console.WriteLine("Resultaten in een array:");
            for (int i = 0; i < 11; i++) {
                Console.WriteLine("{0}",solutionArray[i]);
            }  
        }

        private static void writeHashtable(Hashtable solutionHashtable) {
            Console.WriteLine("Resultaten in een hashtable:");
            for (int i = 0; i < 11; i++) {
                Console.WriteLine("{0}",solutionHashtable[i]);
            }  
        }

        private static void writeList(List<int> solutionList) {
            Console.WriteLine("Resultaten in een list:");
            for (int i = 0; i < 11; i++) {
                Console.WriteLine("{0}",solutionList[i]);
            }  
        }
    }
}
