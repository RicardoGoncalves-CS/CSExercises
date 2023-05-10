namespace LonelyInteger;

public static class LoneInt
{
    // >> Given an array of integers, where all elements but one occur twice, find the unique element. 
    public static int Find(List<int> a)
    {
        Dictionary<int, int> count = new Dictionary<int, int>();

        foreach (var val in a)
        {
            if (count.ContainsKey(val))
                count[val]++;
            else
                count[val] = 1;
        }

        foreach (var kvp in count)
        {
            if (kvp.Value == 1)
                return kvp.Key;
        }

        return -1;
    }
}
