using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipherExercise;

// Caesar's cipher shifts each letter by a number of letters.
// If the shift takes you past the end of the alphabet, just rotate back to the front of the alphabet.
// In the case of a rotation by 3, w, x, y and z would map to z, a, b and c.
public static class CaesarCipher
{
    public static string GenerateCipher(string s, int k)
    {
        Dictionary<char, int> alphabet = new Dictionary<char, int>
        {
            { 'a', 1 }, { 'b', 2 }, { 'c', 3 }, { 'd', 4 }, { 'e', 5 },
            { 'f', 6 }, { 'g', 7 }, { 'h', 8 }, { 'i', 9 }, { 'j', 10 },
            { 'k', 11 }, { 'l', 12 }, { 'm', 13 }, { 'n', 14 }, { 'o', 15 },
            { 'p', 16 }, { 'q', 17 }, { 'r', 18 }, { 's', 19 }, { 't', 20 },
            { 'u', 21 }, { 'v', 22 }, { 'w', 23 }, { 'x', 24 }, { 'y', 25 },
            { 'z', 26 }
        };

        List<int> upperIndexes = new List<int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (Char.IsUpper(s[i]))
                upperIndexes.Add(i);
        }

        s = s.ToLower();

        StringBuilder sb = new StringBuilder();
        foreach (var letter in s)
        {
            if (alphabet.ContainsKey(letter))
            {
                int shift = alphabet[letter] + k;

                while (shift > 26)
                {
                    shift -= 26;
                }

                while (shift < 1)
                {
                    shift += 26;
                }

                foreach (var kvp in alphabet)
                {
                    if (kvp.Value == shift)
                    {
                        sb.Append(kvp.Key);
                    }
                }
            }
            else
            {
                sb.Append(letter);
            }
        }

        foreach (var i in upperIndexes)
        {
            sb[i] = Char.ToUpper(sb[i]);
        }

        return sb.ToString();
    }
}
