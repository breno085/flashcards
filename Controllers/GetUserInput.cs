using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using flashcards.Models;

namespace flashcards.Controllers
{
    public class GetUserInput
    {
        public void MainMenu()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Main Menu\n");
                Console.WriteLine("Type to select an option:");
                Console.WriteLine("0 - Exit");
                Console.WriteLine("1 - Manage Stacks");
                Console.WriteLine("2 - Manage Flashcards");
                Console.WriteLine("3 - Study");
                Console.WriteLine("4 - View Study Session Data\n");

                string op = Console.ReadLine();

                switch (op)
                {
                    case "0":
                        exit = true;
                        Environment.Exit(0);
                        break;
                    case "1":
                        ManageStacks();
                        break;
                    case "2":
                        FlashcardsMenu();
                        break;
                    case "3":
                        Console.WriteLine("tbd");
                        break;
                    case "4":
                        Console.WriteLine("tbd");
                        break;
                    default:
                        Console.WriteLine("Type a valid option.");
                        break;
                }
            }

        }

        private void ManageStacks()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Manage Stacks Menu\n");
                Console.WriteLine("Type to select an option:");
                Console.WriteLine("0 - Return to main menu");
                Console.WriteLine("1 - View all stacks");
                Console.WriteLine("2 - Create a stack");
                Console.WriteLine("3 - Delete a stack");

                string op = Console.ReadLine();

                switch (op)
                {
                    case "0":
                        MainMenu();
                        break;
                    case "1":
                        ViewStacks();
                        break;
                    case "2":
                        InsertStacks();
                        break;
                    case "3":
                        DeleteStacks();
                        break;
                    default:
                        Console.WriteLine("Type a valid option.");
                        break;
                }
            }
        }

        private void ViewStacks()
        {
            GetStacks();

            Console.WriteLine("Type 0 to exit\n");
            string answer = Console.ReadLine();
        }
        private void DeleteStacks()
        {
            GetStacks();

            Console.WriteLine("Input the name of the stack you want to delete");
            Console.WriteLine("or type 0 to exit\n");
            string answer = Console.ReadLine();
        }
        private void InsertStacks()
        {
            GetStacks();

            Console.WriteLine("Input the name of the stack you want to insert");
            Console.WriteLine("or type 0 to exit\n");
            string answer = Console.ReadLine();
        }

        private void GetStacks()
        {
            Console.WriteLine("tbd");
        }

        private void FlashcardsMenu()
        {
            GetStacks();

            Console.WriteLine("Choose the name of the stacks of flashcards you want to interact with");
            Console.WriteLine("Or type 0 to return to the main menu\n");

            string answer = Console.ReadLine();

            ManageFlashcards(answer);

        }

        private void ManageFlashcards(string stack)
        {
            bool exit = false;

            while (!exit)
            {   Console.WriteLine($"Currently working on {stack} stack\n");
                Console.WriteLine("Type to select an option:");
                Console.WriteLine("0 - Return to main menu");
                Console.WriteLine("1 - View front of all flashcards in stack");
                Console.WriteLine("2 - View all flashcards");
                Console.WriteLine("3 - Create a flashcard in current stack");
                Console.WriteLine("4 - Edit a flashcard");
                Console.WriteLine("5 - Delete a flashcard");

                string op = Console.ReadLine();

                switch (op)
                {
                    case "0":
                        exit = true;
                        Environment.Exit(0);
                        break;
                    case "1":
                        ManageStacks();
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    default:
                        Console.WriteLine("Type a valid option.");
                        break;
                }
            }
        }
    }
}