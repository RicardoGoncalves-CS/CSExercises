﻿namespace NewYearChaosExercise;

public static class NewYearChaos
{
    // Each person wears a sticker indicating their initial position in the queue from 1 to n.
    // Any person can bribe the person directly in front of them to swap positions, but they still wear their original sticker.
    // One person can bribe at most two others.
    // Determine the minimum number of bribes that took place to get to a given queue order.
    // Print the number of bribes, or, if anyone has bribed more than two people, print Too chaotic.
    public static void minimumBribes(List<int> q)
    {
        int bribes = 0;

        for (int i = 0; i < q.Count; i++)
        {
            int shift = q[i] - (i + 1);

            if (shift > 2)
            {
                Console.WriteLine("Too chaotic");
                return;
            }

            for (int j = Math.Max(0, q[i] - 2); j < i; j++)
            {
                if (q[j] > q[i])
                {
                    bribes++;
                }
            }
        }

        Console.WriteLine(bribes);
    }
}
