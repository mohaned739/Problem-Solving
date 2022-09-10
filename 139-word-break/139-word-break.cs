public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        return Helper(s, wordDict, 0, s.Length - 1, new bool?[s.Length, s.Length]) ??default(bool);
    }
    
    private  bool? Helper(string s, IList<string> dict, int i, int j, bool?[,] cache)
        {
            if (dict.Contains(s.Substring(i, j - i + 1)))
                cache[i, j] = true;
            else if (cache[i, j] != null)
                return cache[i, j];
            else if (i == j)
                cache[i, j] = false;
            else
                for (int k = i; k <= j; k++)
                {
                    cache[i, j] = (Helper(s, dict, i, k, cache) ?? default(bool)) && (Helper(s, dict, k + 1, j, cache) ?? default(bool)) ? true : false;

                    if (cache[i, j] ?? default(bool))
                        break;
                }

            return cache[i, j];
        }
}