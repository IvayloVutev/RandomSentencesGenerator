using System;

namespace RandomSentencesGenerator
{
    class RandomSentencesGenerator
    {
        static void Main(string[] args)
        {
            string GetRandomWords(string[] words)
            {
                Random random = new Random();
                int randomIndex = random.Next(words.Length);
                string word = words[randomIndex];
                return word;
            }

            string[] names = { "Peter", "Michell", "Jane", "Steve" };
            string[] places = { "Sofia", "Plovdiv", "Varna", "Burgas" };
            string[] verbs = { "eats", "holds", "sees", "plays with", "brings" };
            string[] nouns = { "stones", "cake", "apple", "laptop", "bikes" };
            string[] adverbs = { "slowly", "diligently", "warmly", "sadly", "rapidly" };
            string[] details = { "near the river", "at home", "in the park" };

            Console.WriteLine("Hello, this is your first random-generated sentence: ");
            Console.WriteLine("Please press [Enter]");
            Console.WriteLine();
                   
            while (true)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    break;
                }

                string randomName = GetRandomWords(names);
                string randomPlace = GetRandomWords(places);
                string randomVerb = GetRandomWords(verbs);
                string randomNoun = GetRandomWords(nouns);
                string randomAdverb = GetRandomWords(adverbs);
                string randomDetails = GetRandomWords(details);

                string who = $"{randomName} from {randomPlace}";
                string action = $"{randomAdverb} {randomVerb} {randomNoun}";
                string sentence = $"{who} {action} {randomDetails}.";
                
                Console.WriteLine(sentence);
                Console.WriteLine("Click [Enter] to generate a new one or press [Esc] to stop");
                Console.WriteLine();
               
            }      
        }
    }
}
