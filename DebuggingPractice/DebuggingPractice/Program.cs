﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        /// <summary>
        /// Check for the number of t's in a string
        /// </summary>
        /// <param name="input">string to test</param>
        /// <returns>the number of t's found</returns>
        public static int CountTs(string input)
        {
            int counter = 0;
            // loop through each character
    //****int i has to equal 0***
            for (int i = 0; i < input.Length; i++)
            {
                // check if it's a t
    //****checked the string t against input[i] w/ ToString and ToLower****
                if ("t" == input[i].ToString().ToLower())
                {
                    // true so add to the number of t's
                    counter++;
                }
            }
            // return the number of t's
            return counter;
        }

        /// <summary>
        /// A palindrome is a word or phrase that can be spelled the same
        /// both backwards and forwards. This function will determine if an
        /// input string is a palindrome.
        /// </summary>
        /// <param name="input">string to test</param>
        /// <returns>true if the string is a palindrome</returns>
        public static bool IsPalindrome(string input)
        {
            // loop through each character
            for (int i = 0; i < input.Length; i++)
            {
                // check the character with it's partner
                // on the other end of the string
    //*****changed second to [(input.Length-1)-i], added .ToString().ToLower() to each and made == !=
                if (input[i].ToString().ToLower() != input[(input.Length-1)-i].ToString().ToLower())
                {
                    // if there ever isn't a match then the string
                    // is not a palindrome
                    return false;
                }
            }
            // Must be a palindrome since it never failed before
            return true;
        }

        /// <summary>
        /// A function that checks if an input string is a valid ISBN number.
        /// </summary>
        /// <param name="ISBN">string to test</param>
        /// <returns>true if it is a valid ISBN</returns>
        public static bool IsValidISBN(string ISBN)
        {
            // strip dashes
            string number = ISBN.Replace("-",string.Empty);
            // int used for holding the sum
            int resultNum = 0;
            // loop through each number
    //***change i+=2 to i++
            for (int i = 0; i < number.Length; i++)
            {
                // do the calculation for ISBN by multiplying each number
                // by it's order in the string and summing the results up
    //***made = to +=  
                resultNum += number[i] * (number.Length - i);
            }
            // true if the sum is divisible by 11
    //***changed * to %
            return resultNum % 11 == 0;
        }


        /// <summary>
        /// A panagram is a string that contains each letter of the alphabet at least once.
        /// This function will return true if the input string is a panagram.
        /// </summary>
        /// <param name="input">string to test</param>
        /// <returns>true if is a panagram</returns>
        public static bool IsPanagram_(string input)
        {
            //List<string> alphabet = new List<string>();
    //***made an alphabet string will all letters of alphabet to check
    //***made new string that copies input string, except in all Lowercase
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string inputLower = input.ToLower();
            // loop through each letter in the input string
            for (int i = 0; i < input.Length; i++)
            {
                // letter validation
                if (char.IsLetter(input[i]))
                {
    //***made nested for loop to check each letter of the input with every letter in alphabet
                    for (int j = 0; j < alphabet.Length; j++)
                    {
                    // only add the letter if it doesn't exist in the list
                    //if (alphabet.Contains(input[i].ToString()))
    //***if the input does not contain every letter of the 
                        if (!inputLower.Contains(alphabet[j].ToString().ToLower()))
                        {
                        // add the letter to the list
                        //alphabet.Add(input[i].ToString());
                            return false;
                        }
                    }
                }
            }
            // return true if all letters in the alphabet are contained
            //return alphabet.Count == 36;
            return true;
        }

        //much faster way
        public static bool IsPanagram(string input)
        {
            List<string> alphabet = new List<string>();
            // loop through each letter in the input string
            for (int i = 0; i < input.Length; i++)
            {
                // letter validation
                if (char.IsLetter(input[i]))
                {
                    // only add the letter if it doesn't exist in the list
                    if (!alphabet.Contains(input[i].ToString().ToLower()))
                    {
                        // add the letter to the list
                        alphabet.Add(input[i].ToString().ToLower());
                    }
                }
            }
            // return true if all letters in the alphabet are contained
            return alphabet.Count == 26;
        }
    }
}
