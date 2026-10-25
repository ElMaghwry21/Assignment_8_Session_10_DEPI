using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_8_Session_10_DEPI
{
    public static class CharacterFinder
    {
        public static int GetFirstNonRepeatedCharacterIndex(string input)
        {
            if (string.IsNullOrEmpty(input))
                return -1;

            Dictionary<char, int> charCounts = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (charCounts.ContainsKey(c))
                    charCounts[c]++;
                else
                    charCounts[c] = 1;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (charCounts[input[i]] == 1)
                {
                    return i;
                }
            }

            return -1; 
        }
    }
}
