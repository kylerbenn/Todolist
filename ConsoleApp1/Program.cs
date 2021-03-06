﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static List<string> Todos { get; set; } = new List<string>();
        public static List<string> DoneTodos { get; set; } = new List<string>();

        static void Main(string[] args)
        {

            //var todos = new List<string>()

            //var DoneTodos = new List<string>();

            Welcome();

            var name = Console.ReadLine();

            while (true)
            {
                var option = showMenuAndGetChoice(name);


                if (option == "1")
                {
                    Console.WriteLine("=============================================");

                    Console.WriteLine("Add TODO:");

                    Console.WriteLine("=============================================");

                    string input = Console.ReadLine();

                    Todos.Add(input);

                }
                else if (option == "2")
                {
                    Console.WriteLine("=============================================");

                    Console.WriteLine(" View TODOLIST:");

                    Console.WriteLine("=============================================");

                    for (var i = 0; i < Todos.Count; i++)
                    {
                        Console.WriteLine(Todos[i]);
                    }
                }
                else if (option == "3")
                {
                    Console.WriteLine("=============================================");

                    Console.WriteLine(" Remove a TODO from your TODOLIST: ");

                    Console.WriteLine("=============================================");

                    for (var i = 0; i < Todos.Count; i++)
                    {
                        Console.WriteLine((i + 1) + " - " + Todos[i]);
                    }

                    Console.WriteLine("=============================================");

                    Console.WriteLine("Enter the number of the TODO you want to remove:");

                    Console.WriteLine("=============================================");

                    string input = Console.ReadLine();

                    int choiceInt = int.Parse(input);

                    string taskToMove = Todos[choiceInt];

                    Todos.RemoveAt(choiceInt);

                    DoneTodos.Add(taskToMove);

                }

                else if (option == "4")
                {

                    Console.WriteLine("=============================================");

                    Console.WriteLine(" View Completed TODOLIST: ");

                    Console.WriteLine("=============================================");

                    for (var i = 0; i < DoneTodos.Count; i++)
                    {
                        Console.WriteLine(DoneTodos[i]);
                    }

                }

                else if (option == "5")
                {
                    Console.WriteLine("=============================================");

                    Console.WriteLine(" QUIT ");

                    Console.WriteLine("=============================================");

                    break;
                }
                else
                {
                    Console.WriteLine("Only enter 1, 2 , 3, 4, or 5");
                }
            }
        }

        static void Welcome()
        {
            Console.WriteLine("=============================================");

            Console.WriteLine("TODO APP");

            Console.WriteLine("=============================================");

            Console.WriteLine(" Please enter your name:");
        }

        public static string showMenuAndGetChoice(string name)

        {
            Console.WriteLine("=============================================");

            Console.WriteLine(" Choose an option " + name + " : ");

            Console.WriteLine("=============================================");

            Console.WriteLine(" 1. Add TODO ");

            Console.WriteLine(" 2. View TODOLIST ");

            Console.WriteLine(" 3. Remove a TODO from your TODOLIST ");

            Console.WriteLine(" 4. View Completed TODOLIST ");

            Console.WriteLine(" 5. QUIT ");

            string option = Console.ReadLine();

            return option;

        }

        
    }


}
