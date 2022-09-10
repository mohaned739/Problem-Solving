public class Solution {
    public int[] FindOriginalArray(int[] changed) {
                    if (changed.Length % 2 == 1) return new int[0];
            var dic = GetDictionary(changed);
            if (dic == null) return new int[0];
            var rs = new int[changed.Length / 2];
            var currIndex = 0;
            var keys = dic.Select(p => p.Key).ToList();
            foreach (var key in keys)
            {
                if (key == 0)
                {
                    if (dic[key] % 2 == 1) return new int[0];
                    for (int i = 0; i < dic[key] / 2; i++)
                    {
                        rs[currIndex] = key;
                        currIndex++;
                    }
                    continue;
                }
                if (dic[key] > 0)
                {
                    for (int i = 0; i < dic[key]; i++)
                    {
                        if (currIndex == rs.Length) return new int[0];
                        rs[currIndex] = key;
                        currIndex++;
                    }
                    if (!dic.ContainsKey(key * 2) || dic[key * 2] < dic[key]) return new int[0];
                    dic[key * 2] -= dic[key];
                }
            }
            return rs;
    }
    private SortedDictionary<int, int> GetDictionary(int[] A)
        {
            var rs = new SortedDictionary<int, int>();
            var zeros = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0) zeros++;
                if (!rs.ContainsKey(A[i]))
                {
                    rs.Add(A[i], 1);
                }
                else
                {
                    rs[A[i]]++;
                }
            }
            if (zeros % 2 == 1) return null;
            return rs;
        }
}