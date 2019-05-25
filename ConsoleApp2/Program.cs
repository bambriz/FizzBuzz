using System;
using FizzBuzzLib;
using System.Collections;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz c = new FizzBuzz(15);
            ArrayList a = c.getFizzBuzz();
            for(int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }
            FizzBuzz d = new FizzBuzz(60);
            d.addFizzBuzzPair(2, "Cheese");
            d.addFizzBuzzPair(5, "Whip");
            d.addFizzBuzzPair(4, "Extra");
            d.addFizzBuzzPair(12, "Yuck");
            ArrayList b = d.getCustomFizzBuzz();
            foreach(string s in b)
            {
                Console.WriteLine(s); 
            }
        }
    }


}
