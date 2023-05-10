namespace FindTheMedianExercise;

// Given a list of integers with an odd number of elements, find the median
public static class ArrayMedian
{
    public static int findMedian(List<int> arr)
    {
        arr.Sort();

        int length = arr.Count;
        int mid = length / 2;

        return arr[mid];
    }
}