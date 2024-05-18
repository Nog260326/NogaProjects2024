using Elasticsearch.Net;
using System;
using System.Collections.Generic;

namespace Object_Oriented_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList l = new LinkedList(1);
            l.Append(2);
            //int p = l.Unqueue();
            l.Append(3);
            Console.WriteLine(l.ToString());
            //Console.WriteLine(p);
            IEnumerable<int> list_enum = l.ToList();
            foreach (int val in list_enum)
            {
                Console.WriteLine(val);
            }

            NumericalExpression n = new NumericalExpression(18);
            Console.WriteLine(n.GetValue());
            string[] sen = n.Make_String();
            for (int i = 0; i < sen.Length; i++)
            {
                Console.Write(sen[i]);
            }
            Console.WriteLine();
            long sum = n.SumLetters(n.Number);
            Console.WriteLine(sum);
        }
    }
}
