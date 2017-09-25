using System;

namespace Lab6
{
    class PigLatin
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to the Pig Latin Translator!\n");
            bool run = true;
            while (run == true)
            {
                Console.Write("Enter a line to be translate:");
                string inputRequested = Console.ReadLine();
                inputRequested.ToLower();
                string indexZero = inputRequested.Substring(0, 1);
                string translate = " ";
                int x = 1;
                int z = inputRequested.Length;
                z = z - 1;
                char vowel;
                
                bool lookingForVowels = false;

                if (indexZero == "a" || indexZero == "e" || indexZero == "i" || indexZero == "o" || indexZero == "u")
                {
                    translate = inputRequested + "way";
                    Console.WriteLine(translate);
                    indexZero = "y";
                    lookingForVowels = true;
                }

                while (lookingForVowels == false)
                {
                    vowel = inputRequested[x];
                    x++;

                    if (vowel == 'a' || vowel == 'e' || vowel == 'i' || vowel == 'o' || vowel == 'u')
                    {
                        string isConsonant = inputRequested.Remove(0, (x - 1));
                        string chopped = inputRequested.Substring(0, (x - 1));

                        string pigLatinConsonant = string.Concat(isConsonant, chopped, "ay");

                        Console.WriteLine(pigLatinConsonant);
                        lookingForVowels = true;
                        vowel = 'b';
                        x = 1;
                    }
                }
                run = Continue();
            }
        }
        public static bool Continue()
        {
            Console.WriteLine("\nTranslate another line? (y/n):");
            string input = Console.ReadLine();
            input = input.ToLower();
            bool goOn;
            if (input == "y")
            {
                goOn = true;
                Console.WriteLine(" ");
            }
            else if (input == "n")
            {
                goOn = false;
                Console.WriteLine("\nOk, I hope you found what you needed.");
            }
            else
            {
                Console.WriteLine("I only accept y or n. Please try again.");
                goOn = Continue();
            }
            return goOn;
        }
    }
}