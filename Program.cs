 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask for user input, seperated by spaces
            Console.WriteLine("Please enter a sentence");
            string userSentence = Console.ReadLine();
            string [] seperateWords = userSentence.Split(' '); //break sentence into individual words
            string longWord = "a"; // look for longest word in array of seperate words
            int wordLengthLongest = 0;


            for (int i = 0; i < seperateWords.Length; i++)//repeat through sentence until end
            {
                int wordLength = seperateWords[i].Length; //length of individual word
                if(wordLength > wordLengthLongest)//compare word length to zero
                {
                    wordLengthLongest = wordLength;//saves length of word
                    longWord = seperateWords[i];//saves specific word
                }
            }

            Console.WriteLine(longWord);
            Console.ReadKey();
        }

    }
}
