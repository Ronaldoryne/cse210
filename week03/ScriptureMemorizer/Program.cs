using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Reference reference = new Reference("John", "3", "16");
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        Console.WriteLine(scripture.ToString());

        while (true)
        {
            Console.WriteLine("Press Enter to hide a word, or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWord();
            Console.Clear();
            Console.WriteLine(scripture.ToString());

            // Check if all words are hidden
            if (scripture.AreAllWordsHidden())
            {
                Console.WriteLine("Congratulations! You've hidden all the words.");
                break;
            }
        }

    }
}
