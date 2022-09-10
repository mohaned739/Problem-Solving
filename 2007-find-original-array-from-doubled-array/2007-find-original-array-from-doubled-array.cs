public class Solution {
    public int[] FindOriginalArray(int[] changed) {
        if (changed.Length % 2 == 1) return new int[] {}; // this is important for zeros
        
        var count = changed.GroupBy(x => x, (key, g) => (key, count: g.Count())).ToDictionary(p => p.key, p => p.count);
        
        List<int> result = new(Enumerable.Repeat(0, changed.Count(0.Equals) / 2)); // zero is special case
        foreach (int val in changed.Where(val => val != 0)) 
        {
            if(!Solve(val)) return new int[] {};
            
            bool Solve(int val) 
            {
                if (val % 2 == 0 && count.TryGetValue(val / 2, out int cnt) && cnt > 0 && !Solve(val / 2)) return false;
                
                if (count[val] == 0) return true;
                
                count.TryGetValue(val * 2, out int cnt2);
                if (count[val] > cnt2) return false;
                
                result.AddRange(Enumerable.Repeat(val, count[val]));
                
                count[val * 2] -= count[val];
                count[val] = 0;
                
                return true;
            }
        }
        return result.ToArray();
    }
}