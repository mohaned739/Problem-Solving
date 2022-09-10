public class Solution {
    public int CountSubstrings(string s) {
                    int res = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int l = i, r = i;
                while (l>=0 && r< s.Length && s[l]==s[r])
                {
                    res += 1;
                    l -= 1;
                    r += 1;
                }
                l = i;
                r = i + 1;
                while (l >= 0 && r < s.Length && s[l] == s[r])
                {
                    res += 1;
                    l -= 1;
                    r += 1;
                }
            }
            return res;
    }
}