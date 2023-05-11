using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridChallengeExercise
{
    // Given a grid of characters in the range ascii[a-z], rearrange elements of each row alphabetically, ascending.
    // Determine if the columns are also in ascending alphabetical order, top to bottom.
    // Return YES if they are or NO if they are not.
    
    // Example (both rows and columns are ordered alphabetically):
    // a b c
    // c f h
    // i m n
    public static class GridChallenge
    {
        public static string IsOrdered(List<string> matrix)
        {
            int strLen = matrix[0].Length;
            List<string> orderedMatrix = new List<string>();

            foreach (var str in matrix)
            {
                char[] characters = str.ToArray();
                Array.Sort(characters, StringComparer.Ordinal);
                string sortedStr = new String(characters);

                orderedMatrix.Add(sortedStr);
            }

            for (int i = 0; i < strLen; i++)
            {
                for (int j = 0; j < orderedMatrix.Count - 1; j++)
                {
                    if (orderedMatrix[j][i] > orderedMatrix[j + 1][i])
                    {
                        return "NO";
                    }
                }
            }
            return "YES";
        }
    }
}
