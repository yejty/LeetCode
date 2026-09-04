namespace LeetCode;

public class PalindromeNumber
{
    public bool IsPalindrome(int x)
    {
            string s = x.ToString();
            char[] arr = s.ToCharArray();
            char[] arr_rev = new char[arr.Length];
            var n = arr.Length;
            for (var i = 0; i <= n/2; i++)
            {
                arr_rev[i] = arr[n-i-1];
                if (arr[i] != arr_rev[i])
                    return false;
            } 
            return true;
    }
}
