namespace FrequencyCounter;

// Given a list of integers, count and return the number of times each value appears as an array of integers.
public static class FrequencyCount
{
    public static List<int> GetFrequency(List<int> arr)
    {
        Dictionary<int, int> count = new Dictionary<int, int>();
        int[] result = new int[arr.Max() + 1];

        foreach (var num in arr)
        {
            if (count.ContainsKey(num))
                count[num]++;
            else
                count[num] = 1;
        }

        for (int i = 0; i < result.Length; i++)
        {
            if (count.ContainsKey(i))
            {
                result[i] = count[i];
            }
        }

        return result.ToList();
    }
}
