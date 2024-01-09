using System;

public class RegEx
{
	// Word key: 's' (smallCaps), 'c' (Caps), 'n' (numerics),
	// 'p' (special)
	private string regex = string.Empty;
	private readonly string[] characterSets = new string[]
	{
		"s", "c", "n", "p"
	};

    //Constructor
    public RegEx(int regex_length)
    {
        generateRegEx(regex_length, true, true, true, true);
    }

    // Overloaded constructor
	public RegEx(int regex_length, bool smallCaps, bool caps, bool numerics, bool special)
	{
		generateRegEx(regex_length, smallCaps, caps, numerics, special);
	}
	
    // Return the regular expression generated
	public string getRegEx()
	{ 
		return regex;
	}

    // The function that will generate the regular expressions
	private void generateRegEx(int regex_length, bool smallCaps, bool caps, bool numerics, bool special)
	{
        const int charSetWidth = 6;
        const int n = 4;
        // This array keeps track of which set of characters
        // is usable. If available[i] == 1, then the slot is
        // temporarily unavailable. If 2 then completely
        // unavailable. If 0 then available

        // available = {smallCaps, caps, numerics, special}
        int[] available = new int[n] { 0, 0, 0, 0 };

        // Tick of completely unavailable
        if (!smallCaps) available[0] = 2;
        if (!caps) available[1] = 2;
        if (!numerics) available[2] = 2;
        if (!special) available[3] = 2;

        while (regex.Length < regex_length)
        {
            Random random = new Random();
            // Pick a new character set randomly
            int random_pick = random.Next(0, 4);

            while (available[random_pick] != 0)
                random_pick = ++random_pick % 4;

            // Random length for new character set
            int newCharSetLength = random.Next(0, charSetWidth);

            //Finally update the regex
            for (int i = 0; i < newCharSetLength; i++)
                regex += characterSets[random_pick];
        }
    }
}
