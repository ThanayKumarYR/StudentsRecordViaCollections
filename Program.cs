


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Students Record !");
            Dictionary<string, string> dicts = new Dictionary<string, string>() ;
            dicts.Add("Student ID","Students Name");
          
            while (true) 
            {
                try 
                {
                    Console.WriteLine("1.Add Student 2.Update 3.Display all 4.Remove 5.Exit");
                    Console.Write("Enter the choice = ");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Adding the student !");
                            Console.Write("Enter the students id = ");
                            string id = Console.ReadLine();
                            Console.Write("Enter the students name = ");
                            string name = Console.ReadLine();
                            dicts[id] = name;
                            break;
                        case 2:
                            Console.Write("Enter the students id to update name = ");
                            string Sid = Console.ReadLine();
                            if (dicts.ContainsKey(Sid))
                            {
                                Console.WriteLine($"Your accessing the Students id = {Sid} with name = {dicts[Sid]}");
                                Console.Write("Enter the updated the name = ");
                                string newName = Console.ReadLine();
                                dicts[Sid] = newName;
                                Console.WriteLine($"Your accessing the Students id = {Sid} with name = {dicts[Sid]}");
                            }
                            else
                            {
                                Console.WriteLine("Entered id is not there in Students Record !");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Displaying all the students record !");
                            foreach (string item in dicts.Keys)
                            {
                                Console.WriteLine($" {item} : {dicts[item]}");
                            }
                            break;

                        case 4:
                            Console.Write("Enter the id to delete the student !");
                            string DeleteId = Console.ReadLine();
                            if (dicts.ContainsKey(DeleteId))
                            {
                                Console.WriteLine($"Your deleting the Students id = {DeleteId} with name = {dicts[DeleteId]}");
                                dicts.Remove(DeleteId);
                            }
                            else
                            {
                                Console.WriteLine("Entered id is not there in Students Record !");
                            }
                            break;

                        case 5: return;
                    }
                }
                catch (Exception ex) { Console.WriteLine("\n" + ex.Message + "\n"); }
            }
        }
    }
}
