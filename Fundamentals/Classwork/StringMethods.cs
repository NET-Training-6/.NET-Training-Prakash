using System;
class Paragraph
{
    string story = @"A Boy was given- permission to put his hand into a, pitcher to get some filberts. But he took such a great fistful that he could not draw his hand out again. There he stood, unwillingto give up a single filbert and yet unable to get them all out at once? Vexed and disappointed he began to cry.";
    public void CountSentences()
    {
        char[] separators = { '.', '?' };
        string[] sentences = story.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        int noOfSenetances = sentences.Length;

        Console.WriteLine($"Sentence Counts: {noOfSenetances} and sentances are following:");
        foreach (var s in sentences)
        {
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine(s);
        }
    }

    public void CountWords()
    {
        char[] separators = { ' ', '\t' };
        char[] specialCharacters = { ',', '.', '?', '-', };
        string[] words = story.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        int noOfWords = words.Length;

        Console.WriteLine($"Word Counts: {noOfWords} and words are following:");
        foreach (var s in words)
        {
            var sabda = s;
            Console.WriteLine("--------------------------------------------------------");

            // Remove special characters from word
            foreach (char sc in specialCharacters)
            {
                if (sabda.Contains(sc))
                {
                    sabda = sabda.Replace(sc.ToString(), "");
                }
            }

            Console.WriteLine(sabda);
        }
    }

    public void CountCharacters()
    {
        int x = story.Length;
        int noOfSpaces = 0;
        foreach (var c in story)
        {
            if (c == ' ')
            {
                noOfSpaces++;
            }
            else
            {
                Console.Write($"{c}\t");
            }
        }
        Console.WriteLine($"Character Counts: {x - noOfSpaces} and characters are following:");
    }

    public void GetFrequenciesOfCharacters()
    {

        int[] freq = new int[story.Length];
        int i, j;

        //Converts given string into character array  
        char[] string1 = story.ToCharArray();

        for (i = 0; i < story.Length; i++)
        {
            freq[i] = 1;
            for (j = i + 1; j < story.Length; j++)
            {
                if (string1[i] == string1[j])
                {
                    freq[i]++;

                    //Set string1[j] to 0 to avoid printing visited character  
                    string1[j] = '0';
                }
            }
        }

        //Displays the each character and their corresponding frequency  
        Console.WriteLine("Characters and their corresponding frequencies");
        for (i = 0; i < freq.Length; i++)
        {
            if (string1[i] != ' ' && string1[i] != '0')
                Console.WriteLine(string1[i] + "-" + freq[i]);
        }
    }
}

