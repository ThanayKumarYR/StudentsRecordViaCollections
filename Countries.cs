using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProblems
{
    class Countries
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Afghanistan" , "Kabul");
            hashtable.Add("India", "Delhi");
            hashtable.Add("Pakistan" , "Islamabad");
            hashtable.Add("France" , "Paris");
            hashtable.Add("Srilanka" , "Columbo");
            hashtable.Add("Russia" , "Mosckow");
            hashtable.Add("Usa" , "Washington");
            hashtable.Add("UK" , "London");
            hashtable.Add("Brazil", "Brazilia");
            hashtable.Add("Australia", "Sydney");
            hashtable.Add("Canada", "Ottawa");
            hashtable.Add("China", "Beijing");
            hashtable.Add("Suadi Arabia", "Riadh");


            Console.WriteLine("The contries present are,");
            foreach (var item in hashtable.Keys)
            {
                Console.WriteLine(item);
            }

            Console.Write("\nEnter the country name to get its capital = ");
            string country = Console.ReadLine();
            if (hashtable.ContainsKey(country))
            {
                Console.WriteLine($"Country = {country} and its capital is {hashtable[country]}");
            }
            else 
            {
                Console.WriteLine("Country is not present in the hashtable !");
            }
        }
    }
}
