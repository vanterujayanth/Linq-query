using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQueryDemo
{
    public  class LiqueryDemo1
    {
        public LiqueryDemo1()
        {
            string[] names = { "Life is Beautiful",
                              "Arshika Agarwal",
                              "Seven Pounds",
                              "Rupali Agarwal",
                              "Pearl Solutions",
                              "Vamika Agarwal",
                              "Vidya Vrat Agarwal",
                              "C-Sharp Corner Mumbai Chapter"
                           }; // input data
            var myLinqQuery = from name in names        // // LINQ Query 1 
                              where name.Contains('a')
                              select name;
            // Query execution
            Console.WriteLine("we will get the list of names :");
            foreach (var name in myLinqQuery)
            {
                Console.WriteLine(name + "  ");
            } 
            Console.WriteLine();

            // query 2
           var myLinqQuery2 =from name in names
                             where name.Length > 14
                             select name;
            // query execuation 
            Console.WriteLine("here we will get the list of the names who's length is 14 : ");
            foreach (var name in myLinqQuery2)
            {
                Console.WriteLine(name + "   ");
            }
            Console.WriteLine();

        }
        
    }
}
