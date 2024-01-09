using System;
using System.Text;

public class RandomPassword : Password
{
    private StringBuilder password;
    private string regex;
    private Password passwordDS;
    private int length;

    public RandomPassword(int _length, char[] deselectedChars)
    {
        this.length = _length;
        this.regex = (new RegEx(_length)).getRegEx();
        this.passwordDS = new Password(deselectedChars);
        this.password = new StringBuilder(_length);

        generatePassword();
    }

    // Overloaded Constructor to specify which types are allowed
    public RandomPassword(int _length, bool smallCaps, bool caps, bool numerics, bool special, char[] deselectedChars)
    {
        this.length = _length;
        this.regex = (new RegEx(_length, smallCaps, caps, numerics, special)).getRegEx();
        this.passwordDS = new Password(deselectedChars);
        this.password = new StringBuilder();

        generatePassword();
    }

    private void generatePassword()
    {
        Random random = new Random();
        int pick;

        for (int i = 0; i < length; i++)
        {
            if (regex[i] == 's')
            {
                pick = random.Next(0, passwordDS.smallCapsChars.Count);
                password.Append(passwordDS.smallCapsChars[pick]);
            } else if (regex[i] == 'c')
            {
                pick = random.Next(0, passwordDS.capsChars.Count);
                password.Append(passwordDS.capsChars[pick]);
            } else if (regex[i] == 'n')
            {
                pick = random.Next(0, passwordDS.numericsChars.Count);
                password.Append(passwordDS.numericsChars[pick]);
            } else if (regex[i] == 'p')
            {
                pick = random.Next(0, passwordDS.specialChars.Count);
                password.Append(passwordDS.specialChars[pick]);
            }
        }
    }

    public string getRegEx()
    {
        return regex;
    }

    public string getPassword()
    {
        return password.ToString();
    }
}
