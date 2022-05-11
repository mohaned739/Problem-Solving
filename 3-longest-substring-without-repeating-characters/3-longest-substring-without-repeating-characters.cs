public class Solution {
    public int LengthOfLongestSubstring(string s) {
         int i = 0;
            int j = 0;
            int max = 0;
            HashSet<char> set = new HashSet<char>(); 
            while (i<s.Length)
            {
                if (set.Contains(s[i]))
                {
                    set.Remove(s[j]);
                    j++;
                    continue;
                }
                set.Add(s[i]);
                int diff = i - j + 1;
                if (diff>max)
                {
                    max = diff;
                }
                i++;
            }

            return max;
    }
}