using System;
using System.IO;
using System.Collections.Generic;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader inputfile;
            inputfile = File.OpenText(@"C:\users\jnarv\documents\Activity12Input.txt");

            //creates a single string from input file
            string stringRead = inputfile.ReadToEnd();
            string pr = null;

            //remove punctuation
            
            foreach (char c in stringRead)
            {
                if (!char.IsPunctuation(c))
                {
                    pr += c;
                }
            }
         
            //create a new string array of all words without punctuation
             
            string[] splitWords = pr.Split(new[] { " ", "\n"}, StringSplitOptions.None);
           
            //determine if word ends in T or E
            int letterCounter = 0;
            foreach(string str in splitWords)
            {
                if(str.ToLower().EndsWith("e") || str.ToLower().EndsWith("t"))
                    {
                    letterCounter += 1;
                    Console.WriteLine(letterCounter + ": " + str);

                    }
                
            }
            
            Console.WriteLine("The number of words that end with t's are e's is " + letterCounter);
            
            inputfile.Close();
            
        }
        
    }
}
