using System;
using System.Collections.Generic;

namespace Anagram
{
    public class AnagramClass
    {
        public static void Main()
        {
            List<string> anagramList = new List<string>(){};
            List<string> stringList = new List<string>(){};
            Console.WriteLine("Enter your first word:");
            string userInput = Console.ReadLine();
            string inputArray = inputToSortedArray(userInput);
            Console.WriteLine("Enter your second word:");
            addInput2ToList(stringList);
            foreach(string Word in stringList)
            {
                string inputArray2 = inputToSortedArray(Word);
                compareSortedStrings(inputArray, inputArray2, Word, anagramList); 
            }          
        }

        public static string inputToSortedArray(string userWord)
        {
            char[] userArray = userWord.ToCharArray();
            Array.Sort(userArray);
            string sortedString = new string(userArray);
            return sortedString;            
        }

        public static void compareSortedStrings(string userWord, string userWord2, string userInput2, List<string> anagramList)
        {
            if (userWord == userWord2)
            {
                anagramList.Add(userInput2);
                Console.WriteLine("your matching word is " + userInput2);
                
            }
            else
            {
                
            }
        }

        public static void addInput2ToList(List<string> stringList)
        {
            string userInput2 = Console.ReadLine();
            if (userInput2 != "q")
            {
                stringList.Add(userInput2);
                addInput2ToList(stringList);
            }
            else
            {
               
            }
        }
    }   
}
