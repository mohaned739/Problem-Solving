public class Solution {
    public string ReverseWords(string s) {
        string[] words = s.Split(' ');
    for (int i = 0; i < words.Length; i++)
    {
        char [] word = words[i].ToCharArray();
        Array.Reverse(word);
        words[i]= new string(word);
    }
    return string.Join(' ',words);
    }
}