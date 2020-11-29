using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationsAndDecisions
{
    class Program
    {
        //Базовый цикл for/
        static void ForLoopExample()
        {
            //Обратите внимание, что переменная i видима только в контексте цикла for/
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("Number is: {0} ", i);
            }
            //Здесь переменная ш больше видимой не будет.

            Console.ReadLine();
        }
        //Проход по элементам масива посредством foreach.
        static void ForEachLoopExample()
        {
            string[] carTypes = { "Ford", "BMW", "Yugo", "Honda" };
            foreach (string c in carTypes)
                Console.WriteLine(c);

            int[] myInts = { 10, 20, 30, 40 };
            foreach (int i in myInts)
                Console.WriteLine(i);

            Console.ReadLine();
        }

        static void LinqQueryOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

            //Запрос LINQ!
            var subset = from i in numbers where i < 10 select i;
            Console.Write("Values in subset: ");

            foreach (var i in subset)
            {
                Console.Write("{0} ", i);
            }

            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            ForLoopExample();
            ForEachLoopExample();
            LinqQueryOverInts();
        }
    }
}
