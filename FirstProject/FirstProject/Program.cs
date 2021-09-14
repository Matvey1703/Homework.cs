using System;
using System.Collections;
using System.Collections.Generic;

namespace FirstProject
{
    public class Person
    {
        public Person(string Name, string Adress)
        {
            this.Name = Name;
            this.Adress = Adress;
        }

        private string Name;
        private string Adress;
    }


    static class MapFilterFold
    {
        static List<int> NewMap(Func<int, int> f, List<int> list)
        {
            var result = new List<int>();
            foreach (var el in list)
            {
                result.Add(f(el));
            }
            return result;
        }

        static List<int> NewFilter(Func<int, bool> f, List<int> list)
        {
            var result = new List<int>();
            foreach (var el in list)
            {
                if (f(el))
                {
                    result.Add(el);
                }
            }
            return result;
        }

        static int NewFold(Func<int, int, int> f, List<int> list, int acc)
        {
            foreach (var el in list)
            {
                acc = f(acc, el);
            }
            return acc;
        }
    }

    


    class Program
    {

        static int Factorial(int num)
        {
            int acc = 1;
            for (int i = 1; i <= num; i++)
            {
                acc *= i;
            }
            return acc;
        }

        static int FactorialRec(int num)
        {
            return num < 2 ? 1 : num * FactorialRec(num - 1);
        }

        static void Main(string[] args)
        {
            int res = Factorial(5);
            var person = new Person("Dmitry", "Metro");
            Console.WriteLine("Result: ");
            Console.WriteLine(Factorial(5));
            Console.WriteLine(FactorialRec(5));
        }
    }
}
