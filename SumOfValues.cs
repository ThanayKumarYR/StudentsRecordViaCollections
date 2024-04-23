using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProblems
{
    class SumOfValues
    {
        static void Main(string[] args)
        {
            Dictionary<String,int> dictionary = new Dictionary<String,int>();
            dictionary.Add("India",1);
            dictionary.Add("US",2);
            dictionary.Add("Russia",3);
            dictionary.Add("Uk",4);
            dictionary.Add("France",5);
            dictionary.Add("China",6);
            dictionary.Add("Saudi",7);
            dictionary.Add("Australia",8);
            dictionary.Add("Israil",9);
            dictionary.Add("Pakistan",10);

            Console.WriteLine("Displaying the dictionary,");
            foreach (var item in dictionary.Keys)
            {
                Console.WriteLine($"Keys = {item}, Ranks = {dictionary[item]}");
            }

            Dictionary<string,int>.ValueCollection values  = dictionary.Values;

            int sumOfValues = values.Sum();

            Console.WriteLine("\nSum of the values in dictionary is " + sumOfValues);
        }
    }
}
