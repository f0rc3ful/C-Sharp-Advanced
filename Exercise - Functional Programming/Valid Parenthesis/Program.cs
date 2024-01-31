using System;

class Program
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        Console.WriteLine(Valid(s));
    }

    static bool Valid(string s)
    {
        if (s.Length % 2 == 1)
        {
            return false;
        }
        int counter = 0;
        for (int i = 0; i < s.Length / 2; i++)
        {
            if ((s[(s.Length / 2) - 1 - i] == '(' && s[(s.Length / 2) + i] == ')'))
            {
                counter++;
            }
            else if ((s[(s.Length / 2) - 1 - i] == '[' && s[(s.Length / 2) + i] == ']'))
            {
                counter++;
            }
            else if ((s[(s.Length / 2) - 1 - i] == '{' && s[(s.Length / 2) + i] == '}'))
            {
                counter++;
            }
        }
        bool symmetry = false;
        if (counter == s.Length / 2)
        {
            symmetry = true;
        }
        Stack<int> stack = new Stack<int>();
        bool closed = true;
        if (!(symmetry))
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    stack.Push(1);
                }
                else if (s[i] == '[')
                {
                    stack.Push(2);
                }
                else if (s[i] == '{')
                {
                    stack.Push(3);
                }
                else if (s[i] == ')')
                {
                    if (stack.Pop() != 1)
                    {
                        closed = false; ;
                    }
                }
                else if (s[i] == ']')
                {
                    if (stack.Pop() != 2)
                    {
                        closed = false;
                    }
                }
                else if (s[i] == '}')
                {
                    if (stack.Pop() != 3)
                    {
                        closed = false;
                    }
                }
            }
        }
        if (symmetry || closed)
        {
            return true;
        }
        return false;
    }
}