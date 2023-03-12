using System;

class Program
{
    public static string reverseWords(string sentence)
    {
        string reversedSentence = "";
        string reversedWord = "";

        // iterate over the sentence in reverse order
        for (int i = sentence.Length - 1; i >= 0; i--)
        {
            if (sentence[i] == ' ') // found a space, add the reversed word to the reversed sentence
            {
                reversedSentence += reversedWord + " ";
                reversedWord = "";
            }
            else // add the character to the reversed word
            {
                reversedWord = sentence[i] + reversedWord;
            }
        }

        // add the last reversed word to the reversed sentence
        reversedSentence += reversedWord;

        return reversedSentence;
    }

    static void Main(string[] args)
    {
        string sentence = "The quick brown fox";
        string reversedSentence = reverseWords(sentence);
        Console.WriteLine(reversedSentence); // Output: "fox brown quick The"
    }
}
