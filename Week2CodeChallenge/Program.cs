using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is calling the fizzbuzz function that I created below.
            for (var i = 0; i <= 20; i++)
            {
                FizzBuzz(i);
            }
            // This is calling the LetterCounter function. In each string I call the letter that I want to be counted. In these strings its I, n, and s.
            LetterCounter("i", " I love biscuits and gravy. It's the best breakfast ever.");
            LetterCounter("n", " Never gonna give you up. Never gonna let you down.");
            LetterCounter("s", "Sally sells seashells down by the seashore. She's from Sussex.");

            TextStats(" I am liking this program a lot. Even though I am pretty bad at coding and computer language, I refuse to give up. I know I can do this!");
            //This keeps the console window from closing when calling my code.
            Console.ReadKey();
        }
        // This is where I actually write my function FizzBuzz setting it to the parameter number.
        static void FizzBuzz(int number)
    {
            //This is saying that if the number in the function is divisible by 5 and 3, then print out Fizz.
            if(number % 5 == 0 && number % 3 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            //This is saying that otherwise if the number is only divisible by 5, then print out Fizz.
             else if(number % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }
                //This is saying that otherwise if the number is only divisible by 3, then print out Buzz.
            else if (number % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }
                //This is saying that otherwise if the number is not divisble by anything just keep the number a number.
            else
            {
                Console.WriteLine(number);
            }

    }
        //This is where I write my function letter counter which will count letters in a string.
        static void LetterCounter(string letter, string inString)
        {
            // This is declaring a few variables that will count lower case letters, upper case letters, and the total letters.
            int countLower = 0;
            int countUpper = 0;
            int countTotal = 0;
            // This for loop is looping through each character in the string one by one.
            for (var i = 0; i < inString.Length - 1; i++)
            {
                //This variable is setting one letter to the 
                var oneLetter = inString[i].ToString();
                //This is stating that if the letter is lowercase, then we should count the lower case letters.
                if(letter.ToLower() == oneLetter )
                {
                    countLower = countLower + 1;
                }
                    //This is stating that if the letter is uppercase we should count upper.
                else if (letter.ToUpper() == oneLetter)
                {
                    countUpper = countUpper + 1;
                }
                // This is saying that we should set countTotal to the letters in uppercase and lowercase. This way it gives us the total number of letters.
            countTotal = countLower + countUpper;


            }
            //This is so our console looks nice when we print out our strings. It also maes everything work and print to the console.
            Console.WriteLine("Input:" + inString);
            Console.WriteLine("Number of lowercase " + letter + "s found: " + countLower);
            Console.WriteLine("Number of uppercase " + letter + "s found: " + countUpper);
            Console.WriteLine("Total number of " + letter + "s found: " + countTotal);
        }
        //This is where I create my function TextStats and put it in the parameters.
        static void TextStats(string input)
        {
            //Here i
           
            int characters = input.Length;
            int words = 0;
            int vowels = 0; 
            int consonants = 0; 
            int specialChars = 0;
             string longestWord = "serious ";
            string shortestWord = "am";

            string[] myArray ={"I","am","serious"};
            foreach(string item in myArray)
            {
                Console.WriteLine(item);
            }
        for(var i =0; i < characters; i++)
        {
            var d = input[i];

            if (d == 'a' || d == 'e' || d == 'i' || d == 'o' || d == 'u')
            {
                vowels += 1;
            }
            else if (d == 'b' || d == 'c' || d == 'd' || d == 'f' || d == 'g' || d == 'h' || d == 'j' || d == 'k' || d == 'l' || d == 'm' || d == 'n' || d == 'p' || d == 'q' || d == 'r' || d == 's' || d == 't' || d == 'v' || d == 'w' || d == 'x' || d == 'z')
            {
                consonants += 1;
            }
            else
            {
                specialChars += 1;
            }
           
            }
            Console.WriteLine("Number of characters: " + characters);
            Console.WriteLine("Number of words: " + words );
            Console.WriteLine("Number of vowels: " + vowels);
            Console.WriteLine("Number of consonants: " + consonants);
            Console.WriteLine("Number of special characters " + characters);
            Console.WriteLine("Longest word " + longestWord);
            Console.WriteLine("Shortest word: " + shortestWord);

            }
        }
    }
    

   

