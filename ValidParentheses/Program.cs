// 20 Valid Parentheses on Leetcode https://leetcode.com/problems/valid-parentheses/

using System.Collections;
using System.IO.Pipes;

namespace ValidParentheses;

internal class Program
{
    private string testString = "({})";

    static void Main(string[] args)
    {
        Program pr = new Program();
        pr.Start();
    }

    public void Start()
    {
        bool isItValid = IsValid(testString);
        Console.WriteLine(isItValid);
    }
    
    public bool IsValid(string s)
    {
        Stack stack = new Stack();

        if (s.ToCharArray().Length % 2 != 0) return false; //parentheses are always in pairs. if stack is uneven something is wrong

        foreach (var c in s)
        {

            if (c == ')' && stack.Count != 0 && stack.Peek()?.ToString() == "(") stack.Pop();//  pop stack if matching close bracket is found
            
            else if (c == '}' && stack.Count != 0 && stack.Peek()?.ToString() == "{") stack.Pop();

            else if (c == ']' && stack.Count != 0 && stack.Peek()?.ToString() == "[") stack.Pop();

            else stack.Push(c); //push the opening bracket
        }

        return stack.Count == 0;
    }
    
}