using System;

namespace SentenceFromWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = ""; 
            string word;

            Console.WriteLine("Enter words of a sentence one by one including punctuation:");

            while (true)
            {
                word = Console.ReadLine();

                
                sentence += word + " ";

                
                if (word.EndsWith("."))
                {
                    break;
                }
            }

            
            Console.WriteLine(sentence.Trim());
        }
    }
}

