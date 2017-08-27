using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {

            //Overall notes: 
            //Case of user input should not matter
            //The user should have the option to type "Quit" at any time: the user types quit and the program 
            //prints "Nobody likes a quitter..." before ending

            //Ask for the user's first name
            Console.WriteLine("What is your first name?");
            string userFirstInput = Console.ReadLine();
            string userFirst = userFirstInput.ToLower();

            if (userFirst == "quit")
            {
                Console.WriteLine("Nobody likes a quitter...");
            }

            if (userFirst == "quit")
            {
                Environment.Exit(0);
            }

            else
            {
                //Ask for the user's last name
                Console.WriteLine("What is your last name?");
            }

            string userLastInput = Console.ReadLine();
            string userLast = userLastInput.ToLower();

            if (userLast == "quit")
            {
                Console.WriteLine("Nobody likes a quitter...");
            }

            if (userLast == "quit")
            {
                Environment.Exit(0);
            }

            else 
            {
                //Ask for the user's age
                Console.WriteLine("What is your age? Please enter a number.");
            }

            string userAgeInput = Console.ReadLine();
            string userAge = userAgeInput.ToLower();

            if (userAge == "quit")
            {
                Console.WriteLine("Nobody likes a quitter...");
            }

            if (userAge == "quit")
            {
                Environment.Exit(0);
            }

            else 
            {
            //Ask for the user's birth month (as an 'int')
            Console.WriteLine("What is your birth month? Please enter a number between 1 and 12.");
            }

            string userBirthMonthInput = Console.ReadLine();
            string userBirthMonth = userBirthMonthInput.ToLower();

            if (userBirthMonth == "quit")
            {
                Console.WriteLine("Nobody likes a quitter...");
            }

            if (userBirthMonth == "quit")
            {
                Environment.Exit(0);
            }

            else
            {
                //Ask the user for the user's favorite ROYGBIV color
                //IF the user does not know what ROYGBIV is, ask him/her to enter "Help" to get a list
                Console.WriteLine("What is your favorite ROYGBIV color? If you do not know what ROYGBIV is, enter \"Help\"");
            }

            string userColorInput = Console.ReadLine();
            string userColor = userColorInput.ToLower();

            if (userColor == "quit")
            {
                Console.WriteLine("Nobody likes a quitter...");
            }

            if (userColor == "quit")
            {
                Environment.Exit(0);
            }

            if (userColor == "help")
            {
                Console.WriteLine("ROYGBIV stands for Red, Orange, Yellow, Green, Blue, Indigo, Violet. Please choose your favorite.");
                userColorInput = Console.ReadLine();
                userColor = userColorInput.ToLower();
            }

            {
            //Ask for the user's number of siblings
                Console.WriteLine("How many siblings do you have? Please enter a number.");
            }

            string userSiblingInput = Console.ReadLine();
            string userSibling = userSiblingInput.ToLower();

            if (userSibling == "quit")
            {
                Console.WriteLine("Nobody likes a quitter...");
            }

            if (userSibling == "quit")
            {
                Environment.Exit(0);
            }

            //Parse Variables
            int userAgeInt = int.Parse(userAgeInput);
            int userBirthMonthInt = int.Parse(userBirthMonthInput);
            int userSiblingInt = int.Parse(userSiblingInput);

            //Fortune Variables
            int retireAge = 0;
            string bank = "";
            string transportation = "";
            string vacationHome = "";

            //If the user's age is an odd number, s/he will retire in 20 years. 
            //If the age is even, s/he will retire in 10 years.
            if (userAgeInt % 2 != 0)
            {
                retireAge = 10;
            }
            else
            {
                retireAge = 20;
            }                        
            //If the user's birth month is 1-4, s/he will have $50,000 in the bank
            //If the user's birth month is 5-8, s/he will have $100,000 in the bank
            //If the user's birth month is 9-12, s/he will have $1,000,000 in the bank
            //If the user enters a number other than 1-12, s/he will have $0 in the bank.
            if (userBirthMonthInt > 1 && userBirthMonthInt < 5)
            {
                bank = "$50,000";
            }
            else if (userBirthMonthInt > 4 && userBirthMonthInt < 9)
            {
                bank = "$100,000";
            }
            else if (userBirthMonthInt > 8 && userBirthMonthInt < 13)
            {
                bank = "$1,000,000";
            }
            else 
            {
                bank = "$0";
            }
            //If the user's favorite color is Red, s/he will travel by car
            //If the user's favorite color is Orange, s/he will travel by bicycle
            //If the user's favorite color is Yellow, s/he will travel by train
            //If the user's favorite color is Green, s/he will travel by airplane
            //If the user's favorite color is Blue, s/he will travel by scooter
            //If the user's favorite color is Indigo, s/he will travel by boat
            //If the user's favorite color is Violet, s/he will travel by skis            
            if (userColor == "red")
            {
                transportation = "a car";
            }
            else if (userColor == "orange")
            {
                transportation = "a bicycle";
            }
            else if (userColor == "yellow")
            {
                transportation = "a train";
            }
            else if (userColor == "green")
            {
                transportation = "an airplane";
            }
            else if (userColor == "blue")
            {
                transportation = "a scooter";
            }
            else if (userColor == "indigo")
            {
                transportation = "a boat";
            }
            else
            {
                transportation = "skis";
            }
            //If the user's number of siblings is 0, s/he will have a vacation home in Rome.
            //If the user's number of siblings is 1, s/he will have a vacation home in Paris.
            //If the user's number of siblings is 2, s/he will have a vacation home in Chile.
            //If the user's number of siblings is 3 or more, s/he will have a vacation home in Canada.
            //If the user's number of siblings is less than 0, s/he will have a vacation home in Cleveland, OH.
            if (userSiblingInt == 0)
            {
                vacationHome = "Rome";
            }
            if (userSiblingInt == 1)
            {
                vacationHome = "Paris";
            }
            if (userSiblingInt == 2)
            {
                vacationHome = "Chile";
            }
            if (userSiblingInt >= 3)
            {
                vacationHome = "Canada";
            }
            else
            {
                vacationHome = "Cleveland, OH";
            }

            //The fortune: [First Name] [Last Name] will retire in [# of Years] with [Amount of Money] in the bank, 
            //a vacation home in [Location] and a [Mode of Transportation].

            Console.WriteLine(userFirstInput + " " + userLastInput + " will retire in " + retireAge + " years" + " with " + bank + " in the bank, a vacation home in " + vacationHome + ", and " + transportation + ".");
        }
    }
}
