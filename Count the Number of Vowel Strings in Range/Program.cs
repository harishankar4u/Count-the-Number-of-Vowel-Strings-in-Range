using System;

public class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(CountVowelInString(["hey", "aeo", "mu", "ooo", "artro"],1,4)); //output 3
        Console.WriteLine(CountVowelInString(["are", "amy", "u"], 0, 2)); //output 2
    }
    public static int CountVowelInString(string[] words, int left, int right)
    {
        int count= 0;
        for (int i = left; i <= right; i++)
        {
            string word = words[i];
           int lefts = 0;
            int rights = words[i].Length-1;
            if (IsVowel(word[lefts]) && IsVowel(word[rights]))
            {
                count++;
            }
        }
        return count;
    }
    private static bool IsVowel(char ch)
    {
        return ("aeiou").IndexOf(ch) >= 0;
    }
}