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

            Console.ReadLine();
        }
    }
}
