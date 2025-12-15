using System;

namespace ReverseSentenceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence:");
            string input = Console.ReadLine();

            string reversed = ReverseSentence(input);
            Console.WriteLine($"Reversed Sentence: {reversed}");
        }

        static string ReverseSentence(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence))
                return sentence;

            string[] words = sentence.Split(' ');
            Array.Reverse(words);

            return string.Join(" ", words);
        }
    }
}
