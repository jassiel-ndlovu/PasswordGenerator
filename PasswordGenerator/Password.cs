using System;
using System.Collections.Generic;

public class Password
{
    public List<char> smallCapsChars;

    public List<char> capsChars;

    public List<char> numericsChars;

    public List<char> specialChars;

    public Password()
    {
        InstantiateLists();
    }

    public Password(char[] deselectedChars)
    {
        InstantiateLists();

        foreach (char c in deselectedChars)
        {
            if ((int)c >= 48 && (int)c <= 57)
                numericsChars.Remove(c);
            else if ((int)c >= 65 && (int)c <= 90)
                capsChars.Remove(c);
            else if ((int)c >= 97 && (int)c <= 122)
                smallCapsChars.Remove(c);
            else
                specialChars.Remove(c);
        }
    }

    private void InstantiateLists()
    {
        smallCapsChars = new List<char>
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
            'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
            'u', 'v', 'w', 'x', 'y', 'z'
        };

        capsChars = new List<char>
        {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J',
            'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T',
            'U', 'V', 'W', 'X', 'Y', 'Z'
        };

        numericsChars = new List<char>
        {
            '1', '2', '3', '4', '5', '6', '7', '8', '9', '0'
        };

        specialChars = new List<char>
        {
            '!', '~', '@', '#', '$', '%', '^', '&', '*', '(',
            ')', '_', '-', '=', '+', '{', '}', '[', ']', '|',
            '\\', ':', ';', ',', '.', '<', '>', '?', '/'
        };
    }
}
