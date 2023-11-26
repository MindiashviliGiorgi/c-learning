using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 create triangle
            /*
              Console.WriteLine("Hello World");
              Console.WriteLine("   /|");
              Console.WriteLine("  / |");
              Console.WriteLine(" /  |");
              Console.WriteLine("/___|");
            */

            // 2 variables
            /*
            string characterName = "Mike";
            int characterAge;
            characterAge = 99;

            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");

            characterName = "Peter";
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);
            */

            // 3 Data Types
            /*
            string phrase = "Giraffe Academy";
            char grade = 'C';
            int age = 23;
            double gpa = 3.5;
            bool isMale = true;
            */

            // 4 Working with Strings
            /*
            string phrase = "Giraffe Academy";
            Console.WriteLine(phrase.Length); // sting length
            Console.WriteLine(phrase.ToUpper()); // upperCase
            Console.WriteLine(phrase.ToLower()); // lowerCase
            Console.WriteLine(phrase.Contains("Academy")); // is inside a phrase string Academy
            Console.WriteLine(phrase[0]); // get index from string
            Console.WriteLine(phrase.IndexOf("Academy")); // return number of index where begin Academy str
            // if IndexOf function return -1 its mean inside string is not posted string
            Console.WriteLine(phrase.IndexOf('G')); // return same but if we need to find single G we need '';
            Console.WriteLine(phrase.Substring(8, 3)); // if we give property only 8 its returning whole string after index 8
            // another way if we give Substring two property 8 will be start index and 3 will be that str.length
            */

            // 5 Working with Numbers
            /*
            Console.WriteLine( 11 % 3 );
            int num = 6;
            num++; // return 7 
            num--; // return 5
            Console.WriteLine( Math.Abs(-6) ); // return 6
            Console.WriteLine(Math.Pow(3, 3)); // return 27
            Console.WriteLine(Math.Sqrt(36)); // return 6
            Console.WriteLine(Math.Max(19, 23)); // can take only two number and return bigger 23
            Console.WriteLine(Math.Min(19, 23)); // can take only two number and return smaller 19
            Console.WriteLine(Math.Round(3.4)); // return 3
            Console.WriteLine(Math.Round(3.5)); // return 4
            */

            // 6 Getting User Input
            /*
            Console.Write("Enter your name : ");
            string name = Console.ReadLine();
            Console.Write("Enter your age : ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " Your age is " + age);
            */

            // 7 Building a mini Calculator
            // int num = Convert.ToInt32("30");
            // Console.WriteLine(num + 3
            // convert to integral
            /*
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            */
            // convert in decimal
            /*
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine
            Console.WriteLine("Your number is : " + Convert.ToDouble(num1 + num2));
            */

            // 8 Building a Mad Libs Game
            /*
            Console.Write("What Color are Roses ? ");
            string color = Console.ReadLine();
            Console.Write("What is Plural noun ? ");
            string plural_noun = Console.ReadLine();
            Console.Write("Who is your favourite celebrity ? ");
            string celebrity = Console.ReadLine();
            */
            /*
            string color, pluralNoun, celebrity;
            Console.Write("Enter a color: ");
            color = Console.ReadLine();
            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();
            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I love " + celebrity);
            */

            // 9 Arrays
            /*
            int[] luckyNumbers = { 1, 3, 5, 7, 8, 19 };
            // create empty array for strings give length property 4 
            string[] friends = new string[4];
            friends[0] = "Giorgi";
            friends[1] = "Mindiashvili";

            Console.WriteLine(friends[0] + " " + friends[1]);

            luckyNumbers[0] = 132;

            // like for loop in js foreach function
            foreach (int number in luckyNumbers)
            {
                Console.WriteLine(number);
            }
            */

            // 10 methods
            /*
            SayHi("Giorgi", 23);
            */

            // 11 Return Statements
            /* 
            // Console.WriteLine(Cube(3));

            int cubedNumber = Cube(3);
            Console.WriteLine(cubedNumber);
            */

            // 12 if statements



            Console.ReadLine();
        }

        
        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }

        static int Cube(int num)
        {
            int result = num * num * num;
            return result;
        }
        

    }
}
