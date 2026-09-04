namespace LeetCode._2485_FindThePivotInteger;

public class TwoSumsSolution
{
    public int PivotInteger(int n)
    {
        int total = n * (n + 1) / 2;
        int leftSum = 0;

        for (int i = 1; i <= n; i++)
        {
            leftSum += i;

            if (leftSum == total - leftSum + i)
                return i;
        }

        return -1;
    }
}