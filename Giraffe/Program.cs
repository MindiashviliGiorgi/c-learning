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
            /*
            bool isMale = true;
            bool isTall = true;
            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            } else if (isMale && !isTall) {
                Console.WriteLine("You are not a short male");
            } else if (!isMale && isTall) {
                Console.WriteLine("You are not male but you are tall");
            } else
            {
                Console.WriteLine("You are not male and tall ");
            }
            */

            // 13 more if statements

            // Console.WriteLine(GetMax(2, 10));
            // Console.WriteLine(GetMax(23, 10));
            // Console.WriteLine(MoreGetMax(19, 43, 6));

            // 14 Building a better calculator
            /*
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter a second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            } else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            } else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            } else if (op == "/") 
            {
                Console.WriteLine(num1 / num2);
            } else
            {
                Console.WriteLine("Invalid oparator");
            }
            */

            // 15 Switch Statements
            // Console.WriteLine(GetDay(3));

            // 16 While Loops
            // int index = 6;
            /*
            while(index <= 9)
            {
                Console.WriteLine(index);
                index++;
            }
            */
            /*
            do
            {
                Console.WriteLine(index);
                index++;
            }
            while (index <= 5);
            */

            // 17 Building a Guessing Game
            /*
            string secretWord = "Giorgi";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuess = false;

            while(guess != secretWord && !outOfGuess)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Guess secret name: ");
                    guess = Console.ReadLine();
                    guessCount++;
                } else
                {
                    outOfGuess = true;
                }
            }
            if (outOfGuess)
            {
                Console.WriteLine("You lose");
            } else
            {
                Console.WriteLine("You win");
            }
            */

            // 18 For Loops
            /*
            int[] numbers = { 3, 6, 8, 14, 57 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            };
            */

            // easy leetcode task for find Max number in array
            // int[] nums = { 1, 4, 2, 19, 31 };
            // Console.WriteLine(FindMax(nums));

            // 19 Building an Exponent Method
            // Console.WriteLine(GetPow(3, 3));

            // 20 2d array
            /*
            int[,,] numberGrid = {
                { 1, 2, 3 },
                { 3, 4, 5 },
                { 5, 6, 2 }
            };
            for (int i = 0; i < numberGrid.GetLength(0); i++)
            {
                for (int j = 0; j < numberGrid.GetLength(1); j++)
                {
                    Console.WriteLine(numberGrid[i, j] + " ");
                }
                Console.WriteLine();
            }
            
            int[,] numberGrid =
            {
                {1, 2 },
                {3, 4 },
                {5, 6 }
            };
            int[,] myArray = new int[2, 3];
            Console.WriteLine(myArray);
            */

            // 21 Palindrome Checker LeetCode Task
            /*
            while(true)
            {
                Console.Write("Enter your word: ");
                string myWord = Console.ReadLine();

                if (!IsPalindrome(myWord))
                {
                    Console.WriteLine($"{myWord} is not a palindrome");
                }
                else
                {
                    Console.WriteLine($"{myWord} is a palindrome");
                    break;
                }
            }
            */
            // 22 Exception Handling
            /*
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            */

            // 23 classes & objects

            


            Console.ReadLine();
        }

        static bool IsPalindrome(string str)
        {
            string cleanedString = str.Replace(" ", "").ToLower();
            
            for (int i = 0; i < cleanedString.Length / 2; i++)
            {
                if (cleanedString[i] != cleanedString[cleanedString.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;

            for (int i = 0; i < powNum; i++)
            {
                result = result * baseNum;
            }

            return result;
        }

        static int FindMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        static int TwoSum(int a, int b)
        {
            return a + b;
        }

        static string GetDay(int dayNum)
        {
            string dayName;

            switch(dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;
            }

            return dayName;
        }

        static int MoreGetMax(int num, int num2, int num3)
        {
            int result;
            result = num;
            if (num2 > result)
            {
                result = num2;
            }
            if (num3 > result)
            {
                result = num3;
            }
            return result;
        }

        static int GetMax(int num, int num2)
        {
            int result;
            if (num > num2)
            {
                result = num;
            } else
            {
                result = num2;
            }
            return result;
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
