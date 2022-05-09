public class Solution {
    public void ReverseString(char[] s) {
        int back=s.Length-1;
    for (int i=0; i<s.Length; i++)
    {
        if (i == back || i>back)
        {
            break;
        }
        char temp = s[i];
        s[i]=s[back];
        s[back]=temp;
        back--;
    }
    }
}