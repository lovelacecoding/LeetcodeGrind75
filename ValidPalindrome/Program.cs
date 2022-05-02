using System.Text.RegularExpressions;

namespace ValidPalindrome;

internal class Program
{

    static void Main(string[] args)
    {
        Program pr = new Program();
        pr.Start();
    }

    public void Start()
    {
        Console.WriteLine(IsPalindrome(" "));   
    }
    
    public bool IsPalindrome(string s)
    {
        var lower = s.ToLower().Replace(" ", "");
        var lowerRegex = Regex.Replace(lower, "[^a-zA-Z0-9]", "");
        /*char[] lowerArray = lowerRegex.ToCharArray();
        char[] lowerArrayR = lowerRegex.Reverse().ToArray();

        for (int i = 0; i < lowerArray.Length; i++)
        {
            Console.WriteLine($"{lowerArray[i]} rev: {lowerArrayR[i]}");
            if (lowerArray[i] != lowerArrayR[i])
            {
                return false;
            }
        }
        return true;*/

        return lowerRegex.SequenceEqual(lowerRegex.Reverse());
    }
}