namespace LeetCode._1502_CanMakeArithmeticProgressionFromSequence;

public class TwoArraysSolution
{
    public bool CanMakeArithmeticProgression(int[] arr) {
        arr.Sort();
        int n = arr.Length;
        int prevDiff = arr[n-1] - arr[n-2];
        for (int i=0; i<n-1; i++)
        {
            int diff = arr[i+1] - arr[i];
            if (prevDiff != diff)
                return false;
            prevDiff = diff;
        }
        return true;
    }
}