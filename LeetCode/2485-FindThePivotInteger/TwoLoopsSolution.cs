namespace LeetCode._2485_FindThePivotInteger;

public class TwoLoopsSolution
{
    public int PivotInteger(int n) {
        int countI = 0;
        int countJ = 0;
        for (int i = 1; i <= n; i++)
        {
            countI = countI + i;
            countJ = 0;
            for (int j = i; j <= n; j++)
            {
                countJ = countJ + j;
            }
            if (countI == countJ)
            {
                return i;
            }
        }
        return -1;
    }
}