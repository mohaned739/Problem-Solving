public class Solution {
    public bool CheckInclusion(string s1, string s2) {
                    if (s2.Length<s1.Length)
            {
                return false;
            }
Dictionary<char, int> s1Dic = CreateAlphabetDic();
            Dictionary<char, int> s2Dic = CreateAlphabetDic();

            CountLetters(s1, s1Dic);
            string s3 = s2.Substring(0, s1.Length);
            CountLetters(s3, s2Dic);
            for (int i = s1.Length; i < s2.Length; i++)
            {
                if (CheckIfEqual(s1Dic,s2Dic))
                {
                    return true;
                }
                s2Dic[s3[0]]--;
                s3 = s3.Remove(0, 1);
                s3 += s2[i];
                s2Dic[s2[i]]++;
            }
            if (CheckIfEqual(s1Dic, s2Dic))
            {
                return true;
            }
            return false;
        }
         Dictionary<char, int> CreateAlphabetDic()
        {
            Dictionary<char, int> alphabet = new Dictionary<char, int>();
            for (char i = 'a'; i <= 'z'; i++)
            {
                alphabet.Add(i, 0);
            }
            return alphabet;
        }

         void CountLetters(string s, Dictionary<char, int> dic)
        {
            foreach (char letter in s)
            {
                dic[letter]++;
            }
        }
         bool CheckIfEqual(Dictionary<char, int> dic1, Dictionary<char, int> dic2)
        {
            for (char i = 'a'; i <= 'z'; i++)
            {
                if (dic1[i]!=dic2[i])
                {
                    return false;
                }
            }
            return true;
        }
}