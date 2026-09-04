namespace LeetCode._1502_CanMakeArithmeticProgressionFromSequence;

public class HashSetSolution
{
    public bool CanMakeArithmeticProgression(int[] arr)
    {
        int min = arr.Min();
        int max = arr.Max();
        int n = arr.Length;

        int range = max - min;

        if (range % (n - 1) != 0)
            return false;

        int diff = range / (n - 1);

        var set = new HashSet<int>(arr);

        for (int i = 0; i < n; i++)
        {
            if (!set.Contains(min + i * diff))
                return false;
        }

        return true;
    }
}