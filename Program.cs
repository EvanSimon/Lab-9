using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int usernum = 0;
            string userinput;
            List<string> names = new List<string>();
            names.Add  ("Mace");
            names.Add  ("Ty");
            names.Add  ("Mauricio");
            names.Add  ("Brian");
            names.Add  ("Sean O");
            names.Add  ("Steve");
            names.Add  ("Toney");
            names.Add ("Heather");
            names.Add  ("Johnathan");
            names.Add ("Nicholas");
            names.Add  ("Andrea");
            names.Add ("Katie");
            names.Add ("David");
            names.Add  ("Rudy");
            names.Add ("Jackie");
            names.Add ("Camille");
            names.Add ("Clayton");
            names.Add  ("Levi");
            names.Add  ("Evan");

            List<string> hometown = new List<string>();
            hometown.Add ("Detroit");
            hometown.Add  ("Pontiac");
            hometown.Add  ("Bloomfield Hills");
            hometown.Add  ("Anna Arbor");
            hometown.Add  ("Flint");
            hometown.Add  ("Toledo");
            hometown.Add  ("Troy");
            hometown.Add  ("Detroit");
            hometown.Add  ("Grand Rapids");
            hometown.Add  ("Pontiac");
            hometown.Add  ("Detroit");
            hometown.Add  ("Saginaw");
            hometown.Add  ("Bloomfield Hills");
            hometown.Add  ("Detroit");
            hometown.Add  ("Grosse Point");
            hometown.Add  ("Flint");
            hometown.Add  ("Anna Arbor");
            hometown.Add  ("Grosse Point");
            hometown.Add  ("Waterville");

            List<string> food = new List<string>();
            food.Add ("Pizza");
            food.Add ("Pasta");
            food.Add ("Raman");
            food.Add ("Burgers");
            food.Add ("Chicken Shawarma");
            food.Add ("French Fries");
            food.Add  ("Sushi");
            food.Add ("Cake");
            food.Add ("Chocolate");
            food.Add ("Pizza");
            food.Add ("Ramna");
            food.Add ("Chcolate");
            food.Add ("Tacos");
            food.Add ("Pasta");
            food.Add ("Sushi");
            food.Add ("Chicken Shawarma");
            food.Add ("Cake");
            food.Add ("Pizza");
            food.Add ("Grilled Octopus");
            List<string> color = new List<string>();
            color.Add("Purple");
            color.Add("Blue");
            color.Add("Gray");
            color.Add("Pink");
            color.Add("Purple");
            color.Add("Green");
            color.Add("Red");
            color.Add("Gray");
            color.Add("Purple");
            color.Add("Green");
            color.Add("Pink");
            color.Add("Purple");
            color.Add("Blue");
            color.Add("Red");
            color.Add("Purple");
            color.Add("Green");
            color.Add("Pink");
            color.Add("Blue");
            color.Add("Green");

            bool exitProg = false;
            while (exitProg == false) //while loop for the whole program
            {
                Console.WriteLine("Welcom to our C# class.");

                while (true) // while loop for student name
                {
                    Console.WriteLine("Which student would you like to learn more about? (Enter a number 0 - 18)");
                    try //try for 
                    {

                        usernum = int.Parse(Console.ReadLine());
                        Console.WriteLine("Student {0}:", names[usernum]);
                        break;
                    }

                    catch (IndexOutOfRangeException) //incase user goes out of range it catches these two exeptions
                    {
                        Console.WriteLine("That student doesn't exist, try agian");
                        continue;
                    }


                    catch (FormatException)
                    {
                        Console.WriteLine("That student doesn't exist, try agian");
                        continue;
                    }

                }

                Console.WriteLine("Would you like to know more about this student? Enter \"hometown\" or \"favoritefood\" ");
                string input = Console.ReadLine().ToLower();
                while (input != "hometown" && input != "favoritefood")// loop for the hometown/favoritefood validation
                {

                    Console.WriteLine("That data type does not exist try agian");
                    input = Console.ReadLine().ToLower(); //reading user input
                }

                if (input == "hometown") //if hometown it prints else food
                {
                    Console.WriteLine("{0} is from {1}", names[usernum], hometown[usernum]);
                }

                else if (input == "favoritefood")
                {
                    Console.WriteLine("{0} favorite food is {1}", names[usernum], food[usernum]);
                }


                Console.WriteLine("Would you like to know this students favorite color? Type \"color\" ");
                 input = Console.ReadLine().ToLower();
                while (input != "color")// loop for the hometown/favoritefood validation
                {

                    Console.WriteLine("That data type does not exist type \"color\"");
                    input = Console.ReadLine().ToLower(); //reading user input
                }



                if (input == "color")
                {
                    Console.WriteLine("{0} favorite color is {1}", names[usernum], color[usernum]);
                }



                while (true) // while loop for the user to continue
                {
                    Console.WriteLine("Would you like to continue y/n ?");
                    string answer = Console.ReadLine().ToLower();

                    if (answer == "y") //if yes it breaks this loops and the false function runs it back to the top of the program loop
                    {
                        exitProg = false;
                        break;
                    }

                    else if (answer == "n")//if no it breaks the loop agian but true function ends the program; n
                    {
                        exitProg = true;
                        break;
                    }


                    else if (answer != "y" || answer != "n") //if anything other then y or n it continues to ask the user
                    {
                        Console.WriteLine("Would you like to continue y/n ?");
                        answer = Console.ReadLine();
                        continue;
                    }

                }



            }


        }


    }   
}

