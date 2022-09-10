public class Solution {
    public string ReverseWords(string s) {
            s = s.Trim();
            var words = s.Split(' ');
            s = "";
            for (int i = words.Length-1; i >= 0; i--)
            {
                if (words[i]=="")
                {
                    continue;
                }
                s += words[i] + " ";
            }
            s = s.Trim();
            return s;
    }
}